using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.FileReaders;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{
    public class Partners : PageBaseClass
    {
        private IWebDriver _driver;

        public Partners(IWebDriver driver) : base (driver)
        {
            this._driver = driver;
        }

        #region Elements

        private By _searchField = By.Id("PRODUCTS_search_field");
        private By _searchResult = By.XPath("//span[@class='a-IRR-controlsLabel'][contains(text(), 'Row text contains')]");
        private By _goButton = By.Id("PRODUCTS_search_button");

        #endregion

        public DonorDataModel enterDataIntoSeachFieldFromJson()
        {
            JsonReaderFile fileReader = new JsonReaderFile();
            var jsonData = fileReader.ReadDonorDataJsonFile();            
            InputManager.EnterData(_searchField, jsonData.sn_Od);
            return jsonData;
        }

        public void enterDataIntoSeachFieldFromJson(string data)
        {           
            InputManager.EnterData(_searchField, data);           
        }

        public string GetTextFromSearchField()
        {
            InputManager.Click(_goButton);
            GenericHelper.WaitforElementToBeDisplayed(_searchResult);
            return ObjectRepository.Driver.FindElement(_searchResult).Text;
        }
    }
}
