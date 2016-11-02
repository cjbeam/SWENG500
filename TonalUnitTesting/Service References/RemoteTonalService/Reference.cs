﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TonalUnitTesting.RemoteTonalService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteTonalService.ITonalAnalysisService")]
    public interface ITonalAnalysisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonalAnalysisService/GetAnalysis", ReplyAction="http://tempuri.org/ITonalAnalysisService/GetAnalysisResponse")]
        string GetAnalysis(string email, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonalAnalysisService/GetAnalysis", ReplyAction="http://tempuri.org/ITonalAnalysisService/GetAnalysisResponse")]
        System.Threading.Tasks.Task<string> GetAnalysisAsync(string email, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITonalAnalysisServiceChannel : TonalUnitTesting.RemoteTonalService.ITonalAnalysisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TonalAnalysisServiceClient : System.ServiceModel.ClientBase<TonalUnitTesting.RemoteTonalService.ITonalAnalysisService>, TonalUnitTesting.RemoteTonalService.ITonalAnalysisService {
        
        public TonalAnalysisServiceClient() {
        }
        
        public TonalAnalysisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TonalAnalysisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonalAnalysisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonalAnalysisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAnalysis(string email, string text) {
            return base.Channel.GetAnalysis(email, text);
        }
        
        public System.Threading.Tasks.Task<string> GetAnalysisAsync(string email, string text) {
            return base.Channel.GetAnalysisAsync(email, text);
        }
    }
}
