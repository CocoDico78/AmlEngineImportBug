using AmlEngineImportBug.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmlEngineImportBug.Tests {
    [TestClass]
    public class InsertInstanceHierarchyTests {
        [TestMethod]
        public void TestMethod1() {
            InsertInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod2() {
            InsertInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod3() {
            InsertInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod4() {
            InsertInstanceHierarchy.DoStuff("file.aml");
        }

        [TestMethod]
        public void TestMethod5() {
            InsertInstanceHierarchy.DoStuff("file.aml");
        }
    }
}