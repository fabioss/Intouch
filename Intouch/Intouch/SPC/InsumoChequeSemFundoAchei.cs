namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Cheque-Sem-Fundo-Achei", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoChequeSemFundoAchei
    {
        private Alinea alineaField;
        private Cheque chequeField;
        private Cidade cidadeField;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private Moeda moedaField;
        private NaturezaAnotacao naturezaanotacaoField;
        private int quantidadebancoField;
        private bool quantidadebancoFieldSpecified;
        private string titularidadecontacorrenteField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Alinea alinea
        {
            get
            {
                return this.alineaField;
            }
            set
            {
                this.alineaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cheque cheque
        {
            get
            {
                return this.chequeField;
            }
            set
            {
                this.chequeField = value;
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

        [XmlAttribute("quantidade-banco")]
        public int quantidadebanco
        {
            get
            {
                return this.quantidadebancoField;
            }
            set
            {
                this.quantidadebancoField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadebancoSpecified
        {
            get
            {
                return this.quantidadebancoFieldSpecified;
            }
            set
            {
                this.quantidadebancoFieldSpecified = value;
            }
        }

        [XmlAttribute("titularidade-conta-corrente")]
        public string titularidadecontacorrente
        {
            get
            {
                return this.titularidadecontacorrenteField;
            }
            set
            {
                this.titularidadecontacorrenteField = value;
            }
        }
    }
}

