
using Contensive.Addons.ThemeHelpers.Controllers;
using System;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template footer copyright
    /// </summary>
    public class ThemeContentCopyrightAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-Copyright", "{97E9AB77-438A-47E8-B372-1A491B255748}", "themehelpers\\Theme-Content-Copyright.html").Replace("{year}", DateTime.Now.Year.ToString());
        }
    }
}
