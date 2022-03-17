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

namespace Nhsbt.LD.AutomationTests.DataDriven.Script
{
    [TestClass]
    public class TestCreateBug
    {
        [TestMethod]
        public void TestBug()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            var hpPage = new HomePagePageFactory(ObjectRepository.Driver);
            hpPage.ClickAcceptAllCookiesButton();
            var findyouraccountPage = hpPage.ClickForgotPasswordLink();
            var resetYourPasswordPageFactory = findyouraccountPage.SearchForAccount("099807867346");
            resetYourPasswordPageFactory.clickHeaderLoginButton();
        }
    }
}
