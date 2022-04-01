using Nhsbt.LD.AutomationTests.Interfaces;
using Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox;
using OpenQA.Selenium;

namespace Nhsbt.LD.AutomationTests.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static CustomerDashboard customerDashboard;
        public static Partners partners;
    }
}
