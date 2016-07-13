using Emgu.CV;
using Emgu.CV.Structure;

namespace Detect.DenseOpticalFlow
{
    

    public class ComputedOpticalFlow
    {
        public Image<Bgr, byte> FlowVectorImage { get; set; }
        public FlowLineVector[] FlowLineArray { get; set; }

        public class FlowLineVector
        {
            public LineSegment2DF Line;
            public bool OverThreshold;
        }
    }
}