using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects;

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
            // TODO - put this into a feature file as an example of frame switching
            // Initialises the WebDriver
            InitWebDriver();

            // Navigate to the URL
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_button_disabled");

            // Accepts cookies
            ObjectRepository.Driver.FindElement(By.Id("accept-choices")).Click();

            // Switches to the iframe which contains the element using this helper class
            PageManager.SwitchToFrame(By.Id("iframeResult"));
            
            // Check if the element is present and write to console
            Console.WriteLine(GenericHelper.IsElementPresent(By.XPath("//button[text()='Click Me!']")));

            // Clicks the element
            InputManager.Click(By.XPath("//button[text()='Click Me!']"));

            // Switches back to full scope of the DOM - This is important as if this step is not performed the WebDriver will only be able
            // To find elements within the scope of the current iframe
            PageManager.SwitchToDefaultContent();

            // New page object class refernce object
            //W3CommonElements w3 = new W3CommonElements(ObjectRepository.Driver);
            // Click the run button
            //w3.ClickRunButton();

            // Ends browser session and stops all open WebDriver instances created in this session
            TearDown();
        }

        [TestMethod]
        public void TestButton()
        {
            InitWebDriver();
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_button_disabled");
            ObjectRepository.Driver.FindElement(By.Id("accept-choices")).Click();
            Console.WriteLine(GenericHelper.IsElementPresent(By.Id("getwebsitebtn")));
            //W3CommonElements w3 = new W3CommonElements(ObjectRepository.Driver);
            //w3.ClickRunButton();
            TearDown();
        }
    }
}
