﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2Soft.ItinerarioWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.lp2myclinic/", ConfigurationName="ItinerarioWS.ItinerarioWS")]
    public interface ItinerarioWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/listarProgramaXMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/listarProgramaXMedicoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse listarProgramaXMedico(LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/listarProgramaXMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/listarProgramaXMedicoResponse")]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse> listarProgramaXMedicoAsync(LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/listarProgramaXFechaMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/listarProgramaXFechaMedicoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse listarProgramaXFechaMedico(LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/listarProgramaXFechaMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/listarProgramaXFechaMedicoResponse")]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse> listarProgramaXFechaMedicoAsync(LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/insertarListaHorariosPorMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/insertarListaHorariosPorMedicoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse insertarListaHorariosPorMedico(LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2myclinic/ItinerarioWS/insertarListaHorariosPorMedicoRequest", ReplyAction="http://services.lp2myclinic/ItinerarioWS/insertarListaHorariosPorMedicoResponse")]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse> insertarListaHorariosPorMedicoAsync(LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.lp2myclinic/")]
    public partial class programaAtencion : object, System.ComponentModel.INotifyPropertyChanged {
        
        private diaSemana diaSemanaField;
        
        private bool diaSemanaFieldSpecified;
        
        private System.DateTime fechaField;
        
        private bool fechaFieldSpecified;
        
        private string hora_finField;
        
        private string hora_inicioField;
        
        private int idMedicoField;
        
        private int idProgramaAtencionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public diaSemana diaSemana {
            get {
                return this.diaSemanaField;
            }
            set {
                this.diaSemanaField = value;
                this.RaisePropertyChanged("diaSemana");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool diaSemanaSpecified {
            get {
                return this.diaSemanaFieldSpecified;
            }
            set {
                this.diaSemanaFieldSpecified = value;
                this.RaisePropertyChanged("diaSemanaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaSpecified {
            get {
                return this.fechaFieldSpecified;
            }
            set {
                this.fechaFieldSpecified = value;
                this.RaisePropertyChanged("fechaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string hora_fin {
            get {
                return this.hora_finField;
            }
            set {
                this.hora_finField = value;
                this.RaisePropertyChanged("hora_fin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string hora_inicio {
            get {
                return this.hora_inicioField;
            }
            set {
                this.hora_inicioField = value;
                this.RaisePropertyChanged("hora_inicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idMedico {
            get {
                return this.idMedicoField;
            }
            set {
                this.idMedicoField = value;
                this.RaisePropertyChanged("idMedico");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int idProgramaAtencion {
            get {
                return this.idProgramaAtencionField;
            }
            set {
                this.idProgramaAtencionField = value;
                this.RaisePropertyChanged("idProgramaAtencion");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.lp2myclinic/")]
    public enum diaSemana {
        
        /// <remarks/>
        Lunes,
        
        /// <remarks/>
        Martes,
        
        /// <remarks/>
        Miercoles,
        
        /// <remarks/>
        Jueves,
        
        /// <remarks/>
        Viernes,
        
        /// <remarks/>
        Sabado,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProgramaXMedico", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class listarProgramaXMedicoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idMedico;
        
        public listarProgramaXMedicoRequest() {
        }
        
        public listarProgramaXMedicoRequest(int idMedico) {
            this.idMedico = idMedico;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProgramaXMedicoResponse", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class listarProgramaXMedicoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2Soft.ItinerarioWS.programaAtencion[] @return;
        
        public listarProgramaXMedicoResponse() {
        }
        
        public listarProgramaXMedicoResponse(LP2Soft.ItinerarioWS.programaAtencion[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProgramaXFechaMedico", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class listarProgramaXFechaMedicoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idMedico;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fecha;
        
        public listarProgramaXFechaMedicoRequest() {
        }
        
        public listarProgramaXFechaMedicoRequest(int idMedico, System.DateTime fecha) {
            this.idMedico = idMedico;
            this.fecha = fecha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProgramaXFechaMedicoResponse", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class listarProgramaXFechaMedicoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2Soft.ItinerarioWS.programaAtencion[] @return;
        
        public listarProgramaXFechaMedicoResponse() {
        }
        
        public listarProgramaXFechaMedicoResponse(LP2Soft.ItinerarioWS.programaAtencion[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarListaHorariosPorMedico", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class insertarListaHorariosPorMedicoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2Soft.ItinerarioWS.programaAtencion arg0;
        
        public insertarListaHorariosPorMedicoRequest() {
        }
        
        public insertarListaHorariosPorMedicoRequest(LP2Soft.ItinerarioWS.programaAtencion arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarListaHorariosPorMedicoResponse", WrapperNamespace="http://services.lp2myclinic/", IsWrapped=true)]
    public partial class insertarListaHorariosPorMedicoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.lp2myclinic/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarListaHorariosPorMedicoResponse() {
        }
        
        public insertarListaHorariosPorMedicoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ItinerarioWSChannel : LP2Soft.ItinerarioWS.ItinerarioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItinerarioWSClient : System.ServiceModel.ClientBase<LP2Soft.ItinerarioWS.ItinerarioWS>, LP2Soft.ItinerarioWS.ItinerarioWS {
        
        public ItinerarioWSClient() {
        }
        
        public ItinerarioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItinerarioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItinerarioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItinerarioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse LP2Soft.ItinerarioWS.ItinerarioWS.listarProgramaXMedico(LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest request) {
            return base.Channel.listarProgramaXMedico(request);
        }
        
        public LP2Soft.ItinerarioWS.programaAtencion[] listarProgramaXMedico(int idMedico) {
            LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest inValue = new LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest();
            inValue.idMedico = idMedico;
            LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse retVal = ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).listarProgramaXMedico(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse> LP2Soft.ItinerarioWS.ItinerarioWS.listarProgramaXMedicoAsync(LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest request) {
            return base.Channel.listarProgramaXMedicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXMedicoResponse> listarProgramaXMedicoAsync(int idMedico) {
            LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest inValue = new LP2Soft.ItinerarioWS.listarProgramaXMedicoRequest();
            inValue.idMedico = idMedico;
            return ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).listarProgramaXMedicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse LP2Soft.ItinerarioWS.ItinerarioWS.listarProgramaXFechaMedico(LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest request) {
            return base.Channel.listarProgramaXFechaMedico(request);
        }
        
        public LP2Soft.ItinerarioWS.programaAtencion[] listarProgramaXFechaMedico(int idMedico, System.DateTime fecha) {
            LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest inValue = new LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest();
            inValue.idMedico = idMedico;
            inValue.fecha = fecha;
            LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse retVal = ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).listarProgramaXFechaMedico(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse> LP2Soft.ItinerarioWS.ItinerarioWS.listarProgramaXFechaMedicoAsync(LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest request) {
            return base.Channel.listarProgramaXFechaMedicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoResponse> listarProgramaXFechaMedicoAsync(int idMedico, System.DateTime fecha) {
            LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest inValue = new LP2Soft.ItinerarioWS.listarProgramaXFechaMedicoRequest();
            inValue.idMedico = idMedico;
            inValue.fecha = fecha;
            return ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).listarProgramaXFechaMedicoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse LP2Soft.ItinerarioWS.ItinerarioWS.insertarListaHorariosPorMedico(LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest request) {
            return base.Channel.insertarListaHorariosPorMedico(request);
        }
        
        public int insertarListaHorariosPorMedico(LP2Soft.ItinerarioWS.programaAtencion arg0) {
            LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest inValue = new LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest();
            inValue.arg0 = arg0;
            LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse retVal = ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).insertarListaHorariosPorMedico(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse> LP2Soft.ItinerarioWS.ItinerarioWS.insertarListaHorariosPorMedicoAsync(LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest request) {
            return base.Channel.insertarListaHorariosPorMedicoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoResponse> insertarListaHorariosPorMedicoAsync(LP2Soft.ItinerarioWS.programaAtencion arg0) {
            LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest inValue = new LP2Soft.ItinerarioWS.insertarListaHorariosPorMedicoRequest();
            inValue.arg0 = arg0;
            return ((LP2Soft.ItinerarioWS.ItinerarioWS)(this)).insertarListaHorariosPorMedicoAsync(inValue);
        }
    }
}