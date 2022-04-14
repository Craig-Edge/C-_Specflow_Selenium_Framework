using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.FileReaders
{
    public class JsonReaderNew
    {
        public JsonReaderNew()
        { 
        }

        public string extractData(String tokenName)
        {
            string myJsonString = File.ReadAllText("Resources/Data/AdultDonor.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenName).Value<string>();   
        }

        public static JsonReaderNew getDataParser()
        {
            return new JsonReaderNew();
        }



    }
}
