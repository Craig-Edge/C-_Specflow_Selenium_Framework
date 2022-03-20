using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Interfaces;
using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook.IWebElementPageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.IWebElementPageObjects.W3;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static HtmlFormsPracticePage htmlFormsPracticePage;
        public static HtmlTutorial htmlTutorial;
        public static HopePage homePage;
        public static W3CommonElements w3CommonElements;

        public static PageManager pageManager;
    }
}
