
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
            if(featureContext != null)
            {
                
            }
            else if(featureContext == null)
            {
                Console.WriteLine("feature context is null");
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
              
            }
            BaseClass.InitWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Title : {0}", ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("Error : {0}", ScenarioContext.Current.TestError);
            //string name = _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
            //GenericHelper.TakeScreenShot(name);           
        }

        [AfterStep]
        public void AfterStep()
        {
            //ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            //switch (scenarioBlock)
            //{
            //    case ScenarioBlock.Given:
            //        CreateNode<Given>();
            //        break;
            //    case ScenarioBlock.When:
            //        CreateNode<When>();
            //        break;
            //    case ScenarioBlock.Then:
            //        CreateNode<Then>();
            //        break;
            //    default:
            //        CreateNode<And>();
            //        break;
            //}            
        }

        public void CreateNode<T>()
        {
            //if (_scenarioContext.TestError != null)
            //{
            //    string name = @"C:\Users\gord0019\Desktop\Reports\" + _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";
            //    GenericHelper.TakeScreenShot(name);
            //    _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Fail(
            //    _scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace + "\n").AddScreenCaptureFromPath(name);
            //}
            //else
            //{
            //    _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Pass(""); ;
            //}
        }
    }
}
