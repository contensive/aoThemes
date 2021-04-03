
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Footer, Social Media Links
    /// </summary>
    public class ThemeContentSocialMediaLinksAddon : BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-SocialMediaLinks", "{88045A70-3E59-478A-A694-1D4AC0240728}", "memberboss\\Theme-Content-SocialMediaLinks.html");
        }
    }
}
