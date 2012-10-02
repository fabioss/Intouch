namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName="Insumo-Alerta-Documento", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoAlertaDocumento
    {
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private string entidadeorigemField;
        private string motivoField;
        private string observacaoField;
        private TipoDocumentoAlerta[] tipodocumentoalertaField;

        [XmlAttribute("data-inclusao")]
        public DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
            }
        }

        [XmlIgnore]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
            }
        }

        [XmlAttribute("data-ocorrencia")]
        public DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
            }
        }

        [XmlIgnore]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
            }
        }

        [XmlAttribute("entidade-origem")]
        public string entidadeorigem
        {
            get
            {
                return this.entidadeorigemField;
            }
            set
            {
                this.entidadeorigemField = value;
            }
        }

        [XmlAttribute]
        public string motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
            }
        }

        [XmlAttribute]
        public string observacao
        {
            get
            {
                return this.observacaoField;
            }
            set
            {
                this.observacaoField = value;
            }
        }

        [XmlElement("tipo-documento-alerta", Form=XmlSchemaForm.Unqualified)]
        public TipoDocumentoAlerta[] tipodocumentoalerta
        {
            get
            {
                return this.tipodocumentoalertaField;
            }
            set
            {
                this.tipodocumentoalertaField = value;
            }
        }
    }
}

