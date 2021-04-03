
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Contact content in template footer
    /// </summary>
    public class ThemeContentContactAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-Contact", "{6053D0D5-B245-4EE1-8A6A-A92B485C6B1F}", "memberboss\\Theme-Content-Contact.html");
        }
    }
}
