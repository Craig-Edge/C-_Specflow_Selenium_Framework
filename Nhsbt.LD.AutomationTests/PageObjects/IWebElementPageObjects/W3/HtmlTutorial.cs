using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3
{
    public class HtmlTutorial : PageBaseClass
    {
        private IWebDriver driver;

        public HtmlTutorial(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        private readonly IWebElement _htmlFormsLink = ObjectRepository.Driver.FindElement(By.XPath("//*[@target='_top'][text()='HTML Forms']"));
        private readonly IWebElement _tryItYourselfButton = ObjectRepository.Driver.FindElement(By.XPath("//*[@class='w3-btn w3-margin-top w3-margin-bottom'][text()='Try it Yourself »']"));

        public HtmlFormsPracticePage ClickHtmlFormsLink( int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.ScrollToElementAndClick(_htmlFormsLink, seconds, minutes, hours);
            return new HtmlFormsPracticePage(ObjectRepository.Driver);
        }

        
    }
}
