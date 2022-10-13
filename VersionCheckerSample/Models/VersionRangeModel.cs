namespace VersionCheckerSample.Models
{
    public class VersionRangeModel
    {
        public DateTime StartDate { get; set; } = DateTime.Now.Date;

        public DateTime? EndDate { get; set; }

        public VersionModel ApiMinVersion { get; set; }
        
        public VersionModel ApiMaxVersion { get; set; }

        public VersionModel UiMinVersion { get; set; }

        public VersionModel UiMaxVersion { get; set; }
    }
}
