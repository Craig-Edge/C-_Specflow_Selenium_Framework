using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.Settings;
using TechTalk.SpecFlow;
using System;

namespace Nhsbt.LD.AutomationTests.TestScript.GUI.FeatureFiles
{
    [Binding]
    public class ForgotPasswordFeatureSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public ForgotPasswordFeatureSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;                
        }

        [Given(@"I Navigate to the ""(.*)"" homepage")]
        public void GivenINavigateToTheHomepage(string website)
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            _scenarioContext["number1"] = 1;
        }
       
        [Given(@"I accept all recommended cookies")]
        public void GivenIAcceptAllRecommendedCookies()
        {
            ObjectRepository.homePagePageFactory = new HomePagePageFactory(ObjectRepository.Driver);
            ObjectRepository.homePagePageFactory.ClickAcceptAllCookiesButton();
            GenericHelper.TakeScreenShot();
        }

        [When(@"I click the ""(.*)"" link")]
        public void WhenIClickTheLink(string linktext)
        {
            ObjectRepository.findYourAccountPageFactory = ObjectRepository.homePagePageFactory.ClickForgotPasswordLink();
            Console.WriteLine("In ForgorPasswordFeatureSteps : " + _scenarioContext["number1"]);
        }
        
        [Then(@"I land on the ""(.*)""")]
        public void ThenILandOnThe(string page)
        {
            ObjectRepository.findYourAccountPageFactory.SearchForAccount(ObjectRepository.Config.GetUsername());            
        }

        [Then(@"I enter my username")]
        public void ThenIEnterMyUsername()
        {
            Console.WriteLine("Then I enter my username");
        }

        [Then(@"I enter my username poorly")]
        public void ThenIEnterMyUsernamePoorly()
        {
            Assert.IsTrue(false);
        }

    }
}
