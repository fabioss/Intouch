namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), XmlType(TypeName="Insumo-Restricao-Financeira", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoRestricaoFinanceira
    {
        private bool avalistaField;
        private bool avalistaFieldSpecified;
        private Cidade cidadeField;
        private string contratoField;
        private DadosBancarios dadosbancariosField;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private string filialField;
        private bool indicadorsubjudiceField;
        private bool indicadorsubjudiceFieldSpecified;
        private NaturezaAnotacao naturezaanotacaoField;
        private string origemField;
        private Subjudice subjudiceField;
        private string tituloocorrenciaField;
        private decimal valorpendenciaField;
        private bool valorpendenciaFieldSpecified;

        [XmlAttribute]
        public bool avalista
        {
            get
            {
                return this.avalistaField;
            }
            set
            {
                this.avalistaField = value;
            }
        }

        [XmlIgnore]
        public bool avalistaSpecified
        {
            get
            {
                return this.avalistaFieldSpecified;
            }
            set
            {
                this.avalistaFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }

        [XmlAttribute]
        public string contrato
        {
            get
            {
                return this.contratoField;
            }
            set
            {
                this.contratoField = value;
            }
        }

        [XmlElement("dados-bancarios", Form=XmlSchemaForm.Unqualified)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
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

        [XmlAttribute]
        public string filial
        {
            get
            {
                return this.filialField;
            }
            set
            {
                this.filialField = value;
            }
        }

        [XmlAttribute("indicador-subjudice")]
        public bool indicadorsubjudice
        {
            get
            {
                return this.indicadorsubjudiceField;
            }
            set
            {
                this.indicadorsubjudiceField = value;
            }
        }

        [XmlIgnore]
        public bool indicadorsubjudiceSpecified
        {
            get
            {
                return this.indicadorsubjudiceFieldSpecified;
            }
            set
            {
                this.indicadorsubjudiceFieldSpecified = value;
            }
        }

        [XmlElement("natureza-anotacao", Form=XmlSchemaForm.Unqualified)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
            }
        }

        [XmlAttribute]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
            }
        }

        [XmlAttribute("titulo-ocorrencia")]
        public string tituloocorrencia
        {
            get
            {
                return this.tituloocorrenciaField;
            }
            set
            {
                this.tituloocorrenciaField = value;
            }
        }

        [XmlAttribute("valor-pendencia")]
        public decimal valorpendencia
        {
            get
            {
                return this.valorpendenciaField;
            }
            set
            {
                this.valorpendenciaField = value;
            }
        }

        [XmlIgnore]
        public bool valorpendenciaSpecified
        {
            get
            {
                return this.valorpendenciaFieldSpecified;
            }
            set
            {
                this.valorpendenciaFieldSpecified = value;
            }
        }
    }
}

