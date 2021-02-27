
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header Location
    /// </summary>
    public class TemplateHeaderLocationClass : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Template-Header-Location", "{407BBDE5-5542-4088-B904-8FE21F68B6D7}", "memberboss\\Template-Header-Location.html");
        }
    }
}
