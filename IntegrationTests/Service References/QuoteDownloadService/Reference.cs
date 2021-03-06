﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntegrationTests.QuoteDownloadService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyDto", Namespace="http://schemas.datacontract.org/2004/07/ScreenerDto")]
    [System.SerializableAttribute()]
    public partial class CompanyDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntegrationTests.QuoteDownloadService.CandleDto[] ChartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntegrationTests.QuoteDownloadService.CandleDto[] Chart {
            get {
                return this.ChartField;
            }
            set {
                if ((object.ReferenceEquals(this.ChartField, value) != true)) {
                    this.ChartField = value;
                    this.RaisePropertyChanged("Chart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CandleDto", Namespace="http://schemas.datacontract.org/2004/07/ScreenerDto")]
    [System.SerializableAttribute()]
    public partial class CandleDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CloseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HighField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal OpenField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Close {
            get {
                return this.CloseField;
            }
            set {
                if ((this.CloseField.Equals(value) != true)) {
                    this.CloseField = value;
                    this.RaisePropertyChanged("Close");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal High {
            get {
                return this.HighField;
            }
            set {
                if ((this.HighField.Equals(value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Low {
            get {
                return this.LowField;
            }
            set {
                if ((this.LowField.Equals(value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Open {
            get {
                return this.OpenField;
            }
            set {
                if ((this.OpenField.Equals(value) != true)) {
                    this.OpenField = value;
                    this.RaisePropertyChanged("Open");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuoteDownloadService.IQuoteDownloadService")]
    public interface IQuoteDownloadService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuoteDownloadService/Echo", ReplyAction="http://tempuri.org/IQuoteDownloadService/EchoResponse")]
        string Echo(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuoteDownloadService/Echo", ReplyAction="http://tempuri.org/IQuoteDownloadService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuoteDownloadService/GetCompanies", ReplyAction="http://tempuri.org/IQuoteDownloadService/GetCompaniesResponse")]
        IntegrationTests.QuoteDownloadService.CompanyDto[] GetCompanies(string[] tickers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuoteDownloadService/GetCompanies", ReplyAction="http://tempuri.org/IQuoteDownloadService/GetCompaniesResponse")]
        System.Threading.Tasks.Task<IntegrationTests.QuoteDownloadService.CompanyDto[]> GetCompaniesAsync(string[] tickers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuoteDownloadServiceChannel : IntegrationTests.QuoteDownloadService.IQuoteDownloadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuoteDownloadServiceClient : System.ServiceModel.ClientBase<IntegrationTests.QuoteDownloadService.IQuoteDownloadService>, IntegrationTests.QuoteDownloadService.IQuoteDownloadService {
        
        public QuoteDownloadServiceClient() {
        }
        
        public QuoteDownloadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuoteDownloadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuoteDownloadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuoteDownloadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(string message) {
            return base.Channel.Echo(message);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string message) {
            return base.Channel.EchoAsync(message);
        }
        
        public IntegrationTests.QuoteDownloadService.CompanyDto[] GetCompanies(string[] tickers) {
            return base.Channel.GetCompanies(tickers);
        }
        
        public System.Threading.Tasks.Task<IntegrationTests.QuoteDownloadService.CompanyDto[]> GetCompaniesAsync(string[] tickers) {
            return base.Channel.GetCompaniesAsync(tickers);
        }
    }
}
