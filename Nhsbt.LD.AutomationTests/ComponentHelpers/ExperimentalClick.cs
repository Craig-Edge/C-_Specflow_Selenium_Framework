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
    public class ExperimentalClick
    {


        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// This helper method uses the By class rather than using the IWebElement and is intended for "on the fly" testing of element locators.  
        /// Perminant solutions should use the ClickWebElement mehtod in conjuction with the relevant page object.
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static void ClickByElementConstraint(By locator, int hours = 0, int minutes = 0, int seconds = 10)
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

        /// <summary>
        /// Uses Webdriver explicit wait with a lambda function which waits for the element to be enabled before clicking for a maximum amount of time.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static void ClickWebElement(IWebElement element, int hours = 0, int minutes = 0, int seconds = 10)
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

        /// <summary>
        /// Helper method for switching into a frame or iframe
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(By frame)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
        }

        public static void SwitchToDefaultContent()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();
        }


    }
}
