using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.FileReaders;
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
        private JsonReaderFile _jsonReaderFile;
        public MyFirstFeatureFileSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            ObjectRepository.Customers = new Customers(ObjectRepository.Driver);
            _jsonReaderFile = new JsonReaderFile();
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
            var jsonObject = _jsonReaderFile.GetJsonObject();
            _scenarioContext["donorTypeData"] = jsonObject["donorType"].ToString();
            ObjectRepository.Partners.EnterDataIntoSearchFieldAndSearch(_scenarioContext["donorTypeData"].ToString());           
        }

        [Then(@"the search result text is correct")]
        public void ThenTheSearchResultTextIsCorrect()
        {            
            string expectedResult = "Row text contains '" + _scenarioContext["donorTypeData"] + "'";
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
