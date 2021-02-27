
namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header, Bootstrap menu, UL section
    /// </summary>
    public class TemplateHeaderNavbarULClass : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// Execute the menuing navbar-nav with the common memberboss instance id for the header menu
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            CP.Doc.SetProperty("instanceId", "Template-Header-Navbar-UL");
            return CP.Addon.Execute(constants.guidNavbarULAddon);
        }
    }
}
