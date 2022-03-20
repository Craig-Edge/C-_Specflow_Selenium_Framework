using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.BaseClasses
{
    public class PageBaseClass
    {
        private IWebDriver driver;


        // Change this to non-page factory implementation
        public PageBaseClass(IWebDriver _driver)
        {
            driver = _driver;
        }

        #region Common Page Elements
        
        protected readonly By _tutorialMenuDropDown = By.Id("navbtn_tutorials");
        protected readonly By _learnHtmlLink = By.XPath("//*[@class='w3-bar-item w3-button'][text()='Learn HTML']");
        protected readonly By _acceptAllCookies = By.Id("accept-choices");
               
        #endregion

        #region Interactions

        protected void AcceptCookies()
        {
            InputManager.Click(_acceptAllCookies);
        }

        #endregion

        #region Navigation

        #endregion
    }
}
