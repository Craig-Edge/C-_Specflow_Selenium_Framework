using Nhsbt.LD.AutomationTests.Interfaces;
using Nhsbt.LD.AutomationTests.PageObjects.Sandbox;
using OpenQA.Selenium;

namespace Nhsbt.LD.AutomationTests.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
       
        public static Activities Activities { get; set; }
        public static Administration Administration { get; set; }
        public static Contacts Contacts { get; set; }
        public static Customers Customers { get; set; }
        public static Home Home { get; set; }
        public static Dashboard Dashboard { get; set; }
        public static Partners Partners { get; set; }
        public static ProductsAndServices ProductsAndServices { get; set; }
        public static Reports Reports { get; set; }              
    }
}
