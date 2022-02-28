using AmlEngineImportBug.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmlEngineImportBug.Tests {
    [TestClass]
    public class ImportInstanceHierarchyTests {
        [TestMethod]
        public void TestMethod1() {
            ImportInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod2() {
            ImportInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod3() {
            ImportInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod4() {
            ImportInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod5() {
            ImportInstanceHierarchy.DoStuff("file.aml");
        }
    }
}