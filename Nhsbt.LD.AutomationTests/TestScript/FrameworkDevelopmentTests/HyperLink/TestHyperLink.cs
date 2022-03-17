using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.FindElement(By.XPath("//button[@title='Allow Essential and Optional Cookies']")).Click();
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("Forgotten password?"));
            //element.Click();
            LinkHelper.ClickLink(By.LinkText("Forgotten password?"));
        }
    }
}
