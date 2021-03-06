﻿
using Contensive.Addons.ThemeHelpers.Controllers;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Footer hours of operation
    /// </summary>
    public class ThemeContentHoursAddon : Contensive.BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass CP) {
            return GenericController.getLayout(CP, "Theme-Content-Hours", "{51CC66CF-CD1C-42E7-93A6-7B66B6745068}", "themehelpers\\Theme-Content-Hours.html");
        }
    }
}
