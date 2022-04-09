using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhsbt.LD.AutomationTests.ComponentHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.FileReaders.ExcelReader
{
   [TestClass]
    public class ExcelFileReader
    {
        private static FileReaderHelper _fileReaderHelper;
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream _stream;
        private static IExcelDataReader _reader;
        private static ScenarioContext _scenarioContext;

       
        public ExcelFileReader(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        static ExcelFileReader()
        {            
            _fileReaderHelper = new FileReaderHelper();
            _cache = new Dictionary<string, IExcelDataReader>();
        } 
       
        public static DataTable GetExcelDataFromSheet(string sheetName, string fileName = "Test.xlsx", string directoryPath = "..\\..\\Resources\\Data\\ExcelFiles\\")
        {
            _stream = new FileStream(_fileReaderHelper.GetRelativeFilePath(directoryPath, fileName), FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(_stream);
            DataTable table = reader.AsDataSet().Tables[sheetName];                 
            return table;
        }

        public static object getCellData(string sheetName, int row, int column, string fileName = "Test.xlsx", string directoryPath = "..\\..\\Resources\\Data\\ExcelFiles\\")
        {
            string excelPath = _fileReaderHelper.GetRelativeFilePath(directoryPath, fileName);

            if (_cache.ContainsKey(sheetName))
            {
                _reader = _cache[sheetName];
            }
            else
            {
                _stream = new FileStream(excelPath, FileMode.Open, FileAccess.Read);
                _reader = ExcelReaderFactory.CreateOpenXmlReader(_stream);
                _cache.Add(sheetName, _reader);
            }

            DataTable table = _reader.AsDataSet().Tables[sheetName];
            return GetData(table.Rows[row][column].GetType(), table.Rows[row][column]);         
        }

        private static object GetData(Type type, object data)
        {
            switch(type.Name)
            {
                case "String":
                    return data.ToString();
                case "Double":
                    return Convert.ToDouble(data);
                case "DateTime":
                    return Convert.ToDateTime(data);
                default:
                    return data.ToString();
            }
        }
         /// <summary>
         /// Takes key value pairs from the excel sheet and loads them into the scenario context dictionary, dynamically adding the key value.
         /// </summary>
         /// <param name="excelData"></param>
         /// <param name="_scenarioContext"></param>
        public static void LoadExcelDataIntoScenarioContextDictionary(string sheetName, ScenarioContext _scenarioContext)
        {
            DataTable excelData = GetExcelDataFromSheet(sheetName);

            for (int i = 0; i < excelData.Rows.Count; i++)
            {
                var col = excelData.Rows[i];
                for (int j = 0; j < col.ItemArray.Length - 1; j += 2)
                {
                    string key = col.ItemArray[j].ToString();
                    var value = col.ItemArray[j + 1];
                    _scenarioContext[key] = value;

                    Console.WriteLine("Key : " + key + " - Value : " + value);
                }
            }
        }

        public static Dictionary<string, string> LoadExcelDataIntoDictionary(string sheetName)
        {
            DataTable excelData = GetExcelDataFromSheet(sheetName);
            Dictionary<string, string> data = new Dictionary<string, string>();

            for (int i = 0; i < excelData.Rows.Count; i++)
            {
                var col = excelData.Rows[i];
                for (int j = 0; j < col.ItemArray.Length - 1; j += 2)
                {
                    string key = col.ItemArray[j].ToString();
                    var value = col.ItemArray[j + 1];
                    data[key] = value.ToString();

                    Console.WriteLine("Key : " + key + " - Value : " + value);
                }
            }
            return data;
        }
    }
}
