using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.SetUp
{
    [Binding]
    public sealed class Hooks1
    {


        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //_extentHtmlReporter = new ExtentHtmlReporter("..\\..\\Resources\\Reports");
            _extentHtmlReporter = new ExtentHtmlReporter(@"C:\Users\gord0019\Desktop\Reports\");
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _extentReports.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if(featureContext != null)
            {
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
            }
            else if(featureContext == null)
            {
                Console.WriteLine("feature contecxr is null");
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            
        }


        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            if (scenarioContext != null)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }
            BaseClass.InitWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Title : {0}", ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("Error : {0}", ScenarioContext.Current.TestError);
            string name = _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
            GenericHelper.TakeScreenShot(name);
            BaseClass.TearDown();
        }

        [AfterStep]
        public void AfterStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    //if (_scenarioContext.TestError != null)
                    //{ 
                    //    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(
                    //    _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n");
                    //}
                    //else
                    //{
                    //    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass(""); ;
                    //}


                    CreateNode<Given>();
                    break;
                case ScenarioBlock.When:

                    //if (_scenarioContext.TestError != null)
                    //{
                    //    _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(
                    //    _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n");
                    //}
                    //else
                    //{
                    //    _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    //}


                    CreateNode<When>();
                    break;
                case ScenarioBlock.Then:
                    //if (_scenarioContext.TestError != null)
                    //{
                    //    _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(
                    //    _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n");
                    //}
                    //else
                    //{
                    //    _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass(""); ;
                    //}


                    CreateNode<Then>();
                    break;
                default:
                    //if (_scenarioContext.TestError != null)
                    //{
                    //    _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(
                    //    _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n");
                    //}
                    //else
                    //{
                    //    _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Pass(""); ;
                    //}

                    CreateNode<And>();
                    break;
            }            
        }

        public void CreateNode<T>() where T : IGherkinFormatterModel
        {
            if (_scenarioContext.TestError != null)
            {
                string name = @"C:\Users\gord0019\Desktop\Reports\" + _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
                GenericHelper.TakeScreenShot(name);
                _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Fail(
                _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n").AddScreenCaptureFromPath(name);
            }
            else
            {
                _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Pass(""); ;
            }
        }
    }
}
