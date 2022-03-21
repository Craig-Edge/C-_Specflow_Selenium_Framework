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
            bool isButtonEnabled;
            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = ObjectRepository.Driver.FindElement(locator);
                    isButtonEnabled = elementToBeDisplayed.Enabled;
                    if (isButtonEnabled) { elementToBeDisplayed.Click(); }
                    return isButtonEnabled;
                }
                catch (StaleElementReferenceException exception)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    
                    throw exception;
                }
                catch (NoSuchElementException exception)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    //Logger.Info("No such element found using - " + locator + " - locator" + "\n" +
                                //"Stack Trace : " + exception);
                    return false;
                }
            });
        }

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static void Click(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            bool isEnabled;
            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            wait.Until(condition =>
            {
                try
                {
                    isEnabled = element.Enabled;
                    if (isEnabled) { element.Click(); }
                    return isEnabled;
                }
                catch (StaleElementReferenceException exception)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    return false;
                }
                catch (NoSuchElementException exception)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    //Logger.Info("No such element found using - " + element + " - element" + "\n" +
                    //           "Stack Trace : " + exception);
                    return false;
                }
            });
        }

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
            element.SendKeys(data);
            Logger.Debug("Entered : " + data);
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
            element.SendKeys("I am sending keys");
        }

        #endregion
    }
}
