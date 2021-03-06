using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace BotGUI
{
    public class Setup
    {

        private IConfigurationRoot _config;

        public void setup()
        {
            var configurationBuilder = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json", false, true);

            var configuration = configurationBuilder.Build();
            _config = configuration;
        }

        public IConfigurationRoot getConfig()
        {
            if (_config == null)
            {
                _config = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json", false, true)
                            .Build();
            }
            return _config;
        }
    }
}
