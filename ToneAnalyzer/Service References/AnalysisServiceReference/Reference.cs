﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToneAnalyzer.AnalysisServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailAnalysis", Namespace="http://schemas.datacontract.org/2004/07/ToneReader")]
    [System.SerializableAttribute()]
    public partial struct EmailAnalysis : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.BodyAnalysis BodyResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.SentenceAnalysis[] SentenceResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.BodyAnalysis BodyResult {
            get {
                return this.BodyResultField;
            }
            set {
                if ((this.BodyResultField.Equals(value) != true)) {
                    this.BodyResultField = value;
                    this.RaisePropertyChanged("BodyResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.SentenceAnalysis[] SentenceResult {
            get {
                return this.SentenceResultField;
            }
            set {
                if ((object.ReferenceEquals(this.SentenceResultField, value) != true)) {
                    this.SentenceResultField = value;
                    this.RaisePropertyChanged("SentenceResult");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="EmailAnalysis.BodyAnalysis", Namespace="http://schemas.datacontract.org/2004/07/ToneReader")]
        [System.SerializableAttribute()]
        public partial struct BodyAnalysis : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.CategoryAnalysis[] CategoryAnalysesField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.CategoryAnalysis[] CategoryAnalyses {
                get {
                    return this.CategoryAnalysesField;
                }
                set {
                    if ((object.ReferenceEquals(this.CategoryAnalysesField, value) != true)) {
                        this.CategoryAnalysesField = value;
                        this.RaisePropertyChanged("CategoryAnalyses");
                    }
                }
            }
            
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            
            void RaisePropertyChanged(string propertyName) {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null)) {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="EmailAnalysis.SentenceAnalysis", Namespace="http://schemas.datacontract.org/2004/07/ToneReader")]
        [System.SerializableAttribute()]
        public partial struct SentenceAnalysis : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.CategoryAnalysis[] CategoryAnalysesField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int InputFromField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int InputToField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int SentenceIdField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string TextField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.CategoryAnalysis[] CategoryAnalyses {
                get {
                    return this.CategoryAnalysesField;
                }
                set {
                    if ((object.ReferenceEquals(this.CategoryAnalysesField, value) != true)) {
                        this.CategoryAnalysesField = value;
                        this.RaisePropertyChanged("CategoryAnalyses");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public int InputFrom {
                get {
                    return this.InputFromField;
                }
                set {
                    if ((this.InputFromField.Equals(value) != true)) {
                        this.InputFromField = value;
                        this.RaisePropertyChanged("InputFrom");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public int InputTo {
                get {
                    return this.InputToField;
                }
                set {
                    if ((this.InputToField.Equals(value) != true)) {
                        this.InputToField = value;
                        this.RaisePropertyChanged("InputTo");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public int SentenceId {
                get {
                    return this.SentenceIdField;
                }
                set {
                    if ((this.SentenceIdField.Equals(value) != true)) {
                        this.SentenceIdField = value;
                        this.RaisePropertyChanged("SentenceId");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Text {
                get {
                    return this.TextField;
                }
                set {
                    if ((object.ReferenceEquals(this.TextField, value) != true)) {
                        this.TextField = value;
                        this.RaisePropertyChanged("Text");
                    }
                }
            }
            
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            
            void RaisePropertyChanged(string propertyName) {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null)) {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="EmailAnalysis.CategoryAnalysis", Namespace="http://schemas.datacontract.org/2004/07/ToneReader")]
        [System.SerializableAttribute()]
        public partial struct CategoryAnalysis : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string CategoryIdField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string CategoryNameField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.Tone[] TonesField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string CategoryId {
                get {
                    return this.CategoryIdField;
                }
                set {
                    if ((object.ReferenceEquals(this.CategoryIdField, value) != true)) {
                        this.CategoryIdField = value;
                        this.RaisePropertyChanged("CategoryId");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string CategoryName {
                get {
                    return this.CategoryNameField;
                }
                set {
                    if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                        this.CategoryNameField = value;
                        this.RaisePropertyChanged("CategoryName");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis.Tone[] Tones {
                get {
                    return this.TonesField;
                }
                set {
                    if ((object.ReferenceEquals(this.TonesField, value) != true)) {
                        this.TonesField = value;
                        this.RaisePropertyChanged("Tones");
                    }
                }
            }
            
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            
            void RaisePropertyChanged(string propertyName) {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null)) {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="EmailAnalysis.Tone", Namespace="http://schemas.datacontract.org/2004/07/ToneReader")]
        [System.SerializableAttribute()]
        public partial struct Tone : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private double ScoreField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string ToneIdField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string ToneNameField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public double Score {
                get {
                    return this.ScoreField;
                }
                set {
                    if ((this.ScoreField.Equals(value) != true)) {
                        this.ScoreField = value;
                        this.RaisePropertyChanged("Score");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ToneId {
                get {
                    return this.ToneIdField;
                }
                set {
                    if ((object.ReferenceEquals(this.ToneIdField, value) != true)) {
                        this.ToneIdField = value;
                        this.RaisePropertyChanged("ToneId");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ToneName {
                get {
                    return this.ToneNameField;
                }
                set {
                    if ((object.ReferenceEquals(this.ToneNameField, value) != true)) {
                        this.ToneNameField = value;
                        this.RaisePropertyChanged("ToneName");
                    }
                }
            }
            
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            
            void RaisePropertyChanged(string propertyName) {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null)) {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AnalysisServiceReference.ITonalAnalysisService")]
    public interface ITonalAnalysisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonalAnalysisService/GetAnalysis", ReplyAction="http://tempuri.org/ITonalAnalysisService/GetAnalysisResponse")]
        ToneAnalyzer.AnalysisServiceReference.EmailAnalysis GetAnalysis(string email, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonalAnalysisService/GetAnalysis", ReplyAction="http://tempuri.org/ITonalAnalysisService/GetAnalysisResponse")]
        System.Threading.Tasks.Task<ToneAnalyzer.AnalysisServiceReference.EmailAnalysis> GetAnalysisAsync(string email, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITonalAnalysisServiceChannel : ToneAnalyzer.AnalysisServiceReference.ITonalAnalysisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TonalAnalysisServiceClient : System.ServiceModel.ClientBase<ToneAnalyzer.AnalysisServiceReference.ITonalAnalysisService>, ToneAnalyzer.AnalysisServiceReference.ITonalAnalysisService {
        
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
        
        public ToneAnalyzer.AnalysisServiceReference.EmailAnalysis GetAnalysis(string email, string text) {
            return base.Channel.GetAnalysis(email, text);
        }
        
        public System.Threading.Tasks.Task<ToneAnalyzer.AnalysisServiceReference.EmailAnalysis> GetAnalysisAsync(string email, string text) {
            return base.Channel.GetAnalysisAsync(email, text);
        }
    }
}
