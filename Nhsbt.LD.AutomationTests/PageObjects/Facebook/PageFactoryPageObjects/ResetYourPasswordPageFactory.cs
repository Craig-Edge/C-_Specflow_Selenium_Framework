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
    public class ResetYourPasswordPageFactory : PageBaseClassPageFactory
    {
        private IWebDriver driver;

        public ResetYourPasswordPageFactory(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }       

        #region Elements

        [FindsBy(How = How.Id, Using = "send_email")] private IWebElement sendCodeViaEmailRadioButton;
        [FindsBy(How = How.XPath, Using = "//button[text()='Continue']")] private IWebElement continueButton;

        #endregion

        #region Interactions

        public void clickHeaderLoginButton()
        {
            base.ClickLoginButtonInHeader();
        }

        #endregion

        #region Navigation

        #endregion

    }
}
