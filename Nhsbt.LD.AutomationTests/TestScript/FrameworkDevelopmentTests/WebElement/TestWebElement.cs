using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            //PageManager.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //ObjectRepository.Driver.FindElement(By.XPath("//button[@title='Allow Essential and Optional Cookies']"));
        }
    }

    [TestClass]
    public class TestLogger
    {
        [TestMethod]
        public void LogTest()
        {
            ILog Logger = Log4NetHelper.GetLogger(typeof(TestLogger));

            Logger.Debug("This is Debug Information");
            Logger.Info("This is Info Inbformation");
            Logger.Warn("This is Warn Information");
            Logger.Error("This is Error Information");
            Logger.Fatal("This is Fatal Information");
        }

    }
}
