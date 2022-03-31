
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.SetUp
{
    [Binding]
    public sealed class Hooks
    {


        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static ILog Logger = Log4NetHelper.GetLogger(typeof(Hooks));
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            BaseClass.TearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (featureContext != null)
            {

            }
            else if (featureContext == null)
            {
                Logger.Debug("feature context is null");
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {

        }


        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            BaseClass.InitWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // TODO - refactoring - the below is obsolete, replace with up to date implementation
            Console.WriteLine("Title : {0}", _scenarioContext.ScenarioInfo.Title);
            Console.WriteLine("Error : {0}", _scenarioContext.TestError);
        }

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError != null)
            {
                //GenericHelper.TakeScreenShot();

                //var file = $"{GenericHelper.TakeScreenShot()}";

                try
                {
                    //var geturi = new Uri(file);
                    GenericHelper.TakeScreenShot();                    
                    //Uri getUri = new Uri(GenericHelper.TakeScreenShot());
                    //string thisUri = getUri.AbsoluteUri;
                    //Logger.Debug("file name is : " + thisUri);
                    //Logger.Debug("file uri is : " + thisUri);
                    //Logger.Error("Test step failed, please see screenshot for more details : " + thisUri);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            //[AfterStep]
            //public void AfterWebTest()
            //{
            //    if (ScenarioContext.Current.TestError != null)
            //    {
            //        TakeScreenshot(ObjectRepository.Driver);
            //    }
            //}

            //private void TakeScreenshot(IWebDriver driver)
            //{
            //    try
            //    {
            //    //string fileNameBase = string.Format("error{0}",                                                  
            //    //                                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));


            //    //string fileNameBase = $"{AppDomain.CurrentDomain.BaseDirectory}..//..//Resources//Screenshots{_scenarioContext.ScenarioInfo.Title + "_" + System.DateTime.Now.TimeOfDay.ToString("hh-mm-ss")}";
            //    string fileNameBase = "..//..//Resources//Screenshots//" + _scenarioContext.ScenarioInfo.Title + "_" + System.DateTime.Now.TimeOfDay.ToString("hh-mm-ss");
            //    var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "testresults");
            //        if (!Directory.Exists(artifactDirectory))
            //            Directory.CreateDirectory(artifactDirectory);

            //        string pageSource = driver.PageSource;
            //        string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
            //        File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
            //        Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

            //        ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

            //        if (takesScreenshot != null)
            //        {
            //            var screenshot = takesScreenshot.GetScreenshot();

            //            string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");

            //            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

            //            Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error while taking screenshot: {0}", ex);
            //    }
            //}

        }
    }
}
