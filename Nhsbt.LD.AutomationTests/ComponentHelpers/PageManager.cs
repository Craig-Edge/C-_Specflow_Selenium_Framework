using log4net;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.ComponentHelpers
{
    public class PageManager
    {

        private static ILog Logger = Log4NetHelper.GetLogger(typeof(PageManager));

        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        public static void NavigateToUrl(string url)
        {
            try
            {
                ObjectRepository.Driver.Navigate().GoToUrl(url);
                Logger.Info("Navigating to : " + url);
            }
             catch (Exception exception)
            {
                Logger.Error("There was an issue navigating to : " + url);
                throw exception;
            }
        }

        /// <summary>
        /// Waits for an element to be diplayed and then scrolls to it
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static IWebElement ScrollToElement(By locator, int seconds = 10, int minutes = 0, int hours = 0)
        {
            try
            {
                GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
                Actions actions = new Actions(ObjectRepository.Driver);
                IWebElement element = ObjectRepository.Driver.FindElement(locator);
                actions.MoveToElement(element);
                actions.Perform();
                Logger.Info("Scrolling to element : " + element.ToString());
                return element;
            }
            catch (Exception exception)
            {
                Logger.Error("There was an issue scrolling to the element : " + locator.ToString());
                throw exception;
            }
        }

        /// <summary>
        /// Waits for an element to be diplayed and then scrolls to it
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static void ScrollToElement(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            try
            {
                GenericHelper.WaitforElementToBeDisplayed(element, seconds, minutes, hours);
                Actions actions = new Actions(ObjectRepository.Driver);
                actions.MoveToElement(element);
                actions.Perform();
                Logger.Info("Scrolling to element");
            }
            catch (Exception exception)
            {
                Logger.Error("There was an issue scrolling to the element");
                throw exception;
            }
        }

        #region Frame Switching helper methods

        /// <summary>
        /// Switches to Default DOM scope
        /// </summary>
        public static void SwitchToDefaultContent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().DefaultContent();
                Logger.Debug("Switching to default content");
            }
            catch (Exception exception)
            {
                Logger.Debug("Failed to switch to default content");
                throw exception;
            }            
        }

        /// <summary>
        /// Helper method for switching into a frame or iframe.  Can be used with IWebelemnt or By
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(IWebElement frame)
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Frame(frame);
                Logger.Debug("Switching to default content");
            }
            catch (Exception exception)
            {
                Logger.Error("Could not switch to iframe");
                throw exception;
            }            
        }

        /// <summary>
        /// Helper method for switching into a frame or iframe.  Can be used with IWebelemnt or By 
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(By frame)
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
                Logger.Debug("Switched to iframe  : " + frame);
            }
            catch(Exception exception)
            {
                Logger.Error("Could not switch to iframe : " + frame.ToString());
                throw exception;
            }
        }

        /// <summary>
        /// Helper method for switching from a frame or iframe to another frame or iframe
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchFromFrameToFrame(IWebElement frame)
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().DefaultContent();
                ObjectRepository.Driver.SwitchTo().Frame(frame);
            }

            catch(Exception exception)
            {
                Logger.Error("Could not switch from current frame to specified frame");
                throw exception;
            }
          
        }

        /// <summary>
        /// Helper method for switching from a frame or iframe to another frame or iframe
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchFromFrameToFrame(By frame)
        {
            //TODO - Refactoring - Can refine frame switching methods once we see the application, Logging is not as ood as it could be
            try
            {
                // TODO - Framework testing - This needs to be tested
                ObjectRepository.Driver.SwitchTo().DefaultContent();                
                ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
            }
            catch (Exception exception)
            {
                Logger.Error("Could not switch from current frame to : " + frame);
                throw exception;
            }
        }

        #endregion

        public static void SwitchToNewWindow()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().NewWindow(WindowType.Tab);
                Logger.Info("Opening new Tab");
            }

            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
