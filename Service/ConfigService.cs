using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
	public class ConfigService
	{
		public IConfigurationRoot ReturnConfigService(string configFilePath) 
		{
			return new ConfigurationBuilder()
			.AddJsonFile(configFilePath)
			.Build();
		}
	}
}
