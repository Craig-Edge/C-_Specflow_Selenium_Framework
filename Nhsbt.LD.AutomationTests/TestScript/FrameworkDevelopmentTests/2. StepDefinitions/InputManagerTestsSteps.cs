using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScript.FrameworkDevelopmentTests._2._StepDefinitions
{
    [Binding]
    public class InputManagerTestsSteps
    {
        [Given(@"I have navigated to the W3 schools hompage")]
        public void GivenIHaveNavigatedToTheWSchoolsHompage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetW3Schools());
        }
        
        [Given(@"I have navigated to the html forms practice page")]
        public void GivenIHaveNavigatedToTheHtmlFormsPracticePage()
        {
            ObjectRepository.homePage.NavigateToHTMLFormsTutorialPracticePage();
            ObjectRepository.htmlTutorial.ClickHtmlFormsLink();
            ObjectRepository.w3CommonElements.clickTryItYourselfButton();
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
        
        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string buttonName)
        {
            switch (buttonName)
            {
                case "Submit":
                    ObjectRepository.htmlFormsPracticePage.ClickSubmitButton();
                    break;
            }
            
        }
        
        [Then(@"The data will be successfully submitted")]
        public void ThenTheDataWillBeSuccessfullySubmitted()
        {
            Assert.AreEqual("Submitted Form Data", ObjectRepository.htmlFormsPracticePage.GetSubmittedFormDataHeading.Text);
        }
    }
}
