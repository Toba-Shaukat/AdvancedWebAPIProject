﻿using Microsoft.Extensions.Configuration;

namespace AdvancedWebAPIProject
{
    public class TestConfig : ITestConfig
    {
        private readonly IConfiguration _config;

        public TestConfig(IConfiguration config)
        {
            _config = config;
        }

        public string GetConnectionString()
        {
            return _config.GetConnectionString("AdvancedWebAPIProject");
        }
    }
}
