using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Sandbox
{
    public class Home : PageBaseClass
    {
        private IWebDriver _driver;

      public Home(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region Elements

        #endregion

        #region Interactions

        #endregion
    }
}
