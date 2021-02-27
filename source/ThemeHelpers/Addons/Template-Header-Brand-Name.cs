
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header Brand Name
    /// </summary>
    public class TemplateHeaderBrandNameClass : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Template-Header-Brand-Name", "{D085B986-98CB-4915-933B-83170BDFF9D7}", "memberboss\\Template-Header-Brand-Name.html");
        }
    }
}
