using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ravi.learn.flogging.core
{
    public static class Flogger
    {
        private static readonly ILogger _perfLogger;
        private static readonly ILogger _usageLogger;
        private static readonly ILogger _errorLogger;
        private static readonly ILogger _diagnosticLogger;

        static Flogger()
        {
            _perfLogger = new LoggerConfiguration()
                .WriteTo.File(path: "d:\\temp\\logs\\perf.log")
                .CreateLogger();
            _usageLogger = new LoggerConfiguration()
                .WriteTo.File(path: "d:\\temp\\logs\\perf.log")
                .CreateLogger();
            _errorLogger = new LoggerConfiguration()
                .WriteTo.File(path: "d:\\temp\\logs\\perf.log")
                .CreateLogger();
            _diagnosticLogger = new LoggerConfiguration()
                .WriteTo.File(path: "d:\\temp\\logs\\perf.log")
                .CreateLogger();
        }
    }
}
