//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapCoreReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyCustomModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class MyCustomModel : object
    {
        
        private string EmailField;
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapCoreReference.ISampleService")]
    public interface ISampleService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/Test", ReplyAction="http://tempuri.org/ISampleService/TestResponse")]
        System.Threading.Tasks.Task<string> TestAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/XmlMethod", ReplyAction="http://tempuri.org/ISampleService/XmlMethodResponse")]
        System.Threading.Tasks.Task XmlMethodAsync(System.Xml.XmlElement xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/TestCustomModel", ReplyAction="http://tempuri.org/ISampleService/TestCustomModelResponse")]
        System.Threading.Tasks.Task<SoapCoreReference.MyCustomModel> TestCustomModelAsync(SoapCoreReference.MyCustomModel inputModel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface ISampleServiceChannel : SoapCoreReference.ISampleService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<SoapCoreReference.ISampleService>, SoapCoreReference.ISampleService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SampleServiceClient() : 
                base(SampleServiceClient.GetDefaultBinding(), SampleServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISampleService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), SampleServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> TestAsync(string s)
        {
            return base.Channel.TestAsync(s);
        }
        
        public System.Threading.Tasks.Task XmlMethodAsync(System.Xml.XmlElement xml)
        {
            return base.Channel.XmlMethodAsync(xml);
        }
        
        public System.Threading.Tasks.Task<SoapCoreReference.MyCustomModel> TestCustomModelAsync(SoapCoreReference.MyCustomModel inputModel)
        {
            return base.Channel.TestCustomModelAsync(inputModel);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleService))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44367/Service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SampleServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISampleService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SampleServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISampleService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISampleService,
        }
    }
}
