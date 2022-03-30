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
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetDeveloperSandbox());
            _scenarioContext["key"] = "keyValue";
        }

        [Given(@"I expand the More Filters section")]
        public void GivenIExpandTheMoreFiltersSection()
        {
            
        }


        [When(@"I click the ""(.*)"" dropdown")]
        public void WhenIClickTheDropdown(string dropdown, Table table)
        {
            ObjectRepository.customerDashboard = new CustomerDashboard(ObjectRepository.Driver);

            string key = _scenarioContext["key"].ToString();
            foreach(var row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                    ObjectRepository.customerDashboard.selectSpecificDropdown(value);
                }
            }
        }


    }
}
