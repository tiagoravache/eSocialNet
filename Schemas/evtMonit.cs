// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public partial class SignatureType {
        
        private SignedInfoType signedInfoField;
        
        private SignatureValueType signatureValueField;
        
        private KeyInfoType keyInfoField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
            }
        }
        
        /// <remarks/>
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
            }
        }
        
        /// <remarks/>
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType {
        
        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;
        
        private SignedInfoTypeSignatureMethod signatureMethodField;
        
        private ReferenceType referenceField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }
        
        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceType Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeCanonicalizationMethod() {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class TCrm {
        
        private string nrCRMField;
        
        private string ufCRMField;
        
        /// <remarks/>
        public string nrCRM {
            get {
                return this.nrCRMField;
            }
            set {
                this.nrCRMField = value;
            }
        }
        
        /// <remarks/>
        public string ufCRM {
            get {
                return this.ufCRMField;
            }
            set {
                this.ufCRMField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class TMedico {
        
        private string nmMedField;
        
        private TCrm crmField;
        
        /// <remarks/>
        public string nmMed {
            get {
                return this.nmMedField;
            }
            set {
                this.nmMedField = value;
            }
        }
        
        /// <remarks/>
        public TCrm crm {
            get {
                return this.crmField;
            }
            set {
                this.crmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class TIdeVinculoEstag {
        
        private string cpfTrabField;
        
        private string nisTrabField;
        
        private string matriculaField;
        
        /// <remarks/>
        public string cpfTrab {
            get {
                return this.cpfTrabField;
            }
            set {
                this.cpfTrabField = value;
            }
        }
        
        /// <remarks/>
        public string nisTrab {
            get {
                return this.nisTrabField;
            }
            set {
                this.nisTrabField = value;
            }
        }
        
        /// <remarks/>
        public string matricula {
            get {
                return this.matriculaField;
            }
            set {
                this.matriculaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class TEmpregador {
        
        private sbyte tpInscField;
        
        private string nrInscField;
        
        /// <remarks/>
        public sbyte tpInsc {
            get {
                return this.tpInscField;
            }
            set {
                this.tpInscField = value;
            }
        }
        
        /// <remarks/>
        public string nrInsc {
            get {
                return this.nrInscField;
            }
            set {
                this.nrInscField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class TIdeEveTrab {
        
        private sbyte indRetifField;
        
        private string nrReciboField;
        
        private sbyte tpAmbField;
        
        private sbyte procEmiField;
        
        private string verProcField;
        
        /// <remarks/>
        public sbyte indRetif {
            get {
                return this.indRetifField;
            }
            set {
                this.indRetifField = value;
            }
        }
        
        /// <remarks/>
        public string nrRecibo {
            get {
                return this.nrReciboField;
            }
            set {
                this.nrReciboField = value;
            }
        }
        
        /// <remarks/>
        public sbyte tpAmb {
            get {
                return this.tpAmbField;
            }
            set {
                this.tpAmbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte procEmi {
            get {
                return this.procEmiField;
            }
            set {
                this.procEmiField = value;
            }
        }
        
        /// <remarks/>
        public string verProc {
            get {
                return this.verProcField;
            }
            set {
                this.verProcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType {
        
        private byte[] x509CertificateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] X509Certificate {
            get {
                return this.x509CertificateField;
            }
            set {
                this.x509CertificateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType {
        
        private X509DataType x509DataField;
        
        private string idField;
        
        /// <remarks/>
        public X509DataType X509Data {
            get {
                return this.x509DataField;
            }
            set {
                this.x509DataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType {
        
        private string idField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType {
        
        private string[] xPathField;
        
        private TTransformURI algorithmField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath {
            get {
                return this.xPathField;
            }
            set {
                this.xPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType {
        
        private TransformType[] transformsField;
        
        private ReferenceTypeDigestMethod digestMethodField;
        
        private byte[] digestValueField;
        
        private string idField;
        
        private string uRIField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public TransformType[] Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod {
        
        private string algorithmField;
        
        public ReferenceTypeDigestMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeSignatureMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00", IsNullable=false)]
    public partial class eSocial {
        
        private eSocialEvtMonit evtMonitField;
        
        private SignatureType signatureField;
        
        /// <remarks/>
        public eSocialEvtMonit evtMonit {
            get {
                return this.evtMonitField;
            }
            set {
                this.evtMonitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonit {
        
        private TIdeEveTrab ideEventoField;
        
        private TEmpregador ideEmpregadorField;
        
        private TIdeVinculoEstag ideVinculoField;
        
        private eSocialEvtMonitAso asoField;
        
        private string idField;
        
        /// <remarks/>
        public TIdeEveTrab ideEvento {
            get {
                return this.ideEventoField;
            }
            set {
                this.ideEventoField = value;
            }
        }
        
        /// <remarks/>
        public TEmpregador ideEmpregador {
            get {
                return this.ideEmpregadorField;
            }
            set {
                this.ideEmpregadorField = value;
            }
        }
        
        /// <remarks/>
        public TIdeVinculoEstag ideVinculo {
            get {
                return this.ideVinculoField;
            }
            set {
                this.ideVinculoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtMonitAso aso {
            get {
                return this.asoField;
            }
            set {
                this.asoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAso {
        
        private System.DateTime dtAsoField;
        
        private sbyte tpAsoField;
        
        private sbyte resAsoField;
        
        private eSocialEvtMonitAsoExame[] exameField;
        
        private eSocialEvtMonitAsoMonitBiolog monitBiologField;
        
        private eSocialEvtMonitAsoIdeServSaude ideServSaudeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtAso {
            get {
                return this.dtAsoField;
            }
            set {
                this.dtAsoField = value;
            }
        }
        
        /// <remarks/>
        public sbyte tpAso {
            get {
                return this.tpAsoField;
            }
            set {
                this.tpAsoField = value;
            }
        }
        
        /// <remarks/>
        public sbyte resAso {
            get {
                return this.resAsoField;
            }
            set {
                this.resAsoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("exame")]
        public eSocialEvtMonitAsoExame[] exame {
            get {
                return this.exameField;
            }
            set {
                this.exameField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtMonitAsoMonitBiolog monitBiolog {
            get {
                return this.monitBiologField;
            }
            set {
                this.monitBiologField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtMonitAsoIdeServSaude ideServSaude {
            get {
                return this.ideServSaudeField;
            }
            set {
                this.ideServSaudeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAsoExame {
        
        private System.DateTime dtExmField;
        
        private string procRealizadoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtExm {
            get {
                return this.dtExmField;
            }
            set {
                this.dtExmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string procRealizado {
            get {
                return this.procRealizadoField;
            }
            set {
                this.procRealizadoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAsoMonitBiolog {
        
        private eSocialEvtMonitAsoMonitBiologResultMonit[] resultMonitField;
        
        private eSocialEvtMonitAsoMonitBiologRespMonit respMonitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resultMonit")]
        public eSocialEvtMonitAsoMonitBiologResultMonit[] resultMonit {
            get {
                return this.resultMonitField;
            }
            set {
                this.resultMonitField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtMonitAsoMonitBiologRespMonit respMonit {
            get {
                return this.respMonitField;
            }
            set {
                this.respMonitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAsoMonitBiologResultMonit {
        
        private string codAgntQuimField;
        
        private sbyte matBiologField;
        
        private string codAnaliseField;
        
        private sbyte interprExmField;
        
        private sbyte ordExameField;
        
        private System.DateTime dtIniMonitField;
        
        private System.DateTime dtFimMonitField;
        
        private bool dtFimMonitFieldSpecified;
        
        private sbyte indResultField;
        
        private bool indResultFieldSpecified;
        
        /// <remarks/>
        public string codAgntQuim {
            get {
                return this.codAgntQuimField;
            }
            set {
                this.codAgntQuimField = value;
            }
        }
        
        /// <remarks/>
        public sbyte matBiolog {
            get {
                return this.matBiologField;
            }
            set {
                this.matBiologField = value;
            }
        }
        
        /// <remarks/>
        public string codAnalise {
            get {
                return this.codAnaliseField;
            }
            set {
                this.codAnaliseField = value;
            }
        }
        
        /// <remarks/>
        public sbyte interprExm {
            get {
                return this.interprExmField;
            }
            set {
                this.interprExmField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ordExame {
            get {
                return this.ordExameField;
            }
            set {
                this.ordExameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtIniMonit {
            get {
                return this.dtIniMonitField;
            }
            set {
                this.dtIniMonitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtFimMonit {
            get {
                return this.dtFimMonitField;
            }
            set {
                this.dtFimMonitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtFimMonitSpecified {
            get {
                return this.dtFimMonitFieldSpecified;
            }
            set {
                this.dtFimMonitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public sbyte indResult {
            get {
                return this.indResultField;
            }
            set {
                this.indResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indResultSpecified {
            get {
                return this.indResultFieldSpecified;
            }
            set {
                this.indResultFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAsoMonitBiologRespMonit {
        
        private string nisRespField;
        
        private string nrConsClasseField;
        
        private string ufConsClasseField;
        
        /// <remarks/>
        public string nisResp {
            get {
                return this.nisRespField;
            }
            set {
                this.nisRespField = value;
            }
        }
        
        /// <remarks/>
        public string nrConsClasse {
            get {
                return this.nrConsClasseField;
            }
            set {
                this.nrConsClasseField = value;
            }
        }
        
        /// <remarks/>
        public string ufConsClasse {
            get {
                return this.ufConsClasseField;
            }
            set {
                this.ufConsClasseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtMonit/v02_01_00")]
    public partial class eSocialEvtMonitAsoIdeServSaude {
        
        private string codCNESField;
        
        private string frmCttField;
        
        private string emailField;
        
        private TMedico medicoField;
        
        /// <remarks/>
        public string codCNES {
            get {
                return this.codCNESField;
            }
            set {
                this.codCNESField = value;
            }
        }
        
        /// <remarks/>
        public string frmCtt {
            get {
                return this.frmCttField;
            }
            set {
                this.frmCttField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public TMedico medico {
            get {
                return this.medicoField;
            }
            set {
                this.medicoField = value;
            }
        }
    }
}
