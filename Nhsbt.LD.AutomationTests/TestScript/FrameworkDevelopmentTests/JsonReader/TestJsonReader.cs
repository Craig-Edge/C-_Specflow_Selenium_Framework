using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.FileReaders;
using Nhsbt.LD.AutomationTests.PageObjects;

using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.TestScript.JsonReader
{
    [TestClass]
    public class TestJsonReader
    {
        [TestMethod]
        public void TestJsonReaderFile()
        {
            JsonReaderFile jsonReaderFile = new JsonReaderFile();
            jsonReaderFile.ReadJsonFileReader("AdultDonor.json");
        }
    }
}
