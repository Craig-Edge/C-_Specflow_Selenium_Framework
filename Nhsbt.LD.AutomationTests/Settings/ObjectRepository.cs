using Nhsbt.LD.AutomationTests.Interfaces;
using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
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

        public static FindYourAccount findYourAccount;
        public static FindYourAccountPageFactory findYourAccountPageFactory;
        public static HomePage homePage;
        public static HomePagePageFactory homePagePageFactory;
    }
}
