
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header Brand Name
    /// </summary>
    public class ThemeBrandNameAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Brand-Name", "{D085B986-98CB-4915-933B-83170BDFF9D7}", "themehelpers\\Theme-Brand-Name.html");
        }
    }
}
