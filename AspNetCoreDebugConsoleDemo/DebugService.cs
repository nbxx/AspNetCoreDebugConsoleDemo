using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AspNetCoreDebugConsoleDemo
{
    public class DebugService
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;

        public DebugService(
            ILogger<DebugService> logger, // inject ILogger
            IConfiguration configuration  // inject IConfiguration
            )
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void Start()
        {
            Console.WriteLine("Start debug...");

            // debug code

            Console.ReadLine();
        }
    }
}
