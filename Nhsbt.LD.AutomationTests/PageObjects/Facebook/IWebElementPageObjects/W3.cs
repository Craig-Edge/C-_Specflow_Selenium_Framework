using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects
{
    public class W3
    {
        private readonly IWebElement _runButton = ObjectRepository.Driver.FindElement(By.Id("getwebsitebtn"));

        public void ClickRunButton()
        {
            ExperimentalClick.ClickWebElement(_runButton);
        }
    }
}
