
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// about in Footer
    /// </summary>
    public class TemplateFooterAboutClass : BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Template-Footer-About", "{D3D3806E-E714-4283-BD33-0BCD0C14E80A}", "memberboss\\Template-Footer-About.html");
        }
    }
}
