using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;

using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3
{
    public class HomePage : PageBaseClass
    {
        private IWebDriver driver;

        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        public HtmlTutorial NavigateToHTMLFormsTutorialPracticePage()
        {
            base.AcceptCookies();
            InputManager.Click(ObjectRepository.Driver.FindElement(base._tutorialMenuDropDown));
            InputManager.Click(base._learnHtmlLink);
            return new HtmlTutorial(driver);
        }
    }
}

