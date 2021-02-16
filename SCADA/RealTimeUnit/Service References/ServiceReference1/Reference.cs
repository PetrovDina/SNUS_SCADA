﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealTimeUnit.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRealTime")]
    public interface IRealTime {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealTime/sendValue", ReplyAction="http://tempuri.org/IRealTime/sendValueResponse")]
        void sendValue(int address, double value, byte[] signature);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealTime/sendValue", ReplyAction="http://tempuri.org/IRealTime/sendValueResponse")]
        System.Threading.Tasks.Task sendValueAsync(int address, double value, byte[] signature);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealTime/register", ReplyAction="http://tempuri.org/IRealTime/registerResponse")]
        bool register(int address, string publicKeyPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealTime/register", ReplyAction="http://tempuri.org/IRealTime/registerResponse")]
        System.Threading.Tasks.Task<bool> registerAsync(int address, string publicKeyPath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRealTimeChannel : RealTimeUnit.ServiceReference1.IRealTime, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RealTimeClient : System.ServiceModel.ClientBase<RealTimeUnit.ServiceReference1.IRealTime>, RealTimeUnit.ServiceReference1.IRealTime {
        
        public RealTimeClient() {
        }
        
        public RealTimeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RealTimeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealTimeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealTimeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void sendValue(int address, double value, byte[] signature) {
            base.Channel.sendValue(address, value, signature);
        }
        
        public System.Threading.Tasks.Task sendValueAsync(int address, double value, byte[] signature) {
            return base.Channel.sendValueAsync(address, value, signature);
        }
        
        public bool register(int address, string publicKeyPath) {
            return base.Channel.register(address, publicKeyPath);
        }
        
        public System.Threading.Tasks.Task<bool> registerAsync(int address, string publicKeyPath) {
            return base.Channel.registerAsync(address, publicKeyPath);
        }
    }
}