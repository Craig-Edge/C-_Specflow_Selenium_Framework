using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.FileReaders;
using Nhsbt.LD.AutomationTests.FileReaders.ExcelReader;
using Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScript._1._POC.Sandbox._2._Step_Definitions
{
    [Binding]
    public class SandboxPOC1Steps
    {
        private static ScenarioContext _scenarioContext;

        public SandboxPOC1Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I navigate to the dashoard of the Sandbox environment")]
        public void GivenINavigateToTheDashoardOfTheSandboxEnvironment()
        {
            ObjectRepository.customerDashboard = new CustomerDashboard(ObjectRepository.Driver);
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetDeveloperSandbox());            
        }

        [Given(@"I expand the More Filters section")]
        public void GivenIExpandTheMoreFiltersSection()
        {            
            ObjectRepository.customerDashboard.expandMoreFiltersSection();
        }


        [When(@"I click the ""(.*)"" dropdown")]
        public void WhenIClickTheDropdown(string dropdown, Table table)
        {            
            foreach(var row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                    ObjectRepository.customerDashboard.selectSpecificDropdown(value);
                }
            }
        }

        [When(@"I select each option from the ""(.*)"" dropdown")]
        public void WhenISelectEachOptionFromTheDropdown(string dropdown, Table table)
        {
            foreach (var row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                    ObjectRepository.customerDashboard.selectSpecificOptionFromDropdown(dropdown, value);
                }
            }
        }

        [When(@"I click the ""(.*)"" nav button")]
        public void WhenIClickTheNavButton(string navButton)
        {
            ObjectRepository.customerDashboard.clickSpecificNavButton(navButton);            
        }

        [When(@"I enter the data from a Json file")]
        public void WhenIEnterTheDataFromAJsonFile()
        {
            JsonReaderFile j = new JsonReaderFile();
            ObjectRepository.partners = new Partners(ObjectRepository.Driver);
            //var jsonData = ObjectRepository.partners.enterDataIntoSeachFieldFromJson();          
            //_scenarioContext["DataEntered"] = jsonData.Username1;
            var jsonObject = j.GetJsonObject();                 
            _scenarioContext["sn_Od"] = jsonObject["sn_Od"].ToString();
            ObjectRepository.partners.enterDataIntoSeachField(_scenarioContext["sn_Od"].ToString());

            foreach(var row in jsonObject)
            {
                Console.WriteLine(row.Value);
            }
        }

        [When(@"I load excel data into the scenario context dictionary")]
        public void WhenILoadExcelDataIntoTheScenarioContextDictionary()
        {
            // Loads the excel data into the scenario context dictionary, assumes that the data is in key vale format
            // Must pass the _scenarioContext reference as the second parameter
            ExcelFileReader.LoadExcelDataIntoScenarioContextDictionary("AdultDonor", _scenarioContext);

            // TODO - I can't really do much else until I see how the data is fomatted CG 09/04/2022
            // Loads the excel data into the a dictionary, assumes that the data is in key value format
            var data = ExcelFileReader.LoadExcelDataIntoDictionary("AdultDonor");
        }


        [When(@"I enter the data from a excel file")]
        public void WhenIEnterTheDataFromAExcelFile()
        {            
            ObjectRepository.partners = new Partners(ObjectRepository.Driver);        
            ObjectRepository.partners.enterDataIntoSeachField(_scenarioContext["donorType"].ToString());        
        }

        [Then(@"the data entered is present in the field")]
        public void ThenTheDataEnteredIsPresentInTheField()
        {            
            Assert.AreEqual("Row text contains '" + _scenarioContext["donorType"] + "'", ObjectRepository.partners.GetTextFromSearchField());
        }
    }
}
