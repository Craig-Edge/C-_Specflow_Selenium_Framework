
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScript._1._POC.Sandbox._2._Step_Definitions
{
    [Binding]
    public class TestLaunch
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public TestLaunch(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the dashboard of the test environment")]
        public void NavigateURL()
        {
            ObjectRepository.TestSandboxWebsite = new TestSandboxWebsite(ObjectRepository.Driver);
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetSandboxURL());

        }

        [When(@"I click on Search button")]
        public void LocateSearchButton()
        {
            ObjectRepository.TestSandboxWebsite.ClickSearchButton();
        
        }


        //[Then(@"I enter data in Search box")]

        //public void SearchCustomers()
        //{
        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        //    ObjectRepository.TestSandboxWebsite.SearchCustomer("abc");
        //}


        [Then(@"I enter ""(.*)"" in Search box")]

        public void SearchCustomers(String value)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            InputManager.SearchCustomer();
            //ObjectRepository.TestSandboxWebsite.ClickTotalButton();
        }

        [Then(@"I enter data in Search box")]
        public void ThenIEnterDataInSearchBox()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            InputManager.SearchCustomer();
        }


        //[Then(@"I enter data from the ""(.*)""")]
        //public void ThenIEnterDataFromThe(string p0, Table table)
        //{
        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        //    InputManager.SearchCustomer(table);
        //}

        //[Then(@"I click on Total button")]
        //public void ClickTotalButton()
        //{
        //    ObjectRepository.TestSandboxWebsite.ClickTotalButton();

        //}

    }
}
