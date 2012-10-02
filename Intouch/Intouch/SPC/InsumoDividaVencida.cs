namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(TypeName="Insumo-Divida-Vencida", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough]
    public class InsumoDividaVencida
    {
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private string instituicaofinanceiraField;
        private string localField;
        private string modalidadeField;
        private Moeda moedaField;
        private NaturezaAnotacao naturezaanotacaoField;
        private Subjudice subjudiceField;
        private string tituloField;
        private decimal valordividaField;
        private bool valordividaFieldSpecified;

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

        [XmlAttribute("instituicao-financeira")]
        public string instituicaofinanceira
        {
            get
            {
                return this.instituicaofinanceiraField;
            }
            set
            {
                this.instituicaofinanceiraField = value;
            }
        }

        [XmlAttribute]
        public string local
        {
            get
            {
                return this.localField;
            }
            set
            {
                this.localField = value;
            }
        }

        [XmlAttribute]
        public string modalidade
        {
            get
            {
                return this.modalidadeField;
            }
            set
            {
                this.modalidadeField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
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

        [XmlAttribute]
        public string titulo
        {
            get
            {
                return this.tituloField;
            }
            set
            {
                this.tituloField = value;
            }
        }

        [XmlAttribute("valor-divida")]
        public decimal valordivida
        {
            get
            {
                return this.valordividaField;
            }
            set
            {
                this.valordividaField = value;
            }
        }

        [XmlIgnore]
        public bool valordividaSpecified
        {
            get
            {
                return this.valordividaFieldSpecified;
            }
            set
            {
                this.valordividaFieldSpecified = value;
            }
        }
    }
}

