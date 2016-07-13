using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using Detect.Dbscan;
using Detect.DenseOpticalFlow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Detect
{
    public class VideoProcessor : IDisposable
    {
        public string FilePath { get; }
        public int FrameInterval { get; private set; }
        public bool ComputeFlowImage { get; private set; }
        public double? VectorGlobalThreshold { get; private set; }
        public int WindowSideLength { get; private set; }
        public double Epsilon { get; private set; }
        public int MinPts { get; private set; }
        public double OrientationAngle { get; private set; }
        public FarnebackParameters Parameters { get; private set; }

        private int counter;
        private Capture capture;
        private Image<Bgr, byte> prevImage;

        public Action<Image<Bgr, byte>> ImageProcessed;
        public Action<Image<Bgr, byte>> OpticalFlowVectorsProcessed;
        public Action BeforeProcessFrame;
        private bool imageGrabbedSet;

        public VideoProcessor(
            string filePath)
        {
            FilePath = filePath;
        }

        public void SetParameters(
            int frameInterval,
            double orientationAngle,
            double? vectorGlobalThreshold,
            int windowSideLength,
            bool computeFlowImage,
            double epsilon,
            int minPts,
            FarnebackParameters farnebackParameters)
        {
            FrameInterval = frameInterval;
            VectorGlobalThreshold = vectorGlobalThreshold;
            ComputeFlowImage = computeFlowImage;
            WindowSideLength = windowSideLength;
            Epsilon = epsilon;
            MinPts = minPts;
            OrientationAngle = orientationAngle;
            Parameters = farnebackParameters;
        }

        public void StartCapture()
        {
            //try to create the capture
            if (capture == null)
            {
                capture = new Capture(Path.GetFullPath(FilePath));
            }

            if (capture != null) //if camera capture has been successfully created
            {
                if (!imageGrabbedSet)
                {
                    imageGrabbedSet = true;
                    capture.ImageGrabbed += ProcessFrame;
                }
                capture.Start();
            }
        }

        public void PauseCapture()
        {
            capture.Pause();
        }

        public void StopCapture()
        {
            capture.Stop();
        }


        private void ProcessFrame(object sender, EventArgs e)
        {
            if (BeforeProcessFrame != null)
                BeforeProcessFrame();

            Mat curImage = new Mat();
            var imageGrabbed = capture.Retrieve(curImage);
            {
                if (!imageGrabbed)
                {
                    capture.Stop();
                    return;
                }
                if (counter == 0)
                {

                }

                Interlocked.Increment(ref counter);

                if (counter == 1)
                {
                }

                if (counter % FrameInterval != 0)
                {
                    if (counter % FrameInterval == 1)
                    {
                        prevImage = new Image<Bgr, byte>(curImage.Bitmap);
                    }
                    return;
                }

                //Process starts here

                var prevGray = prevImage.Convert<Gray, byte>();
                var curGray = curImage.ToImage<Gray, byte>();

                var denseResult = new DenseOpticalFlowAlgorithm(prevGray, curGray, Parameters)
                {
                    VectorNoiseThreshold = VectorGlobalThreshold,
                    WindowSideLength = WindowSideLength,
                    ComputeFlowImage = ComputeFlowImage
                }.Compute();

                if (OpticalFlowVectorsProcessed != null)
                {
                    OpticalFlowVectorsProcessed(denseResult.FlowVectorImage);
                }

                OpticalFlowPoint[] pointsToCluster = denseResult.FlowLineArray
                    .Where(x => x.OverThreshold)
                    .Select(x => new OpticalFlowPoint(
                        x.Line.P2,
                        x.Line.GetExteriorAngleDegree(DenseOpticalFlowAlgorithm.UnitVectorOfX)))
                    .ToArray();

                var clusters =
                    new DbscanAlgorithm<OpticalFlowPoint>(
                        (p, x) => p - x,
                        Math.Abs(OrientationAngle) <= 0 || Math.Abs(OrientationAngle) >= 360
                            ? (Func<OpticalFlowPoint, OpticalFlowPoint, bool>)null
                            : (point, x) => Math.Abs(point.ExteriorAngleDegree - x.ExteriorAngleDegree)  < OrientationAngle)
                        .ComputeClusterDbscan(pointsToCluster, Epsilon, MinPts);

                #region Draw vectors per frame

                var processedImage = new Image<Bgr, byte>(curImage.Bitmap);
                foreach (var line in denseResult.FlowLineArray.Where(x => x.OverThreshold).Select(x => x.Line).ToArray())
                {
                    processedImage.Draw(new CircleF(line.P2, 2), new Bgr(Color.Yellow));
                }

                #endregion

                //draw cluster rectangles
                foreach (var points in clusters)
                {
                    var polyLines = PointCollection.BoundingRectangle(points.Select(x => x.EndPoint).ToArray());
                    processedImage.Draw(polyLines, new Bgr(Color.Red), 2);
                }

                //draw convex hull
                foreach (var points in clusters)
                {
                    PointF[] hull = CvInvoke.ConvexHull(points.Select(x => x.EndPoint).ToArray());
                    processedImage.DrawPolyline(Array.ConvertAll(hull, Point.Round), true, new Bgr(Color.Blue));
                }

                ImageProcessed(processedImage);
            }

        }

        public void Dispose()
        {
            Dispose(true);
        }

        ~VideoProcessor()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                capture.Dispose();
                capture = null;
                prevImage.Dispose();
                prevImage = null;
            }
            ImageProcessed = null;
            OpticalFlowVectorsProcessed = null;
            BeforeProcessFrame = null;
        }
    }
}