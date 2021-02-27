
using System;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// OnInstall addon for Theme Helpers collection
    /// </summary>
    public class OnInstallThemeHelpers : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// Addon entry
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            try {
                // 
                // -- 
                return string.Empty;
            } catch (Exception ex) {
                CP.Site.ErrorReport(ex);
                throw;
            }
        }
    }
}
