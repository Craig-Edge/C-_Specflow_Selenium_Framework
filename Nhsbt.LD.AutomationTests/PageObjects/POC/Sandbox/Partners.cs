﻿using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.FileReaders;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nhsbt.LD.AutomationTests.FileReaders.JsonReaderFile;

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
            var jsonData = fileReader.ReadJsonFileReader();            
            InputManager.EnterData(_searchField, jsonData.DataEntered);
            return jsonData;
        }

        public string GetTextFromSearchField()
        {
            InputManager.Click(_goButton);
            GenericHelper.WaitforElementToBeDisplayed(_searchResult);
            return ObjectRepository.Driver.FindElement(_searchResult).Text;
        }
    }
}