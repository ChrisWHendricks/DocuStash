using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuMon
{
	class Program
	{
		static void Main(string[] args)
		{

			// todo: Should this be a windows or a console app?  
			// maybe make this a winforms app and just display a logger and some sort of stats (Last Scan Received, etc...)

			// Testing Connection To Windows WCF Service
			var client = new DocumentListenerService.DocumentListenerClient();
			var result = client.ExportDocument("FilePath", "ConfigID");



		}
	}
}
