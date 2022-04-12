using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.BaseClasses;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using OfficeOpenXml;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.PageObjects.POC.Sandbox
{


    public class TestSandboxWebsite : PageBaseClass
    {
        private IWebDriver _driver;

        public TestSandboxWebsite(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        #region
        private By _searchButton = By.Id("P1_SEARCH");
        private By _totalButton = By.XPath("//*[text()='Total']");
        #endregion

        #region interactions

        public void ClickSearchButton()
        {

            GenericHelper.IsElementPresent(_searchButton);
            InputManager.Click(_searchButton);
        
        }

        //public void SearchCustomer(String abc)
        //{
        //    GenericHelper.WaitforElementToBeDisplayed(_searchButton,20);
        //    Console.WriteLine("Wait for the page upload");
        //    InputManager.EnterData(_searchButton,abc);

        //    GenericHelper.WaitforElementToBeDisplayed(_searchButton,30);
        //}

        public void ClickTotalButton()
        {
            InputManager.Click(_totalButton);

        }
     
       [DynamicData(nameof(ReadMyExcel),DynamicDataSourceType.Method)]
        public void SearchCustomer(String abc)
        {
            GenericHelper.WaitforElementToBeDisplayed(_searchButton, 20);
            Console.WriteLine("Wait for the page upload");
            InputManager.EnterData(_searchButton,abc);
            GenericHelper.WaitforElementToBeDisplayed(_searchButton, 30);
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
        #endregion
    }
}

