using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3
{
    public class HopePage : PageBaseClass
    {   
        public HopePage(driver) : base (driver)
        {
            this ObjectRepository.Driver;
        }
           

        public void NavigateToHTMLFormsTutorialPracticePage()
        {
            InputManager.Click(ObjectRepository.w3CommonElements.GetTutorialMenuDropDown);
            InputManager.Click(ObjectRepository.w3CommonElements.GetLearnHtmlLink);
            //return new HtmlTutorial();
        }
    }
}

