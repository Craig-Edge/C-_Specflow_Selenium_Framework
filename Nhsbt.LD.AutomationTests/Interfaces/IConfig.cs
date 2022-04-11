using Nhsbt.LD.AutomationTests.Configuration;

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
        string GetDeveloperSandbox();
        string GetTransportInformationManager();
        string GetSandboxURL();
        string GetJsonFileName();
    }
}
