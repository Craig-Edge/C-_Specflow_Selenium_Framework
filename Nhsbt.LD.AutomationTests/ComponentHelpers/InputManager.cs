using log4net;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nhsbt.LD.AutomationTests.ComponentHelpers
{
    public class InputManager
    {
        private static ILog Logger = Log4NetHelper.GetLogger(typeof(InputManager));

        #region Click helper methods

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static void Click(By locator, int seconds = 10, int minutes = 0, int hours = 0)
        {
            
            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            bool isClickableElementEnabled = wait.Until(condition =>
            {
                    var elementToBeEnabled = GenericHelper.GetElement(locator);
                    isClickableElementEnabled = GenericHelper.IsElementPresent(elementToBeEnabled);
                    if (isClickableElementEnabled) { elementToBeEnabled.Click(); }
                    return isClickableElementEnabled;          
            });
        }

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static void Click(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            bool isEnabled = wait.Until(condition =>
            {                
                    isEnabled = GenericHelper.IsElementEnabled(element);
                    if (isEnabled) { element.Click(); }
                    return isEnabled;
            });
        }

        /// <summary>
        /// Waits for an element to be visible, scrolls to that element then waits for that element to be clickable and clicks
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void ScrollToElementAndClick(By locator, int seconds = 10, int minutes = 0, int hours = 0)
        {            
            var element = PageManager.ScrollToElement(locator, seconds, minutes, hours);
            Click(element, seconds, minutes, hours);
        }

        public static void ScrollToElementAndClick(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            PageManager.ScrollToElement(element, seconds, minutes, hours);
            Click(element, seconds, minutes, hours);
        }

        #endregion

        #region Data Entry helper methods

        /// <summary>
        /// Waits for an element to be displayed, clears any exisiting data and then used the SendKeys method to enter data.  Can be used with By or IWebelement
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="data"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void EnterData(By locator, string data, int seconds = 10, int minutes = 0, int hours = 0)
        {
            // TODO - framework testing - needs to be tested
            GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
            var element = GenericHelper.GetElement(locator);
            element.Clear();
            Logger.Info("Clearing element of data");
            element.SendKeys(data);           
            Logger.Debug("Entered data : " + data + " into : " + locator.ToString());
        }

        /// <summary>
        /// Waits for an element to be displayed, clears any exisiting data and then used the SendKeys method to enter data.  Can be used with By or IWebelement
        /// </summary>
        /// <param name="element"></param>
        /// <param name="data"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void EnterData(IWebElement element, string data, int seconds = 10, int minutes = 0, int hours = 0)
        {
            // TODO - framework testing - needs to be tested
            GenericHelper.WaitforElementToBeDisplayed(element, seconds, minutes, hours);
            element.Clear();
            Logger.Info("Clearing element of data");
            element.SendKeys(data);
            Logger.Debug("Entered data : " + data + " into : " + element.ToString());
        }

        #endregion
    }
}
