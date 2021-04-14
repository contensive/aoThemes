
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Footer hours of operation
    /// </summary>
    public class ThemeContentPhoneAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-Phone", "{F3CF29BC-9E94-4DFB-9B47-0866B635D570}", "themehelpers\\Theme-Content-Phone.html");
        }
    }
}
