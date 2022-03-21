using log4net;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.ComponentHelpers
{

    public class GenericHelper
    {
        private static ILog Logger = Log4NetHelper.GetLogger(typeof(GenericHelper));

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
                return ObjectRepository.Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        #region IsElementPresent helper methods

        /// <summary>
        /// Checks if the element is displayed, can be used with By or WebElement
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static bool IsElementPresent(By locator)
        {
            try
            {
                //return ObjectRepository.Driver.FindElements(locator).Count == 1;
                return ObjectRepository.Driver.FindElement(locator).Displayed;
            }

            catch (Exception)
            {
                return false;
            }           
        }


        /// <summary>
        /// Checks if the element is displayed, can be used with By or WebElement
        /// </summary>
        /// <param name="locator"></param>
        /// <returns>bool</returns>
        public static bool IsElementPresent(IWebElement element)
        {
            try
            {
                //return ObjectRepository.Driver.FindElements(locator).Count == 1;
                return element.Displayed;
            }

            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region WaitForElementToBeVisible helper methods

        /// <summary>
        /// Waits for an element to be present for a default of 10 seconds.  Can be used with By or IWebElement
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void WaitforElementToBeDisplayed(By locator, int seconds = 10, int minutes = 0, int hours = 0)
        {

            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            bool isElementDisplayed = wait.Until(condition =>
            {
                try
                {
                    isElementDisplayed = IsElementPresent(locator);
                    return isElementDisplayed;
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
        /// Waits for an element to be present for a default of 10 seconds.  Can be used with By or IWebElement
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public static void WaitforElementToBeDisplayed(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(hours, minutes, seconds));
            bool isElementDisplayed = wait.Until(condition =>
            {
                try
                {
                    isElementDisplayed = element.Displayed;                   
                    return isElementDisplayed;
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

        #endregion


        public static void TakeScreenShot(string filename = "Screen", string filePath = "..//..//Nhsbt.LD.AutomationTests//Nhsbt.LD.AutomationTests//Resources//Screenshots//")
        {            
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();           
            filename = filePath + filename + DateTime.Now.ToString(" dd-MM-yyyy -- hh-mm-ss") + ".jpeg";
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);         
        }
    }
}
