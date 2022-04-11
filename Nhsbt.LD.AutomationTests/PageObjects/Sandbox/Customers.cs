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
    public class Customers : PageBaseClass
    {
        private IWebDriver _driver;

        public Customers(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }


        #region Elements

        private By _sortByDropDown = By.Id("P59_SORT");
        private By _moreFiltersExpansion = By.XPath("//button[@type='button'][text()='More Filters']");
        private By _typeDropdownlabel = By.Id("P59_TYPE_LABEL");
       
        #endregion

        #region Interactions

        public void ClickTwoButtons()
        {
            InputManager.Click(_sortByDropDown, 15);
            InputManager.Click(_moreFiltersExpansion);
        }

        public void ClickSpecificButton(string button)
        {
            switch (button)
            {
                case "More Filters":
                    InputManager.Click(_moreFiltersExpansion);
                    break;
                case "Sort By":
                    InputManager.Click(_sortByDropDown, 15);
                    break;
            }
        }

        public string GetTextFromLabel()
        {
            string text = GenericHelper.GetElement(_typeDropdownlabel).Text;
            return text;
        }

        #endregion

        #region Navigation

        #endregion

    }
}
