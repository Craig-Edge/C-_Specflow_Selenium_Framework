﻿using Nhsbt.LD.AutomationTests.Interfaces;
using Nhsbt.LD.AutomationTests.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.Configuration
{

    /// <summary>
    /// This class is used to read the necessary data & settings reqiured for the framework's initialisation.  It uses the IConfig interfdace which ensures that any configuration 
    /// methods set in the interface must be implemented here.
    /// </summary>


    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType) Enum.Parse(typeof(BrowserType), browser); 
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetW3Schools()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.W3Schools);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
