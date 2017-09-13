using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisWHendricks.DocuStash.DocuStashService.DocumentListeners.Wcf
{
	public class DocumentListener : IDocumentListener
	{
		public string ExportDocument(string filePath, string configurationId)
		{
			return "Export Failed";
		}
	}
}
