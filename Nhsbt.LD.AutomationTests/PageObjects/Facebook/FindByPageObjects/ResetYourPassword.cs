using Nhsbt.LD.AutomationTests.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Facebook
{
    public class ResetYourPassword : PageBaseClass
    {
        private IWebDriver driver;

        public ResetYourPassword(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        private By sendCodeViaEmailRadioButton = By.Id("send_email");
        private By continueButton = By.XPath("//button[text()='Continue']");

        public void clickHeaderLoginButton()
        {
            base.ClickLoginButtonInHeader();
        }
    }
}
