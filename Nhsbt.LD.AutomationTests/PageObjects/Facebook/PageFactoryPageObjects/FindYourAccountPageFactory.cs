using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Facebook
{
    public class FindYourAccountPageFactory : PageBaseClassPageFactory
    {
        private IWebDriver driver;

        #region Elements

        public FindYourAccountPageFactory(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        [FindsBy(How = How.Name, Using = "email")] private IWebElement emailAddressOrMobileNumberTextField;
        [FindsBy(How = How.Name, Using = "did_submit")] private IWebElement searchButton;

        #endregion

        #region Interactions
    

        #endregion

        #region Navigation

        public ResetYourPasswordPageFactory SearchForAccount(string email)        
        {
            emailAddressOrMobileNumberTextField.SendKeys(email);
            searchButton.Click();
            return new ResetYourPasswordPageFactory(driver);
        }


        #endregion
    }
}
