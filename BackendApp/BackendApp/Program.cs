using EasyNetQ;
using messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApp
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var bus = RabbitHutch.CreateBus("host=localhost"))
			{
				bus.Subscribe<TextMessage>("backend_App", HandleTextMessage);

				Console.WriteLine("Listening for messages. Hit <return> to quit.");
				Console.ReadLine();
			}
		}

		static void HandleTextMessage(TextMessage textMessage)
		{
			var url = "https://www.youtube.com/results?search_query=" + textMessage.Text;
			Process.Start("chrome.exe",url);
		}
	}
}
