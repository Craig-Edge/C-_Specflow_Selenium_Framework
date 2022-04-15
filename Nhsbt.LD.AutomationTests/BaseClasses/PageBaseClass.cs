using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;

namespace Nhsbt.LD.AutomationTests.BaseClasses
{
    public class PageBaseClass
    {
        private IWebDriver _driver;

        // Change this to non-page factory implementation
        public PageBaseClass(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Elements 

        #endregion

        #region Interactions

        #endregion

        #region Navigation

        #endregion
    }
}
