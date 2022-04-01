using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OpenQA.Selenium;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{
    public class CustomerDashboard : PageBaseClass
    {
        private IWebDriver _driver;

        public CustomerDashboard(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region Elements

        private By _customerSearchField;

        private By _moreFiltersExpansion = By.XPath("//button[@type='button'][text()='More Filters']");

        //private By _productDropdown = By.XPath("//select[@id='P1_PRODUCT']");
        private By _productDropdown = By.Id("P1_PRODUCT");
        private By _geographyDropdown = By.Id("P1_GEO");
        private By _publiclyReferenceableDropdown = By.Id("P1_REFERENCEABLE");
        private By _publiclyReferenceableDropdownOption = By.XPath("//select[@id='P1_REFERENCEABLE']/option");
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
            InputManager.ScrollToElementAndClick(_moreFiltersExpansion);
        }

        public void selectSpecificOptionFromDropdown(string dropdown = "product", string option = "- All -")
        {
            switch (dropdown)
            {
                case "product":
                    PageManager.ScrollToElement(_productDropdown);
                    InputManager.SelectDropdownOptionByText(_productDropdown, option);
                    break;
                case "geography":
                    PageManager.ScrollToElement(_geographyDropdown);
                    InputManager.SelectDropdownOptionByText(_geographyDropdown, option);
                    break;
                case "publicly referenceable":
                    PageManager.ScrollToElement(_publiclyReferenceableDropdown);
                    InputManager.SelectDropdownOptionByText(_publiclyReferenceableDropdown, option);
                    break;
                case "status":
                    PageManager.ScrollToElement(_statusDropdown);
                    InputManager.SelectDropdownOptionByText(_statusDropdown, option);
                    break;
                case "category":
                    PageManager.ScrollToElement(_categoryDropdown);
                    InputManager.SelectDropdownOptionByText(_categoryDropdown, option);
                    break;
                case "type":
                    PageManager.ScrollToElement(_typeDropdown);
                    InputManager.SelectDropdownOptionByText(_typeDropdown, option);
                    break;
                case "marquee customer":
                    PageManager.ScrollToElement(_marqueeCustomerDropdown);
                    InputManager.SelectDropdownOptionByText(_marqueeCustomerDropdown, option);
                    break;
                case "partner":
                    PageManager.ScrollToElement(_partnerDropdown);
                    InputManager.SelectDropdownOptionByText(_partnerDropdown, option);
                    break;
                case "competitor":
                    PageManager.ScrollToElement(_competitorDropdown);
                    InputManager.SelectDropdownOptionByText(_competitorDropdown, option);
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
