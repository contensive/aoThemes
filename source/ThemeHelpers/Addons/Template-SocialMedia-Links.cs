
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Footer, Social Media Links
    /// </summary>
    public class TemplateSocialMediaLinksClass : BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Template-SocialMedia-Links", "{88045A70-3E59-478A-A694-1D4AC0240728}", "memberboss\\Template-SocialMedia-Links.html");
        }
    }
}
