using VersionCheckerSample.Data;
using VersionCheckerSample.Models;

namespace VersionCheckerSample.Extensions
{
    public static class VersionCheckExtension
    {
        //for demostration purpose added [VersionModel apiVersionModel] to this extension,
        //in real case it shouls be read from assembly on backend side
        public static bool IsCompatible(this VersionModel uiVersionModel, VersionModel apiVersionModel)
        {
            var versionRanges = MockedData.GetInstance().GetVersionRanges();

            var versionRangeByApi = versionRanges.Where(vr => vr.ApiMaxVersion >= apiVersionModel &&
                                                              vr.ApiMinVersion <= apiVersionModel).ToList();

            var versionRangeByUi = versionRanges.Where(vr => vr.UiMaxVersion >= uiVersionModel &&
                                                             vr.UiMinVersion <= uiVersionModel);

            var versionRange = versionRanges.FirstOrDefault(vr => vr.UiMaxVersion >= uiVersionModel &&
                                                                  vr.UiMinVersion <= uiVersionModel &&
                                                                  vr.ApiMaxVersion >= apiVersionModel &&
                                                                  vr.ApiMinVersion <= apiVersionModel);

            //if we wanted to consider the date as well, this if statement can be used
            //if(versionRange is null || versionRange.EndDate is not null) return false;

            if (versionRange is null) return false;

            return true;
        }
    }
}
