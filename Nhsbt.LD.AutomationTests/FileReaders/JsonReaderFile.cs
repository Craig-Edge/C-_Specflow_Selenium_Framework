using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.IO;
using System.Reflection;

namespace Nhsbt.LD.AutomationTests.FileReaders
{
    /// <summary>
    /// Contains the methods necessary to read from a JSON file
    /// </summary>

    public class JsonReaderFile
    {
        /// <summary>
        /// Reads a Json file and returns it as a DonorDataModel object which conforms to a specific schema related to a donor
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public DonorDataModel ReadDonorDataJsonFile(string fileName = "AdultDonor.json", string directoryPath = "..\\..\\Resources\\Data\\")
        {            
            StreamReader streamReader = new StreamReader(GetRelativeFilePath(directoryPath, fileName));
            string jsonString = streamReader.ReadToEnd();
            DonorDataModel donorDataModel = JsonConvert.DeserializeObject<DonorDataModel>(jsonString);                     
            return donorDataModel;
        }

        /// <summary>
        /// Reads a Json file and returns the Json Object
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="directoryPath"></param>
        /// <returns>Json Object from file</returns>

        string fileName = ObjectRepository.Config.GetJsonFileName();
        public JObject GetJsonObject(string fileName, string directoryPath = "..\\..\\Resources\\Data\\")
        {
            // Reads the json file using a relative path
            StreamReader streamReader = new StreamReader(GetRelativeFilePath(directoryPath, fileName));              
            // Returns parsed Json file as a Json object which can then be accessed 
            return JObject.Parse(streamReader.ReadToEnd());
        }

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
