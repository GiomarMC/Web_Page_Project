﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormularioDBP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCiudades", ReplyAction="http://tempuri.org/IService1/getCiudadesResponse")]
        string[] getCiudades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCiudades", ReplyAction="http://tempuri.org/IService1/getCiudadesResponse")]
        System.Threading.Tasks.Task<string[]> getCiudadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Information", ReplyAction="http://tempuri.org/IService1/InformationResponse")]
        void Information(string nombre, string apellido, string sexo, string email, string direccion, int ciudad, string requerimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Information", ReplyAction="http://tempuri.org/IService1/InformationResponse")]
        System.Threading.Tasks.Task InformationAsync(string nombre, string apellido, string sexo, string email, string direccion, int ciudad, string requerimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Existe_Registro", ReplyAction="http://tempuri.org/IService1/Existe_RegistroResponse")]
        bool Existe_Registro(string nombre, string apellidos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Existe_Registro", ReplyAction="http://tempuri.org/IService1/Existe_RegistroResponse")]
        System.Threading.Tasks.Task<bool> Existe_RegistroAsync(string nombre, string apellidos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FormularioDBP.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FormularioDBP.ServiceReference1.IService1>, FormularioDBP.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getCiudades() {
            return base.Channel.getCiudades();
        }
        
        public System.Threading.Tasks.Task<string[]> getCiudadesAsync() {
            return base.Channel.getCiudadesAsync();
        }
        
        public void Information(string nombre, string apellido, string sexo, string email, string direccion, int ciudad, string requerimiento) {
            base.Channel.Information(nombre, apellido, sexo, email, direccion, ciudad, requerimiento);
        }
        
        public System.Threading.Tasks.Task InformationAsync(string nombre, string apellido, string sexo, string email, string direccion, int ciudad, string requerimiento) {
            return base.Channel.InformationAsync(nombre, apellido, sexo, email, direccion, ciudad, requerimiento);
        }
        
        public bool Existe_Registro(string nombre, string apellidos) {
            return base.Channel.Existe_Registro(nombre, apellidos);
        }
        
        public System.Threading.Tasks.Task<bool> Existe_RegistroAsync(string nombre, string apellidos) {
            return base.Channel.Existe_RegistroAsync(nombre, apellidos);
        }
    }
}
