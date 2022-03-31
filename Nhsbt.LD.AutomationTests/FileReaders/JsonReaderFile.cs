using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.FileReaders
{
    /// <summary>
    /// Contains the methods necessary to read from a JSON file
    /// </summary>

    public class JsonReaderFile
    {

        public DonorDataModel ReadJsonFileReader(string fileName = "AdultDonor.json", string directoryPath = "..\\..\\Resources\\Data\\")
        {            
            StreamReader streamReader = new StreamReader(GetRelativeFilePath(directoryPath, fileName));
            string jsonString = streamReader.ReadToEnd();
            DonorDataModel donorDataModel = JsonConvert.DeserializeObject<DonorDataModel>(jsonString);
            Console.WriteLine(donorDataModel.Username1);
            Console.WriteLine(donorDataModel.key2);            
            return donorDataModel;
        }

        public string GetRelativeFilePath(string directoryPath, string fileName)
        {            
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, directoryPath + fileName);
            string icon_path = new Uri(iconPath).LocalPath;
            return icon_path;
        }

        //public class DonorDataModel
        //{
                  
        //}

    }
}
