﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_MVC.ServicioMaestria {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/ServicioMaestria.Models")]
    [System.SerializableAttribute()]
    public partial class Alumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApematField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApepatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string No_controlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Apemat {
            get {
                return this.ApematField;
            }
            set {
                if ((object.ReferenceEquals(this.ApematField, value) != true)) {
                    this.ApematField = value;
                    this.RaisePropertyChanged("Apemat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apepat {
            get {
                return this.ApepatField;
            }
            set {
                if ((object.ReferenceEquals(this.ApepatField, value) != true)) {
                    this.ApepatField = value;
                    this.RaisePropertyChanged("Apepat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string No_control {
            get {
                return this.No_controlField;
            }
            set {
                if ((object.ReferenceEquals(this.No_controlField, value) != true)) {
                    this.No_controlField = value;
                    this.RaisePropertyChanged("No_control");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioMaestria.IAlumnosService")]
    public interface IAlumnosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Actualizar", ReplyAction="http://tempuri.org/IAlumnosService/ActualizarResponse")]
        bool Actualizar(string nc, string ap, string am, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Actualizar", ReplyAction="http://tempuri.org/IAlumnosService/ActualizarResponse")]
        System.Threading.Tasks.Task<bool> ActualizarAsync(string nc, string ap, string am, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Agregar", ReplyAction="http://tempuri.org/IAlumnosService/AgregarResponse")]
        bool Agregar(string nc, string ap, string am, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Agregar", ReplyAction="http://tempuri.org/IAlumnosService/AgregarResponse")]
        System.Threading.Tasks.Task<bool> AgregarAsync(string nc, string ap, string am, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/BuscarxNC", ReplyAction="http://tempuri.org/IAlumnosService/BuscarxNCResponse")]
        Cliente_MVC.ServicioMaestria.Alumno BuscarxNC(string nc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/BuscarxNC", ReplyAction="http://tempuri.org/IAlumnosService/BuscarxNCResponse")]
        System.Threading.Tasks.Task<Cliente_MVC.ServicioMaestria.Alumno> BuscarxNCAsync(string nc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Consultar", ReplyAction="http://tempuri.org/IAlumnosService/ConsultarResponse")]
        Cliente_MVC.ServicioMaestria.Alumno[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Consultar", ReplyAction="http://tempuri.org/IAlumnosService/ConsultarResponse")]
        System.Threading.Tasks.Task<Cliente_MVC.ServicioMaestria.Alumno[]> ConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Eliminar", ReplyAction="http://tempuri.org/IAlumnosService/EliminarResponse")]
        bool Eliminar(string nc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/Eliminar", ReplyAction="http://tempuri.org/IAlumnosService/EliminarResponse")]
        System.Threading.Tasks.Task<bool> EliminarAsync(string nc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlumnosServiceChannel : Cliente_MVC.ServicioMaestria.IAlumnosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnosServiceClient : System.ServiceModel.ClientBase<Cliente_MVC.ServicioMaestria.IAlumnosService>, Cliente_MVC.ServicioMaestria.IAlumnosService {
        
        public AlumnosServiceClient() {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Actualizar(string nc, string ap, string am, string nom) {
            return base.Channel.Actualizar(nc, ap, am, nom);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarAsync(string nc, string ap, string am, string nom) {
            return base.Channel.ActualizarAsync(nc, ap, am, nom);
        }
        
        public bool Agregar(string nc, string ap, string am, string nom) {
            return base.Channel.Agregar(nc, ap, am, nom);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarAsync(string nc, string ap, string am, string nom) {
            return base.Channel.AgregarAsync(nc, ap, am, nom);
        }
        
        public Cliente_MVC.ServicioMaestria.Alumno BuscarxNC(string nc) {
            return base.Channel.BuscarxNC(nc);
        }
        
        public System.Threading.Tasks.Task<Cliente_MVC.ServicioMaestria.Alumno> BuscarxNCAsync(string nc) {
            return base.Channel.BuscarxNCAsync(nc);
        }
        
        public Cliente_MVC.ServicioMaestria.Alumno[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<Cliente_MVC.ServicioMaestria.Alumno[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
        
        public bool Eliminar(string nc) {
            return base.Channel.Eliminar(nc);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(string nc) {
            return base.Channel.EliminarAsync(nc);
        }
    }
}