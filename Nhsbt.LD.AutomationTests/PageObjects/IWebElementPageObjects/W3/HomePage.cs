using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects;
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
            InputManager.Click(ObjectRepository.w3CommonElements.GetTutorialMenuDropDown);
            InputManager.Click(ObjectRepository.w3CommonElements.GetLearnHtmlLink);
            return new HtmlTutorial(ObjectRepository.Driver);
        }
    }
}

