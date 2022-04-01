
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
            Logger.Info("Title : " + _scenarioContext.ScenarioInfo.Title);           
        }

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError != null)
            {
                try
                {
                    string filename = GenericHelper.TakeScreenShot(_scenarioContext.ScenarioInfo.Title);                        
                    Logger.Error("Test step failed, please see screenshot for more details : " + filename);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


        }
    }
}
