using System;
using System.Xml.Linq;
using Lab8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string filePath = "C:\\Users\\Maxim\\source\\repos\\Lab8\\Lab8\\bin\\Debug\\data.xml";
        private XDocument getXmlFile()
        {
            return XDocument.Load(filePath);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(
                        1,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            true, false, false, false,
                            "Соколов", "", "", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(
                        1,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, true, false, false,
                            "", "462-04", "", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(
                        19,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, true, false,
                            "", "", "Нет", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(
                        12,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, false, true,
                            "", "", "", "Зачёт"
                        )
            );
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(
                        0,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, false, false,
                            "", "", "", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(
                        0,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            true, true, false, false,
                            "Бобров", "428-03", "", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(
                        1,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            true, true, false, false,
                            "Павлова", "333-05", "", ""
                        )
            );
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(
                        12,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, true, true,
                            "", "", "Нет", "Зачёт"
                        )
            );
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(
                        0,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, true, true,
                            "", "", "Да", "Зачёт"
                        )
            );
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(
                        6,
                        SearchRecordsForm.countRows(
                            getXmlFile(),
                            false, false, true, true,
                            "", "", "Да", "Экзамен"
                        )
            );
        }

    }
}
