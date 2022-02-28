using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

namespace AmlEngineImportBug.Library {
    public static class ImportInstanceHierarchy {
        public static void DoStuff(string amlPath) {
            CAEXDocument originalDocument = CAEXDocument.LoadFromFile(amlPath);
            var ie = originalDocument.CAEXFile.InstanceHierarchy;
            var document = CAEXDocument.LoadFromFile("IEC63131AmlLibrary0.0.9.aml");
            foreach (var item in ie) {
                document.CAEXFile.Import_InstanceHierarchy(item);
            }
        }
    }
}