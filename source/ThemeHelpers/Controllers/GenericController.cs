
using Contensive.BaseClasses;
using Contensive.Models.Db;
using System;

namespace Contensive.Addons.ThemeHelpers.Controllers {
    /// <summary>
    /// Generic methods
    /// </summary>
    public class GenericController {
        // 
        // ====================================================================================================
        // 
        public static string getLayout(BaseClasses.CPBaseClass CP, string layoutName, string layoutGuid, string layoutFilename) {
            try {
                // 
                // -- install default detail layout
                LayoutModel layout = DbBaseModel.create<LayoutModel>(CP, layoutGuid);
                if ((layout == null)) {
                    //
                    // -- no layout found, create it
                    layout = DbBaseModel.addDefault<LayoutModel>(CP);
                    layout.name = layoutName;
                    layout.ccguid = layoutGuid;
                    layout.save(CP);
                }
                if (string.IsNullOrEmpty(layout.layout.content)) {
                    //
                    // -- content is blank, populate with layoutfilename
                    BaseClasses.CPBlockBaseClass block = CP.BlockNew();
                    block.Load(CP.CdnFiles.Read(layoutFilename));
                    layout.layout.content = block.GetInner("body");
                    if (string.IsNullOrEmpty(layout.layout.content)) { layout.layout.content = block.GetHtml(); }
                    layout.save(CP);
                }
                //
                // --  exit if not editing
                if (!CP.User.IsEditingAnything) { return layout.layout.content; }
                //
                // -- wrap with edit
                return CP.Content.GetEditWrapper(layout.layout.content, layout.contentControlId, layout.id);
            } catch (Exception ex) {
                CP.Site.ErrorReport(ex);
                throw;
            }
        }
        // 
        // ====================================================================================================
        // 
        public static string populateFileField(CPBaseClass cp, string srcCdnPathFilename, string tablename, string fieldName, int recordId) {
            string dstFilename = System.IO.Path.GetFileName(srcCdnPathFilename);
            string dstCdnPathFilename = GenericController.convertToDosPath(cp.Db.CreateUploadFieldPathFilename(tablename, fieldName, recordId, dstFilename));
            if (cp.CdnFiles.FileExists(srcCdnPathFilename)) {
                cp.CdnFiles.Copy(srcCdnPathFilename, dstCdnPathFilename);
                return Controllers.GenericController.convertToUnixPath(dstCdnPathFilename);
            }
            return "";
        }
        // 
        // ====================================================================================================
        // 
        public static string convertToUnixPath(string src) {
            return src.Replace("\\", "/");
        }
        // 
        // ====================================================================================================
        // 
        public static string convertToDosPath(string src) {
            return src.Replace("/", "\\");
        }
    }
}
