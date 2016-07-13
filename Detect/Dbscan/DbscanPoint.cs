namespace Detect.Dbscan
{
    public class DbscanPoint<T>
    {
        public bool IsVisited;
        public readonly T ClusterPoint;
        public int ClusterId;

        public DbscanPoint(T x)
        {
            ClusterPoint = x;
            IsVisited = false;
            ClusterId = (int)ClusterIds.Unclassified;
        }

    }
}