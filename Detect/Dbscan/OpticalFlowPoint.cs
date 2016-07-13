using System.Drawing;

namespace Detect.Dbscan
{
    public class OpticalFlowPoint : DatasetItemBase
    {
        public readonly PointF EndPoint;
        public readonly double ExteriorAngleDegree;


        public OpticalFlowPoint(PointF endPoint, double exteriorAngleDegree)
        {
            EndPoint = endPoint;
            ExteriorAngleDegree = exteriorAngleDegree;
        }

        public static double operator -(OpticalFlowPoint p, OpticalFlowPoint x)
        {
            return (p.EndPoint.X - x.EndPoint.X) * (p.EndPoint.X - x.EndPoint.X) 
                + (p.EndPoint.Y - x.EndPoint.Y) * (p.EndPoint.Y - x.EndPoint.Y);
        }
    }
}