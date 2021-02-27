
using Contensive.Addons.ThemeHelpers.Controllers;
using System;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template footer copyright
    /// </summary>
    public class TemplateFooterCopyrightClass : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Template-Footer-Copyright", "{97E9AB77-438A-47E8-B372-1A491B255748}", "memberboss\\Template-Footer-Copyright.html").Replace("{year}", DateTime.Now.Year.ToString());
        }
    }
}
