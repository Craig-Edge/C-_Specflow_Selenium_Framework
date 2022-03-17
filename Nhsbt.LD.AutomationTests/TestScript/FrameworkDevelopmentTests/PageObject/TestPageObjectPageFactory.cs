using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.TestScript.PageObject
{
    [TestClass]
    public class TestPageObjectPageFactory
    {
     

        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\gord0019\Desktop\data.json", "data#json", DataAccessMethod.Sequential)]
        public void TestPageFactory()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePagePageFactory homePagePageFactory = new HomePagePageFactory(ObjectRepository.Driver);
            homePagePageFactory.ClickAcceptAllCookiesButton();
            FindYourAccountPageFactory findYourAccountPageFactory = homePagePageFactory.ClickForgotPasswordLink();
            ResetYourPasswordPageFactory resetYourPasswordPageFactory = findYourAccountPageFactory.SearchForAccount(TestContext.DataRow["phoneNumber"].ToString());
            resetYourPasswordPageFactory.clickHeaderLoginButton();

           
        }
    }
}
