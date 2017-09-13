﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocuMon.DocumentListenerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DocumentListenerService.IDocumentListener")]
    public interface IDocumentListener {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentListener/ExportDocument", ReplyAction="http://tempuri.org/IDocumentListener/ExportDocumentResponse")]
        string ExportDocument(string filePath, string configurationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentListener/ExportDocument", ReplyAction="http://tempuri.org/IDocumentListener/ExportDocumentResponse")]
        System.Threading.Tasks.Task<string> ExportDocumentAsync(string filePath, string configurationId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentListenerChannel : DocuMon.DocumentListenerService.IDocumentListener, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentListenerClient : System.ServiceModel.ClientBase<DocuMon.DocumentListenerService.IDocumentListener>, DocuMon.DocumentListenerService.IDocumentListener {
        
        public DocumentListenerClient() {
        }
        
        public DocumentListenerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentListenerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentListenerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentListenerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ExportDocument(string filePath, string configurationId) {
            return base.Channel.ExportDocument(filePath, configurationId);
        }
        
        public System.Threading.Tasks.Task<string> ExportDocumentAsync(string filePath, string configurationId) {
            return base.Channel.ExportDocumentAsync(filePath, configurationId);
        }
    }
}