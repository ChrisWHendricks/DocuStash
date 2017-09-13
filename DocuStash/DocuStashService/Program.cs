using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DocuStashService
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Debugger.Launch();

			if (Environment.UserInteractive)
			{
				// run as console
				var service = new ServiceMain();
				service.StartServices();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("Document Stasher Service running in console mode...");
				var x = Console.ReadLine();

				Console.WriteLine("Shutting down...");
				Thread.Sleep(2000);
				service.StopServices();
			}
			else
			{
				// Run As Service
				using (var service = new ServiceMain())
				{
					ServiceBase.Run(service);
				}
			}
		}
	}
}
