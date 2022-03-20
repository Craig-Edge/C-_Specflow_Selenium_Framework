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
        public static void ScrollToElement(IWebElement element, int seconds = 10, int minutes = 0, int hours = 0)
        {
            GenericHelper.WaitforElementToBeDisplayed(element, seconds, minutes, hours);
            Actions actions = new Actions(ObjectRepository.Driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        #region Frame Switching helper methods

        /// <summary>
        /// Switches to Default DOM scope
        /// </summary>
        public static void SwitchToDefaultContent()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Helper method for switching into a frame or iframe.  Can be used with IWebelemnt or By
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(IWebElement frame)
        {
            // TODO - explicit wait - Add wait conditions to all Switch to frame helper methods
            ObjectRepository.Driver.SwitchTo().Frame(frame);
        }

        /// <summary>
        /// Helper method for switching into a frame or iframe.  Can be used with IWebelemnt or By 
        /// </summary>
        /// <param name="frame"></param>
        public static void SwitchToFrame(By frame)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(frame));
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

        public void SwitchToNewWindow()
        {
            ObjectRepository.Driver.SwitchTo().NewWindow(WindowType.Tab);
        }
     
    }
}
