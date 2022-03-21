using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScript.FrameworkDevelopmentTests._2._StepDefinitions
{
    
    [Binding]
    public class InputManagerTestsSteps
    {
        //public InputManagerTestsSteps()
        //{
        //    ScenarioContext scenarioContext;
        //}

        [Given(@"I have navigated to the W3 schools hompage")]
        public void GivenIHaveNavigatedToTheWSchoolsHompage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetW3Schools());
        }

        //[Given(@"I have accepted all cookies")]
        //public void GivenIHaveAcceptedAllCookies()
        //{
        //    ObjectRepository.homePage = new HomePage(ObjectRepository.Driver);
        //    ObjectRepository.homePage.
        //}


        [Given(@"I have navigated to the html forms practice page")]
        public void GivenIHaveNavigatedToTheHtmlFormsPracticePage()
        {
            ObjectRepository.homePage = new HomePage(ObjectRepository.Driver);
            ObjectRepository.htmlTutorial = ObjectRepository.homePage.NavigateToHTMLFormsTutorialPracticePage();
            ObjectRepository.htmlFormsPracticePage = ObjectRepository.htmlTutorial.ClickHtmlFormsLink();
            GenericHelper.TakeScreenShot();
        }
        
        [When(@"I enter ""(.*)"" into the ""(.*)"" Field")]
        public void WhenIEnterIntoTheField(string name, string fieldName)
        {            
            switch (fieldName)
            {
                case "First Name":
                    ObjectRepository.htmlFormsPracticePage.EnterFirstName(name);
                    break;
                case "Last Name":
                    ObjectRepository.htmlFormsPracticePage.EnterLastName(name);
                    break;
            }
            
        }

        [Given(@"I click the ""(.*)"" button")]
        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string buttonName)
        {
            switch (buttonName)
            {
                case "Submit":
                    ObjectRepository.htmlFormsPracticePage.ClickSubmitButton();
                    break;
                case "Try it yourself":
                    ObjectRepository.htmlFormsPracticePage.ClickTryItYourselfButton();
                    break;
            }            
        }
        
        [Then(@"The data will be successfully submitted")]
        public void ThenTheDataWillBeSuccessfullySubmitted()
        {   
            //By expectedResultXpath = ObjectRepository.htmlFormsPracticePage.GetSubmittedFormDataHeading;
            //Assert.AreEqual("Submitted Form Data", ObjectRepository.Driver.FindElement(expectedResultXpath).Text);
        }
    }
}
