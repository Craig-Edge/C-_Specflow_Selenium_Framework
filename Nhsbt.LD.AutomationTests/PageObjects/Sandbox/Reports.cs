using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Sandbox
{
    public class Reports : PageBaseClass
    {
        private IWebDriver _driver;

      public Reports(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region Elements

        private By _searchField = By.Id("PRODUCTS_search_field");
        private By _goButton = By.Id("PRODUCTS_search_button");
        private By _searchResult = By.XPath("//span[@class='a-IRR-controlsLabel'][contains(text(), 'Row text contains')]");

        #endregion

        #region Interactions
        public void EnterDataIntoSearchFieldAndSearch(string data)
        {
            InputManager.EnterData(_searchField, data);
            InputManager.Click(_goButton);
        }

        public string GetTextFromSearchField()
        {
            GenericHelper.WaitforElementToBeDisplayed(_searchResult);
            string text = GenericHelper.GetElement(_searchResult).Text;
            return text;
        }

        #endregion
    }
}
