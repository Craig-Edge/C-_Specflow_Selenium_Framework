using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region Sandbox Environment

        #region elements

        private By _homeNavButton = By.Id("t_TreeNav_0");
        private By _dashboarNavButton = By.Id("t_TreeNav_1");
        private By _prodcutsAndServicesNavButton = By.Id("t_TreeNav_2");
        private By _partnersNavButton = By.Id("t_TreeNav_3");
        private By _contactsNavButton = By.Id("t_TreeNav_4");
        private By _activitiesNavButton = By.Id("t_TreeNav_5");
        private By _reportsNavButton = By.Id("t_TreeNav_6");
        private By _administrationNavButton = By.Id("t_TreeNav_7");

        #endregion

        #region Interactions 

        public void clickSpecificNavButton(string navButton)
        {
            switch (navButton)
            {
                case "home":
                    InputManager.Click(_homeNavButton);
                    break;
                case "dashboard":
                    InputManager.Click(_dashboarNavButton);
                    break;
                case "products & services":
                    InputManager.Click(_prodcutsAndServicesNavButton);
                    break;
                case "partners":
                    InputManager.Click(_partnersNavButton);                 
                    break;
                case "contacts":
                    InputManager.Click(_contactsNavButton);
                    break;
                case "activities":
                    InputManager.Click(_activitiesNavButton);
                    break;
                case "reports":
                    InputManager.Click(_reportsNavButton);
                    break;
                case "administration":
                    InputManager.Click(_administrationNavButton);
                    break;
            }
            #endregion

            #region Navigation         

            #endregion            
        }
    }

    #endregion

}
