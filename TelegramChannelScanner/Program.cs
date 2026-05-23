using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TL;
using WTelegram;
using Service;


namespace TelegramChannelScanner
{
	internal class Program
	{
		public static readonly ConfigService _configService = new ConfigService();

		static void Main(string[] args)
		{
			var config = _configService.ReturnConfigService("appsettings.json");

			string? token = config["Bot:Token"];
			if (token == null)
				return;

			var bot = new TelegramBotClient(token);
		}

	}
}
