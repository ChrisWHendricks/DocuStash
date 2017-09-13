using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WcfDocumentListener = ChrisWHendricks.DocuStash.DocuStashService.DocumentListeners.Wcf;

namespace DocuStashService
{
	partial class ServiceMain : ServiceBase
	{
		internal static ServiceHost _serviceHost = null;

		public ServiceMain()
		{
			InitializeComponent();
		}

		public void StartServices()
		{
			// start wcf service
			StartWcfServices();

			// ToDo: Future Add Additional providers (TCP, Named Pipe, File Monitor, etc...)

			
		}

		public void StopServices()
		{
			// stop WCF Services
			StopWcfServices();
		}

		protected override void OnStart(string[] args)
		{
			
		}

		protected override void OnStop()
		{
			
		}

		private void StartWcfServices()
		{
			if (_serviceHost != null)
			{
				_serviceHost.Close();
			}

			_serviceHost = new ServiceHost(typeof(WcfDocumentListener.DocumentListener));
			_serviceHost.Open();
		}

		private void StopWcfServices()
		{
			if (_serviceHost != null)
			{
				_serviceHost.Close();
				_serviceHost = null;
			}
		}
	}
}
