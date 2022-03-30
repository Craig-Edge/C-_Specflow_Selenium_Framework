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
    /// <summary>
    /// Example Page Objects class, uses w3 schools
    /// </summary>
    public class HomePage : PageBaseClass
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region Elements

        #endregion

        #region Interactions

        #endregion

        #region Navigation

        public HtmlTutorial NavigateToHTMLFormsTutorialPracticePage()
        {
            GenericHelper.WaitforElementToBeDisplayed(base._tutorialMenuDropDown, 30);
            base.AcceptCookies();            
            InputManager.Click(ObjectRepository.Driver.FindElement(base._tutorialMenuDropDown));
            InputManager.Click(base._learnHtmlLink);
            return new HtmlTutorial(_driver);
        }

        #endregion  
    }
}

