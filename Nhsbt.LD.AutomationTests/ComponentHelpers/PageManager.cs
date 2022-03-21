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
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }

        public static IWebElement ScrollToElement(By locator, int seconds = 10, int minutes = 0, int hours = 0)
        {
            try
            {
                // TODO - put all of these actions into a try catch with debug logging in the catch
                GenericHelper.WaitforElementToBeDisplayed(locator, seconds, minutes, hours);
                Actions actions = new Actions(ObjectRepository.Driver);
                IWebElement element = ObjectRepository.Driver.FindElement(locator);
                actions.MoveToElement(element);
                actions.Perform();
                return element;
            }
            catch (Exception exception)
            {
                throw exception;
            }

       
        }

        public static void ScrollToElement(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            try
            {
                GenericHelper.WaitforElementToBeDisplayed(element, seconds, minutes, hours);
                Actions actions = new Actions(ObjectRepository.Driver);
                actions.MoveToElement(element);
                actions.Perform();
                Logger.Debug("This is a scroll debug");
            }
            catch (Exception exception)
            {
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
            }
            catch (Exception exception)
            {
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

            }
            catch (Exception exception)
            {
                Logger.Error("Could not switch to frame : " + frame + "\n" +
                             "Stack Trace : " + exception);
                throw exception;
            }
            
            
        }

        /// <summary>
        /// Helper method for switching into a frame or iframe.  Can be used with IWebelemnt or By 
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(By frame)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
            Logger.Debug("Switched to iframe  : " + frame);
        }

        /// <summary>
        /// Helper method for switching from a frame or iframe to another frame or iframe
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchFromFrameToFrame(IWebElement frame)
        {
            // TODO - Framework testing - This needs to be tested
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            ObjectRepository.Driver.SwitchTo().Frame(frame);
        }

        /// <summary>
        /// Helper method for switching from a frame or iframe to another frame or iframe
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchFromFrameToFrame(By frame)
        {
            // TODO - Framework testing - This needs to be tested
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
        }

        #endregion

        public static void SwitchToNewWindow()
        {
            ObjectRepository.Driver.SwitchTo().NewWindow(WindowType.Tab);
        }
    }
}
