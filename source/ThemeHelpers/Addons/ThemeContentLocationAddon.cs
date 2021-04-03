
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header Location
    /// </summary>
    public class ThemeContentLocationAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-Location", "{407BBDE5-5542-4088-B904-8FE21F68B6D7}", "memberboss\\Theme-Content-Location.html");
        }
    }
}
