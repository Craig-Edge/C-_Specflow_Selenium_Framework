using Nhsbt.LD.AutomationTests.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.Interfaces
{

    /// <summary>
    /// This interface is for use where values must be read from the app.config file that are essential for framework initialisation
    /// </summary>
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        string GetW3Schools();

        string GetDeveloperSandbox();

        string GetTransportInformationManager();

    }
}
