﻿
namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header, Bootstrap menu, li list
    /// </summary>
    public class ThemeHeaderLegacyNavbarLiListAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// Execute the menuing navbar-nav with the common themehelpers instance id for the header menu
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            CP.Doc.SetProperty("instanceId", "Theme-Header-Navbar-Li-List");
            return CP.Addon.Execute(constants.guidLegacyNavbarLiListAddon);
        }
    }
}
