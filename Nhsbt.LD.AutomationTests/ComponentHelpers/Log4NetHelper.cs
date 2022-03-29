using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.ComponentHelpers
{
    public class Log4NetHelper
    {

        #region Field

        private static ILog _logger;
        private static ConsoleAppender _consoleAppender;
        private static FileAppender _fileAppender;
        private static RollingFileAppender _rollingFileAppender;
        private static string _layout = "%date{dd-MM-yyyy-HH:mm:ss} [%class] [%level] [%method] - %message%newline";

        #endregion

        #region Property

        public static string Layout { set { _layout = value; } }

        #endregion

        #region Private

        private static PatternLayout GetPatternLayout()
        {
            var patternLayout = new PatternLayout()
            {
                ConversionPattern = "%date{dd-MM-yyyy-HH:mm:ss} [%class] [%level] [%method] - %message%newline"
            };
            patternLayout.ActivateOptions();
            return patternLayout;
        }

        private static ConsoleAppender GetConsoleAppender()
        {
            var consoleAppender = new ConsoleAppender()
            { 
                Name = "ConsoleAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All
            };
            consoleAppender.ActivateOptions();
            return consoleAppender;
        }

        private static FileAppender GetFileAppender()
        {
            var fileAppender = new FileAppender()
            {
                Name = "FileAppender",
                File = "File.Log",
                Layout = GetPatternLayout(),
                Threshold = Level.All
            };
            fileAppender.ActivateOptions();
            return fileAppender;
        }

        private static RollingFileAppender GetRollingFileAppender()
        {
            var rollingFileAppender = new RollingFileAppender()
            {
                Name = "RollingFileAppender",
                AppendToFile = true,
                File = "..//..//Resources//Reports//RollingFile.Log",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                MaximumFileSize = "1MB",
                MaxSizeRollBackups = 15 //file1.log, file2.log.....file15.log
            };
            rollingFileAppender.ActivateOptions();
            return rollingFileAppender;
        }

        #endregion

        #region Public

        public static ILog GetLogger(Type type)
        {
            if (_consoleAppender == null)
                _consoleAppender = GetConsoleAppender();

            //if (_fileAppender == null)
            //    _fileAppender = GetFileAppender();

            //if (_rollingFileAppender == null)
            //    _rollingFileAppender = GetRollingFileAppender();

            if (_logger != null)
                return _logger;

            BasicConfigurator.Configure(_consoleAppender/*, _fileAppender, _rollingFileAppender*/);
            _logger = LogManager.GetLogger(type);
            return _logger;
        }


        #endregion
    }
}
