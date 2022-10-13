using VersionCheckerSample.Models;

namespace VersionCheckerSample.Data
{
    public sealed class MockedData
    {
        private static MockedData Instance { get; set; }

        private MockedData()
        {

        }

        public static MockedData GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MockedData();
            }

            return Instance;
        }

        public List<VersionRangeModel> GetVersionRanges()
        {
            return new List<VersionRangeModel>
            {
                new VersionRangeModel
                {
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(-5),
                    ApiMinVersion = new VersionModel
                    {
                        Major = 1,
                        Minor = 0,
                        Patch = 0,
                        Build = 0,
                    },
                    ApiMaxVersion = new VersionModel
                    {
                        Major = 1,
                        Minor = 4,
                        Patch = 0,
                        Build = 0,
                    },
                    UiMinVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 0,
                        Patch = 1,
                        Build = 0,
                    },
                    UiMaxVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 9,
                        Patch = 9,
                        Build = 0,
                    }
                },
                new VersionRangeModel
                {
                    StartDate = DateTime.Now.AddDays(-5),
                    EndDate = DateTime.Now.AddDays(-1),
                    ApiMinVersion = new VersionModel
                    {
                        Major = 1,
                        Minor = 5,
                        Patch = 0,
                        Build = 0,
                    },
                    ApiMaxVersion = new VersionModel
                    {
                        Major = 1,
                        Minor = 8,
                        Patch = 0,
                        Build = 0,
                    },
                    UiMinVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 1,
                        Patch = 0,
                        Build = 0,
                    },
                    UiMaxVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 1,
                        Patch = 9,
                        Build = 0,
                    }
                },
                new VersionRangeModel
                {
                    StartDate = DateTime.Now,
                    EndDate = null,
                    ApiMinVersion = new VersionModel
                    {
                        Major = 1,
                        Minor = 9,
                        Patch = 0,
                        Build = 0,
                    },
                    ApiMaxVersion = new VersionModel
                    {
                        Major = 2,
                        Minor = 5,
                        Patch = 0,
                        Build = 0,
                    },
                    UiMinVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 2,
                        Patch = 0,
                        Build = 0,
                    },
                    UiMaxVersion = new VersionModel
                    {
                        Major = 0,
                        Minor = 2,
                        Patch = 5,
                        Build = 0,
                    }
                }

            };
        }
    }
}
