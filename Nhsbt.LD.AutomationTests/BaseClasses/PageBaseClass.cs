using Nhsbt.LD.AutomationTests.ComponentHelpers;
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

        private By _partnerNavButton = By.Id("t_TreeNav_3");

        #endregion

        #region Interactions

        public void ClickNavButton(string navButton)
        {
            switch (navButton)
            {
                case "Activities":
                    break;
                case "Administration":
                    break;
                case "Contacts":
                    break;
                case "Dashboard":
                    break;
                case "Home":
                    break;
                case "Partners":
                    InputManager.Click(_partnerNavButton);
                    break;
                case "Products & Services":
                    break;
                case "Reports":
                    break;
                default:
                    Console.WriteLine("No case found");
                    break;
            }
        }

        #endregion 

    }
}
