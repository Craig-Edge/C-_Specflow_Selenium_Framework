using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using Nhsbt.LD.AutomationTests.Settings;
using OfficeOpenXml;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

 

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        private By _searchButton = By.Id("P1_SEARCH");
        private By _totalButton = By.XPath("//*[text()='Total']");

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [DynamicData(nameof(ReadMyExcel), DynamicDataSourceType.Method)]
        public void SearchCustomer(String abc)
        {
            BaseClass.InitWebDriver();
            ObjectRepository.TestSandboxWebsite = new TestSandboxWebsite(ObjectRepository.Driver);
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetSandboxURL());
            GenericHelper.WaitforElementToBeDisplayed(_searchButton, 20);
            Console.WriteLine("Wait for the page upload");
            InputManager.EnterData(_searchButton, abc);
            GenericHelper.WaitforElementToBeDisplayed(_searchButton, 60);
            ObjectRepository.TestSandboxWebsite.ClickTotalButton();
            BaseClass.TearDown();
        }

        public static IEnumerable<object[]> ReadMyExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("data.xlsx")))
            {
                //Get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                int rowCount = worksheet.Dimension.End.Row; //Get the row count
                for (int row = 2; row <= rowCount; row++)
                {
                    yield return new object[]
                    {
                     worksheet.Cells[row ,1].Value?.ToString().Trim(),
              // worksheet.Cells[row ,2].Value?.ToString().Trim(),
              // worksheet.Cells[row ,3].Value?.ToString().Trim(),

                    };

                }

            }

        }
    }
}
