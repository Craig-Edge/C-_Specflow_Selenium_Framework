using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects
{
    public class HomePage : PageBaseClass
    {
        private IWebDriver driver;

        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Elements
        private By acceptAllCookiesButton = By.XPath("//button[@title='Allow Essential and Optional Cookies']");
        private By forgotPasswordLink = By.LinkText("Forgotten password?");

        #endregion

        #region Interactions
        public void ClickAcceptAllCookiesButton()
        {
            ObjectRepository.Driver.FindElement(acceptAllCookiesButton).Click();
       
        }

        #endregion

        #region Navigation
        public FindYourAccount ClickForgotPasswordLink()
        {          
            ObjectRepository.Driver.FindElement(forgotPasswordLink).Click();
            return new FindYourAccount(driver);
        }

        #endregion
    }
}
