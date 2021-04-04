
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// about in Footer
    /// </summary>
    public class ThemeContentAboutAddon : BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-About", "{D3D3806E-E714-4283-BD33-0BCD0C14E80A}", "themehelpers\\Theme-Content-About.html");
        }
    }
}
