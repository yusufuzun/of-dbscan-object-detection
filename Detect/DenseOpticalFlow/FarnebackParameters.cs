namespace Detect.DenseOpticalFlow
{
    public class FarnebackParameters
    {
        public double PyrScale { get; set; }
        public int Levels { get; set; }
        public int Iterations { get; set; }
        public int PolyN { get; set; }
        public double PolySigma { get; set; }
        public int WinSize { get; set; }
    }
}