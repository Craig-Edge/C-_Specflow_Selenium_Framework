using Nhsbt.LD.AutomationTests.ComponentHelpers;
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
      
        #endregion

        #region Interactions

        #endregion

        #region Navigation
   
        #endregion
    }
}
