using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChrisWHendricks.DocuStash.DocuStashService.DocumentListeners
{
	[ServiceContract]
	public interface IDocumentListener
	{
		[OperationContract]
		string ExportDocument(string filePath, string configurationId);
	}
}
