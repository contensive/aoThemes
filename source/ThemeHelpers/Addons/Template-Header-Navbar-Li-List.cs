
namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header, Bootstrap menu, li list
    /// </summary>
    public class TemplateHeaderNavbarLiListClass : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// Execute the menuing navbar-nav with the common memberboss instance id for the header menu
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            CP.Doc.SetProperty("instanceId", "Template-Header-Navbar-Li-List");
            return CP.Addon.Execute(constants.guidNavbarLiListAddon);
        }
    }
}
