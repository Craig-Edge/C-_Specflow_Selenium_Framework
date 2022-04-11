using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.PageObjects.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScritps._2._StepDefinitions
{
    [Binding]
    public class MyFirstFeatureFileSteps
    {
        private static ScenarioContext _scenarioContext;

        public MyFirstFeatureFileSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            ObjectRepository.Customers = new Customers(ObjectRepository.Driver);
        }

        [Given(@"I navigate to the ""(.*)"" page")]
        public void GivenINavigateToThePage(string page)
        {
            string url = ObjectRepository.Config.GetEnvironmentBaseUrl();
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }
        
        [When(@"I click on the ""(.*)"" button")]
        public void WhenIClickOnTheButton(string button)
        {      
            Thread.Sleep(2000);
            ObjectRepository.Customers.ClickSpecificButton(button);
        }
        
        [When(@"I click on the ""(.*)"" button")]
        public void WhenIClickOnTheButton(string button, Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on the ""(.*)"" nav button")]
        public void WhenIClickOnTheNavButton(string navButton)
        {
            ObjectRepository.Customers.ClickNavButton(navButton);
        }

        [When(@"I enter data into the ""(.*)"" field")]
        public void WhenIEnterDataIntoTheField(string field)
        {
            ObjectRepository.Partners = new Partners(ObjectRepository.Driver);
            ObjectRepository.Partners.EnterDataIntoSearchFieldAndSearch("Some Data");
        }

        [Then(@"the search result text is correct")]
        public void ThenTheSearchResultTextIsCorrect()
        {
            string expectedResult = "Row text contains 'Some Data'";
            string actualResult = ObjectRepository.Partners.GetTextFromSearchField();
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Then(@"the type label will be displayed")]
        public void ThenTheTypeLabelWillBeDisplayed()
        {
            Thread.Sleep(2000);
            Assert.AreEqual("Type", ObjectRepository.Customers.GetTextFromLabel());
        }
    }
}
