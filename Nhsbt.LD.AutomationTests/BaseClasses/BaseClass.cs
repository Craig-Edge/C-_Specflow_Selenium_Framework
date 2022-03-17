﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.Configuration;
using Nhsbt.LD.AutomationTests.CustomException;
using Nhsbt.LD.AutomationTests.Settings;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.BaseClasses
{
    [TestClass]
   
    //[SetUpFixture]
    public class BaseClass
    {

        public static ChromeOptions ChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;
        }

        public static EdgeOptions EdgeOptions()
        {
            EdgeOptions option = new EdgeOptions();
            option.AddArgument("start-maximized");
            return option;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(ChromeOptions());            
            return driver;
        }

        private static IWebDriver GetEdgeDriver()
        {
            IWebDriver driver = new EdgeDriver(EdgeOptions());
            return driver;
        }

        
        //[SetUp]
        //[AssemblyInitialize]
        
        public static void InitWebDriver()
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.Edge:
                    ObjectRepository.Driver = GetEdgeDriver();
                    break;
                default:                
                    throw new NoSuitableDriverFound("Driver Not Found " + ObjectRepository.Config.GetBrowser().ToString());
            }
        }

     
       //[TearDown]
        //[AssemblyCleanup]
        public static void TearDown()
        {
            if(ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}