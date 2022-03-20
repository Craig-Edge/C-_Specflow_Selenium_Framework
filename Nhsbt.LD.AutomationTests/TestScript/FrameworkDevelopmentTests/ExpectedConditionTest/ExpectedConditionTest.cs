using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.TestScript.FrameworkDevelopmentTests.ExpectedConditionTest
{
    [TestClass]
    public class ExpectedConditionTest : BaseClass
    {
        [TestMethod]
        public void TestDisabledButton()
        {
            InitWebDriver();
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_button_disabled");
            ObjectRepository.Driver.FindElement(By.Id("accept-choices")).Click();
            ExperimentalClick.SwitchToFrame(By.Id("iframeResult"));
            Console.WriteLine(GenericHelper.IsElementPresent(By.XPath("//button[text()='Click Me!']")));
            ExperimentalClick.ClickByElementConstraint(By.XPath("//button[text()='Click Me!']"));
            W3 w3 = new W3();
            w3.ClickRunButton();

        }

        [TestMethod]
        public void TestButton()
        {
            InitWebDriver();
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_button_disabled");
            ObjectRepository.Driver.FindElement(By.Id("accept-choices")).Click();
            Console.WriteLine(GenericHelper.IsElementPresent(By.Id("getwebsitebtn")));
            //bool isEnabled = ExperimentalClick.Click(By.Id("getwebsitebtn"));
            W3 w3 = new W3();
            w3.ClickRunButton();
        }
    }
}
