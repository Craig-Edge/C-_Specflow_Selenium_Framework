using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


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
            GenericHelper.WaitforElementToBeEnabled(locator, seconds, minutes, hours);
            GenericHelper.GetElement(locator).Click();                   
        }

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static void Click(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            GenericHelper.WaitforElementToBeEnabled(element, seconds, minutes, hours);
            element.Click();
        }

        /// <summary>
        /// Waits for an element to be visible, scrolls to that element then waits for that element to be clickable and clicks
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void ScrollToElementAndClick(By locator, int seconds = 100, int minutes = 0, int hours = 0)
        {            
            var element = PageManager.ScrollToElement(locator, seconds, minutes, hours);
            Click(element, seconds, minutes, hours);
        }

        /// <summary>
        /// Waits for an element to be visible, scrolls to that element then waits for that element to be clickable and clicks
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
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
            Logger.Debug("Entered data : " + data);
        }

        #endregion

        #region Dropdown Helper methods
        /// <summary>
        /// Helper method that selects a dropdown value by Text
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="option"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void SelectDropdownOptionByText(By locator, string option, int seconds = 10, int minutes = 0, int hours = 0)
        {
            GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
            var selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByText(option);
        }

        /// <summary>
        /// Helper method that selects a dropdown value by value
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="option"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void SelectDropdownOptionByValue(By locator, string option, int seconds = 10, int minutes = 0, int hours = 0)
        {
            GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
            var selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByValue(option);
        }

        /// <summary>
        /// Helper method that selects a dropdown value by index
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="option"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void SelectDropdownOptionByIndex(By locator, int index, int seconds = 10, int minutes = 0, int hours = 0)
        {
            GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
            var selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByIndex(index);
        }

        #endregion

    }
}
