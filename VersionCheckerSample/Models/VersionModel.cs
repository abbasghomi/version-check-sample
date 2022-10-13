namespace VersionCheckerSample.Models
{
    public class VersionModel
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public int Build { get; set; }

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Patch}.{Build}";
        }

        public static bool operator ==(VersionModel left, VersionModel right)
        {
            return Sum(left) == Sum(right);
        }

        public static bool operator !=(VersionModel left, VersionModel right)
        {
            return Sum(left) != Sum(right);
        }

        public static bool operator >(VersionModel left, VersionModel right)
        {
            return Sum(left) > Sum(right);
        }

        public static bool operator <(VersionModel left, VersionModel right)
        {
            return Sum(left) < Sum(right);
        }

        public static bool operator >=(VersionModel left, VersionModel right)
        {
            return Sum(left) >= Sum(right);
        }

        public static bool operator <=(VersionModel left, VersionModel right)
        {
            return Sum(left) <= Sum(right);
        }

        private static int Sum(VersionModel model)
        {
            return (model.Major*1000000000)+
                   (model.Minor*1000000)+
                   (model.Patch*1000)+
                   (model.Build*1);
        }

    }
}
