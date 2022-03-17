using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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

        [FindsBy(How = How.XPath, Using = "//span[text()='Log in'")] IWebElement headerLogInButton;

        #endregion

        #region Interactions

        #endregion

        #region Navigation
        protected void ClickLoginButtonInHeader()
        {
            if (GenericHelper.IsElementPresent(By.XPath("//span[text()='Log In']")))
            {
                headerLogInButton.Click();
            }

            else
            {
                Console.WriteLine(GenericHelper.IsElementPresent(By.XPath("//span[text()='Log In']")));
            }
        }
        #endregion
    }
}
