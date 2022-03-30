using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;

using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3
{
    /// <summary>
    /// Example Page Objects class, uses w3 schools
    /// </summary>
    public class HtmlTutorial : PageBaseClass
    {
        private IWebDriver _driver;

        public HtmlTutorial(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region Elements

        private readonly By _htmlFormsLink = By.XPath("//*[@target='_top'][text()='HTML Forms']");
        private readonly By _tryItYourselfButton = By.XPath("//*[@class='w3-btn w3-margin-top w3-margin-bottom'][text()='Try it Yourself »']");

        #endregion

        #region Interactions

        #endregion

        #region Navigation
        public HtmlFormsPracticePage ClickHtmlFormsLink(int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.ScrollToElementAndClick(_htmlFormsLink, seconds, minutes, hours);
            return new HtmlFormsPracticePage(_driver);
        }

        #endregion
    }
}
