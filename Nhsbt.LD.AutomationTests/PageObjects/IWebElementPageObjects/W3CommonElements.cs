using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects
{
    public class W3CommonElements
    {
        #region WebElements

        private readonly IWebElement _runButton = ObjectRepository.Driver.FindElement(By.Id("getwebsitebtn"));
        private readonly IWebElement _tutorialMenuDropDown = ObjectRepository.Driver.FindElement(By.Id("navbtn_tutorials"));
        private readonly IWebElement _learnHtmlLink = ObjectRepository.Driver.FindElement(By.XPath("//*[@class='w3-bar-item w3-button'][text()='Learn HTML']"));
        private readonly IWebElement _tryItYourselfButton = ObjectRepository.Driver.FindElement(By.XPath("//*[@class='w3-btn w3-margin-top w3-margin-bottom'][text()='Try it Yourself »']"));
        #endregion

        #region Element Getters

        public IWebElement GetTutorialMenuDropDown { get { return _tutorialMenuDropDown; } }
        public IWebElement GetLearnHtmlLink { get { return _learnHtmlLink; } }

        #endregion

        #region Interaction

        public void ClickRunButton()
        {
            InputManager.Click(_runButton);
        }

        public void clickTryItYourselfButton(int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.Click(_tryItYourselfButton, seconds, minutes, hours);
        }


        #endregion
    }
}
