using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
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

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseClass.InitWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Title : {0}", ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("Error : {0}", ScenarioContext.Current.TestError);
            BaseClass.TearDown();
        }
    }
}
