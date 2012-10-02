namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Cheque-Sem-Fundo-Achei-CCF", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoChequeSemFundoAcheiCCF
    {
        private Cheque chequeField;
        private Cidade cidadeField;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private NaturezaAnotacao naturezaanotacaoField;
        private string numerochequeField;
        private int quantidadebancoField;
        private bool quantidadebancoFieldSpecified;

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

        [XmlAttribute("numero-cheque")]
        public string numerocheque
        {
            get
            {
                return this.numerochequeField;
            }
            set
            {
                this.numerochequeField = value;
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
    }
}

