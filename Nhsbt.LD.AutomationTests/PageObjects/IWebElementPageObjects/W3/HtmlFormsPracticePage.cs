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
    public class HtmlFormsPracticePage : PageBaseClass
    {
        private IWebDriver driver;

        public HtmlFormsPracticePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        private readonly string _resultFrameName = "iframeResult";
        private readonly IWebElement _firstNameField = ObjectRepository.Driver.FindElement(By.Id("fname"));
        private readonly IWebElement _lastNameField = ObjectRepository.Driver.FindElement(By.Id("lname"));
        private readonly IWebElement _submitButton = ObjectRepository.Driver.FindElement(By.XPath("//*[@value='Submit']"));
        private readonly IWebElement _submittedFormDataHeading = ObjectRepository.Driver.FindElement(By.XPath("//*[text()='Submitted Form Data']"));

        public IWebElement GetSubmittedFormDataHeading { get { return _submittedFormDataHeading; } }

        public void EnterFirstName(string firstName, int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.EnterData(_firstNameField, firstName, seconds, minutes, hours);
           
        }

        public void EnterLastName(string lastName, int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.EnterData(_lastNameField, lastName, seconds, minutes, hours);
            InputManager.Click(_submitButton, seconds, minutes, hours);
        }

        public void ClickSubmitButton(int seconds = 10, int minutes = 0, int hours = 0)
        {
            InputManager.Click(_submitButton, seconds, minutes, hours);
        }

    }
}
