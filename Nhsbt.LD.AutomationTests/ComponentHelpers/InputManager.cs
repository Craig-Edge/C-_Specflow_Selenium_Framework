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
        #region Click helper methods

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// This helper method uses the By class rather than using the IWebElement and is intended for "on the fly" testing of element locators.  
        /// Perminant solutions should use the ClickWebElement mehtod in conjuction with the relevant page object.
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static void ClickUsingBy(By locator, int seconds = 10, int minutes = 0, int hours = 0)
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
                catch (NoSuchElementException)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
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
                catch (StaleElementReferenceException)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    return false;
                }
                catch (NoSuchElementException)
                {
                    // TODO - Best Practice - Find out if these catch statements should also throw an exception, I believe this could cause the lambda function to break 
                    // and therefore the fail the test prematurely.
                    return false;
                }
            });
        }


        public static void ScrollToElementAndClick(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            PageManager.ScrollToElement(element, seconds, minutes, hours);
            Click(element, seconds, minutes, hours);
        }

        #endregion

        #region Date Entry helper methods

        /// <summary>
        /// Waits for an element to be displayed and then used the SendKeys method to enter data.  Can be used with By or IWebelement
        /// </summary>
        /// <param name="locator"></param>
        public static void EnterData(By locator, string data, int seconds = 10, int minutes = 0, int hours = 0)
        {
            // TODO - framework testing - needs to be tested
            GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
            GenericHelper.GetElement(locator).SendKeys(data);
        }

        public static void EnterData(IWebElement element, string data, int seconds = 10, int minutes = 0, int hours = 0)
        {
            // TODO - framework testing - needs to be tested
            GenericHelper.WaitforElementToBeDisplayed(element, seconds, minutes, hours);
            element.SendKeys("I am sending keys");
        }

        #endregion
    }
}
