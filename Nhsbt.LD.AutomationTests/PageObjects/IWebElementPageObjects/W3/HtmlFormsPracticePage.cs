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

    public class HtmlFormsPracticePage : PageBaseClass
    {
        private IWebDriver driver;

        public HtmlFormsPracticePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Elements

       

        private readonly By _resultFrame = By.XPath("//iframe[@id='iframeResult']");

        private readonly By _firstNameField = By.Id("fname");
        private readonly By _lastNameField = By.Id("lname");
        private readonly By _submitButton = By.XPath("//*[@value='Submit']");
        private readonly By _submittedFormDataHeading = By.XPath("//h1[text()='Submitted Form Data']");
        private readonly By _tryItYourselfButton = By.XPath("//*[text()='Try it Yourself »'][@class='w3-btn w3-margin-top w3-margin-bottom']");

        #endregion

        #region element Getters

        public By GetSubmittedFormDataHeading { get { return _submittedFormDataHeading; } }

        #endregion

        #region Interactions       

        public void EnterFirstName(string firstName, int seconds = 10, int minutes = 0, int hours = 0)
        {
            //ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(_resultFrame));
            InputManager.EnterData(_firstNameField, firstName, seconds, minutes, hours);           
        }

        public void EnterLastName(string lastName, int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.EnterData(_lastNameField, lastName, seconds, minutes, hours);
        }

        public void ClickSubmitButton(int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.Click(_submitButton, seconds, minutes, hours);
        }

        public void ClickTryItYourselfButton(int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.Click(_tryItYourselfButton, seconds, minutes, hours);
        }

        #endregion

        #region Navigation

        #endregion
    }
}
