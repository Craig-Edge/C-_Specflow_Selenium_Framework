using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{


    public class TestSandboxWebsite : PageBaseClass
    {
        private IWebDriver _driver;

        public TestSandboxWebsite(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region
        private By _searchButton = By.Id("P1_SEARCH");
        private By _totalButton = By.XPath("//*[text()='Total']");
        #endregion

        #region interactions

        public void ClickSearchButton()
        {

            GenericHelper.IsElementPresent(_searchButton);
            InputManager.Click(_searchButton);
        
        }

        public void SearchCustomer(String abc)
        {
            GenericHelper.WaitforElementToBeDisplayed(_searchButton,20);
            Console.WriteLine("Wait for the page upload");
            InputManager.EnterData(_searchButton,abc);

            GenericHelper.WaitforElementToBeDisplayed(_searchButton,30);
        }

        public void ClickTotalButton()
        {
            InputManager.Click(_totalButton);

        }

        #endregion
    }
}

