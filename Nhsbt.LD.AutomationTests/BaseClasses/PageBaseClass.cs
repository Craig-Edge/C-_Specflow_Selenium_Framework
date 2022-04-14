using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;

namespace Nhsbt.LD.AutomationTests.BaseClasses
{
    public class PageBaseClass
    {
        private IWebDriver _driver;

        // Change this to non-page factory implementation
        public PageBaseClass(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Elements 

        private By _activitesNavButton = By.Id("t_TreeNav_5");
        private By _administrationNavButton = By.Id("t_TreeNav_7");
        private By _contactsNavButton = By.Id("t_TreeNav_4");
        private By _dashboardNavButton = By.Id("t_TreeNav_1");
        private By _homeNavButton = By.Id("t_TreeNav_0");
        private By _partnerNavButton = By.Id("t_TreeNav_3");
        private By _productsAndServicesButton = By.Id("t_TreeNav_2");
        private By _reportsNavButton = By.Id("t_TreeNav_6");

        #endregion

        #region Interactions

        #endregion

        #region Navigation

        public void ClickNavButton(string navButton)
        {
            switch (navButton)
            {
                case "Activities":
                    ClickActivitesNavButton();
                    break;
                case "Administration":
                    ClickAdministrationNavButton();
                    break;
                case "Contacts":
                    ClickContactsNavButton();
                    break;
                case "Dashboard":
                    ClickDashboardNavButton();
                    break;
                case "Home":
                    ClickHomeNavButton();
                    break;
                case "Partners":
                    ClickPartnersNavButton();
                    break;
                case "Products & Services":
                    ClickProductsAndServicesNavButton();
                    break;
                case "Reports":
                    ClickReportsNavButton();
                    break;
                default:
                    Console.WriteLine("No case found");
                    break;
            }
        }
        public void ClickActivitesNavButton()
        {
            InputManager.Click(_activitesNavButton);
            ObjectRepository.Activities = new Activities(_driver);
        }
        public void ClickAdministrationNavButton()
        {
            InputManager.Click(_administrationNavButton);
            ObjectRepository.Administration = new Administration(_driver);
        }
        public void ClickContactsNavButton()
        {
            InputManager.Click(_contactsNavButton);
            ObjectRepository.Contacts = new Contacts(_driver);
        }
        public void ClickDashboardNavButton()
        {
            InputManager.Click(_dashboardNavButton);
            ObjectRepository.Dashboard = new Dashboard(_driver);
        }
        public void ClickHomeNavButton()
        {
            InputManager.Click(_homeNavButton);
            ObjectRepository.Home = new Home(_driver);
        }
        public void ClickPartnersNavButton()
        {
            InputManager.Click(_partnerNavButton);
            ObjectRepository.Partners = new Partners(_driver);
        }

        public void ClickProductsAndServicesNavButton()
        {
            InputManager.Click(_productsAndServicesButton);
            ObjectRepository.ProductsAndServices = new ProductsAndServices(_driver);
        }
        public void ClickReportsNavButton()
        {
            InputManager.Click(_reportsNavButton);
            ObjectRepository.Reports = new Reports(_driver);
        }
        #endregion

    }
}
