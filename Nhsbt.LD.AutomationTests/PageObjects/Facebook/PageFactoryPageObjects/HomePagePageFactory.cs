using Newtonsoft.Json;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.PageObjects.Facebook;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects
{
    public class HomePagePageFactory : PageBaseClassPageFactory
    {
        private IWebDriver driver;

        // This was how it was before inheriting from the PageBaseClass
        //public HomePagePageFactory()
        //{
        //    PageFactory.InitElements(ObjectRepository.Driver, this);            
        //}

        public HomePagePageFactory(IWebDriver _driver) : base(_driver)
        {            
            this.driver = _driver;
        }

        #region Elements
        [FindsBy(How = How.XPath, Using = "//button[@title='Allow Essential and Optional Cookies']")] 
        private IWebElement acceptAllCookiesButton;

        [FindsBy(How = How.LinkText, Using = "Forgotten password?")] private IWebElement forgotPasswordLink;
        #endregion

        #region Interactions
        public void ClickAcceptAllCookiesButton()
        {
            acceptAllCookiesButton.Click();       
        }

        #endregion

        #region Navigation
        public FindYourAccountPageFactory ClickForgotPasswordLink()
        {          
            forgotPasswordLink.Click();
            return new FindYourAccountPageFactory(driver);
        }
        public void ReadJsonFileReader(string filePath)
        {
            StreamReader r = new StreamReader("json1.json");
            string jsonString = r.ReadToEnd();
            string m = JsonConvert.DeserializeObject<string>(jsonString);
            Console.WriteLine(m);
        }

        #endregion
    }
}
