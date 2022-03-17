using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Facebook
{
    public class FindYourAccount : PageBaseClass
    {
        private IWebDriver driver;

        public FindYourAccount(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Elements

        private By emailAddressOrMobileNumberTextField = By.Name("email");
        private By searchButton = By.Name("did_submit");

        #endregion

        #region Interactions
    

        #endregion

        #region Navigation

        public ResetYourPassword SearchForAccount(string email)        
        {
            ObjectRepository.Driver.FindElement(emailAddressOrMobileNumberTextField).SendKeys(email);
            ObjectRepository.Driver.FindElement(searchButton).Click();
            return new ResetYourPassword(driver);
        }


        #endregion
    }
}
