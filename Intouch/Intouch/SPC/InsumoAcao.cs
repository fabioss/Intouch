namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Acao", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoAcao
    {
        private DateTime dataacaoField;
        private bool dataacaoFieldSpecified;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private string distritoField;
        private string nomeautorField;
        private TipoAcao tipoacaoField;
        private decimal valoracaoField;
        private bool valoracaoFieldSpecified;
        private Vara varaField;

        [XmlAttribute("data-acao")]
        public DateTime dataacao
        {
            get
            {
                return this.dataacaoField;
            }
            set
            {
                this.dataacaoField = value;
            }
        }

        [XmlIgnore]
        public bool dataacaoSpecified
        {
            get
            {
                return this.dataacaoFieldSpecified;
            }
            set
            {
                this.dataacaoFieldSpecified = value;
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

        [XmlAttribute]
        public string distrito
        {
            get
            {
                return this.distritoField;
            }
            set
            {
                this.distritoField = value;
            }
        }

        [XmlAttribute("nome-autor")]
        public string nomeautor
        {
            get
            {
                return this.nomeautorField;
            }
            set
            {
                this.nomeautorField = value;
            }
        }

        [XmlElement("tipo-acao", Form=XmlSchemaForm.Unqualified)]
        public TipoAcao tipoacao
        {
            get
            {
                return this.tipoacaoField;
            }
            set
            {
                this.tipoacaoField = value;
            }
        }

        [XmlAttribute("valor-acao")]
        public decimal valoracao
        {
            get
            {
                return this.valoracaoField;
            }
            set
            {
                this.valoracaoField = value;
            }
        }

        [XmlIgnore]
        public bool valoracaoSpecified
        {
            get
            {
                return this.valoracaoFieldSpecified;
            }
            set
            {
                this.valoracaoFieldSpecified = value;
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

