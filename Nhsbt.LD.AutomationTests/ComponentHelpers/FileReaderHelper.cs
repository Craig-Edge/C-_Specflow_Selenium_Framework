using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Nhsbt.LD.AutomationTests.ComponentHelpers
{
    public class FileReaderHelper
    {
        public FileReaderHelper() { }    

        /// <summary>
        /// Used to get a relative filepath and returns as a string
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="fileName"></param>
        /// <returns>Relative filepath as a string</returns>
        public string GetRelativeFilePath(string directoryPath, string fileName)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, directoryPath + fileName);
            string icon_path = new Uri(iconPath).LocalPath;
            return icon_path;
        }   
    }
}
