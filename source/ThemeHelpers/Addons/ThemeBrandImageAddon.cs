
using Contensive.Addons.ThemeHelpers.Controllers;
using Contensive.Models.Db;
using System.Text;

namespace Contensive.Addons.ThemeHelpers.Addons {
    /// <summary>
    /// Template Header Brand Image
    /// </summary>
    public class ThemeBrandImageAddon : BaseClasses.AddonBaseClass {
        // 
        // ====================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cp"></param>
        /// <returns></returns>
        public override object Execute(BaseClasses.CPBaseClass cp) {
            LibraryFilesModel image = DbBaseModel.create<LibraryFilesModel>(cp, constants.guidTemplateHeaderBrandLibraryFile);
            if (image == null) {
                image = DbBaseModel.addDefault<LibraryFilesModel>(cp);
                image.ccguid = constants.guidTemplateHeaderBrandLibraryFile;
                image.name = "Theme-Brand-Img";
                image.filename = GenericController.populateFileField(cp, @"memberboss\memberboss.png", LibraryFilesModel.tableMetadata.tableNameLower, "filename", image.id);
                image.save(cp);
            }
            StringBuilder result = new StringBuilder("<img");
            result.Append(" src=\"" + cp.Http.CdnFilePathPrefix + image.filename + "\"");
            if (!image.width.Equals(0)) { result.Append(" width=\"" + image.width + "\""); }
            if (!image.height.Equals(0)) { result.Append(" height=\"" + image.height + "\""); }
            if (!string.IsNullOrEmpty(image.description)) {
                string encodedMsg = cp.Utils.EncodeHTML(image.description);
                result.Append(" alt=\"" + encodedMsg + "\" title=\"" + encodedMsg + "\""); 
            }
            result.Append(">");
            //
            // -- if not editing, return a linked image
            if (!cp.User.IsEditingAnything) { return "<a href=\"/\">" + result.ToString() + "</a>"; }
            //
            // -- editing, no link
            return cp.Content.GetEditWrapper(result.ToString(), image.contentControlId, image.id);
        }
    }
}
