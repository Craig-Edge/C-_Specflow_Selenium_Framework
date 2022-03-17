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

namespace Nhsbt.LD.AutomationTests.TestScript
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void TestPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            homePage.ClickAcceptAllCookiesButton();
            FindYourAccount findYourAccount = homePage.ClickForgotPasswordLink();
            ResetYourPassword resetYourPassword =  findYourAccount.SearchForAccount("07810091173");
            resetYourPassword.clickHeaderLoginButton();
        }
    }
}
