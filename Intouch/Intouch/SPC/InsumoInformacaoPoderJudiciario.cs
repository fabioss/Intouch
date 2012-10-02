namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Informacao-Poder-Judiciario", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class InsumoInformacaoPoderJudiciario
    {
        private DateTime datadocumentoField;
        private bool datadocumentoFieldSpecified;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private string entidadeorigemField;
        private string numeroprocessoField;
        private decimal valorField;
        private bool valorFieldSpecified;
        private Vara varaField;

        [XmlAttribute("data-documento")]
        public DateTime datadocumento
        {
            get
            {
                return this.datadocumentoField;
            }
            set
            {
                this.datadocumentoField = value;
            }
        }

        [XmlIgnore]
        public bool datadocumentoSpecified
        {
            get
            {
                return this.datadocumentoFieldSpecified;
            }
            set
            {
                this.datadocumentoFieldSpecified = value;
            }
        }

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

        [XmlAttribute("numero-processo")]
        public string numeroprocesso
        {
            get
            {
                return this.numeroprocessoField;
            }
            set
            {
                this.numeroprocessoField = value;
            }
        }

        [XmlAttribute]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        [XmlIgnore]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Vara vara
        {
            get
            {
                return this.varaField;
            }
            set
            {
                this.varaField = value;
            }
        }
    }
}

