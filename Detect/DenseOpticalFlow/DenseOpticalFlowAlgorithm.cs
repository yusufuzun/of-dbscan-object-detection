using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Detect.DenseOpticalFlow
{
    public class DenseOpticalFlowAlgorithm
    {
        public static readonly LineSegment2DF UnitVectorOfX = new LineSegment2DF(new PointF(0, 0), new PointF(1, 0));

        private readonly Image<Gray, byte> previousImage;

        private readonly Image<Gray, byte> currentImage;

        private readonly FarnebackParameters farnebackParameters;

        private int windowSideLength;

        private Image<Gray, float> velocityX;

        private Image<Gray, float> velocityY;

        public int WindowSideLength
        {
            get { return windowSideLength; }
            set
            {
                WindowSize = new Size(value, value);
                windowSideLength = value;
            }
        }

        public Size WindowSize { get; private set; }

        public bool ComputeFlowImage { get; set; }

        public double? VectorNoiseThreshold { get; set; }

        public DenseOpticalFlowAlgorithm(Image<Gray, byte> previousImage,
            Image<Gray, byte> currentImage,
            FarnebackParameters farnebackParameters)
        {
            this.previousImage = previousImage;
            this.currentImage = currentImage;
            this.farnebackParameters = farnebackParameters;
        }

        public ComputedOpticalFlow Compute()
        {
            var flowVectorImage = new Image<Bgr, byte>(currentImage.Bitmap);

            var currentGray = currentImage.Convert<Gray, byte>();
            var previousGray = previousImage.Convert<Gray, byte>();

            velocityX = new Image<Gray, float>(previousImage.Size);
            velocityY = new Image<Gray, float>(previousImage.Size);

            CvInvoke.CalcOpticalFlowFarneback(
                prev0: previousGray, next0: currentGray, flowX: velocityX, flowY: velocityY,
                pyrScale: farnebackParameters.PyrScale, levels: farnebackParameters.Levels,
                winSize: farnebackParameters.WinSize, iterations: farnebackParameters.Iterations,
                polyN: farnebackParameters.PolyN, polySigma: farnebackParameters.PolySigma,
                flags: OpticalflowFarnebackFlag.FarnebackGaussian);

            var vectorFieldX = (int)Math.Round((double)currentGray.Width / WindowSize.Width);
            var vectorFieldY = (int)Math.Round((double)currentGray.Height / WindowSize.Height);

            var opticalFlowLineArray = new ComputedOpticalFlow.FlowLineVector[vectorFieldX * vectorFieldY];

            for (int dirX = 0; dirX < vectorFieldX; dirX++)
            {
                for (int dirY = 0; dirY < vectorFieldY; dirY++)
                {
                    LineSegment2DF flowVector = CalculateFlowVector(dirX, dirY);

                    AddToFlowLineArray(opticalFlowLineArray, vectorFieldX, dirX, dirY, flowVector);

                    if (ComputeFlowImage)
                    {
                        AddToFlowVectorImage(flowVectorImage, flowVector);
                    }
                }
            }

            return new ComputedOpticalFlow { FlowVectorImage = flowVectorImage, FlowLineArray = opticalFlowLineArray };
        }

        private void AddToFlowVectorImage(Image<Bgr, byte> flowVectorImage, LineSegment2DF flowVector)
        {
            var bgr = new HsvToBgrConverter(flowVector.GetExteriorAngleDegree(UnitVectorOfX), 1, 1).Convert();

            flowVectorImage.Draw(flowVector, bgr, 1);
        }

        private void AddToFlowLineArray(ComputedOpticalFlow.FlowLineVector[] opticalFlowLineArray, int vectorFieldX, int width, int height, LineSegment2DF flowVector)
        {
            opticalFlowLineArray[vectorFieldX * height + width] = new ComputedOpticalFlow.FlowLineVector
            {
                Line = flowVector,
                OverThreshold = !VectorNoiseThreshold.HasValue || flowVector.Length > VectorNoiseThreshold.Value
            };
        }

        private LineSegment2DF CalculateFlowVector(int dirX, int dirY)
        {
            var velxFloat = (float)velocityX[dirY * WindowSize.Height, dirX * WindowSize.Width].Intensity;
            var velyFloat = (float)velocityY[dirY * WindowSize.Height, dirX * WindowSize.Width].Intensity;

            LineSegment2DF flowVector = new LineSegment2DF(
                new PointF(dirX * WindowSize.Width, dirY * WindowSize.Height), //line start
                new PointF(dirX * WindowSize.Width + velxFloat, dirY * WindowSize.Height + velyFloat) //line end
                );
            return flowVector;
        }
    }
}