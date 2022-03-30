using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{
    public class CustomerDashboard : PageBaseClass
    {
        private IWebDriver driver;

        public CustomerDashboard(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Elements

        private By _customerSearchField;

        private By _moreFiltersExpansion = By.XPath("//button[@type='button'][text()='More Filters']");

        private By _productDropdown = By.XPath("//select[@id='P1_PRODUCT']");
        private By _productDropdownOption = By.XPath("//select[@id='P1_PRODUCT']/option");
        private By _geographyDropdown = By.Id("P1_GEO");
        private By _publiclyReferenceableDropdown = By.Id("P1_REFERENCEABLE");
        private By _statusDropdown = By.Id("P1_STATUS");
        private By _industryDropdown = By.Id("P1_INDUSTRY");
        private By _categoryDropdown = By.Id("P1_CATEGORY");
        private By _typeDropdown = By.Id("P1_TYPE");
        private By _marqueeCustomerDropdown = By.Id("P1_MARQUEE_CUST");
        private By _partnerDropdown = By.Id("P1_IMP_PARTNER");
        private By _competitorDropdown = By.Id("P1_COMPETITOR");

        #endregion

        #region Interactions

        public void expandMoreFiltersSection()
        {


        }

        public void selectSpecificOptionFromDropdown(string dropdown = "product", string option = "- All -")
        {
            string optionSelector = "[text()='" + option + "']";

            switch (dropdown)
            {
                case "product":
                    ObjectRepository.Driver.FindElement(By.XPath(_productDropdownOption + optionSelector));
                    break;
            }            
        }

        public void selectSpecificDropdown(string dropdown)
        {
            switch (dropdown)
            {
                case "product":
                    InputManager.ScrollToElementAndClick(_productDropdown);
                    break;
                case "geography":
                    InputManager.ScrollToElementAndClick(_geographyDropdown);
                    break;
                case "publicly referenceable":
                    InputManager.ScrollToElementAndClick(_publiclyReferenceableDropdown);
                    break;
                case "status":
                    InputManager.ScrollToElementAndClick(_statusDropdown);
                    break;
                case "category":
                    InputManager.ScrollToElementAndClick(_categoryDropdown);
                    break;
                case "type":
                    InputManager.ScrollToElementAndClick(_typeDropdown);
                    break;
                case "marquee customer":
                    InputManager.ScrollToElementAndClick(_marqueeCustomerDropdown);
                    break;
                case "partner":
                    InputManager.ScrollToElementAndClick(_partnerDropdown);
                    break;
                case "competitor":
                    InputManager.ScrollToElementAndClick(_competitorDropdown);
                    break;
            }
        }

        #endregion

        #region Navigation

        #endregion

    }
}
