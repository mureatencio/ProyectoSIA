﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaContable.ServicioAsientos {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/ServicioAsientos", ConfigurationName="ServicioAsientos.AsientosWSSoap")]
    public interface AsientosWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/ServicioAsientos/GuardarAsiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GuardarAsiento(System.Data.DataTable tabla, string compania, int numAsiento, string detalle);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AsientosWSSoapChannel : SistemaContable.ServicioAsientos.AsientosWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsientosWSSoapClient : System.ServiceModel.ClientBase<SistemaContable.ServicioAsientos.AsientosWSSoap>, SistemaContable.ServicioAsientos.AsientosWSSoap {
        
        public AsientosWSSoapClient() {
        }
        
        public AsientosWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsientosWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsientosWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsientosWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GuardarAsiento(System.Data.DataTable tabla, string compania, int numAsiento, string detalle) {
            base.Channel.GuardarAsiento(tabla, compania, numAsiento, detalle);
        }
    }
}
