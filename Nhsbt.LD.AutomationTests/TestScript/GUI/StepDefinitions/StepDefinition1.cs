using Nhsbt.LD.AutomationTests.PageObjects;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.TestScript.GUI.FeatureFiles
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public StepDefinition1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
    }
}
