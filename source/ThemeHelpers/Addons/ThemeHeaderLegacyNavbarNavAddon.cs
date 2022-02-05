
namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header, Bootstrap menu, Navsection
    /// </summary>
    public class ThemeHeaderLegacyNavbarNavAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// Execute the menuing navbar-nav with the common themehelpers instance id for the header menu
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            CP.Doc.SetProperty("instanceId", "Theme-Header-Navbar-Nav");
            return CP.Addon.Execute(constants.guidLegacyNavbarNavAddon);
        }
    }
}
