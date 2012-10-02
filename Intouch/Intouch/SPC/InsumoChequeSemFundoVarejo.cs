namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(TypeName="Insumo-Cheque-Sem-Fundo-Varejo", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoChequeSemFundoVarejo
    {
        private Cidade cidadeocorrenciaField;
        private DadosBancarios dadosbancariosField;
        private DateTime dataocorrenciamaisrecenteField;
        private bool dataocorrenciamaisrecenteFieldSpecified;
        private int numerolojaField;
        private bool numerolojaFieldSpecified;
        private string origemocorrenciamaisrecenteField;
        private int quantidadechequesField;
        private bool quantidadechequesFieldSpecified;

        [XmlElement("cidade-ocorrencia", Form=XmlSchemaForm.Unqualified)]
        public Cidade cidadeocorrencia
        {
            get
            {
                return this.cidadeocorrenciaField;
            }
            set
            {
                this.cidadeocorrenciaField = value;
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

        [XmlAttribute("data-ocorrencia-mais-recente")]
        public DateTime dataocorrenciamaisrecente
        {
            get
            {
                return this.dataocorrenciamaisrecenteField;
            }
            set
            {
                this.dataocorrenciamaisrecenteField = value;
            }
        }

        [XmlIgnore]
        public bool dataocorrenciamaisrecenteSpecified
        {
            get
            {
                return this.dataocorrenciamaisrecenteFieldSpecified;
            }
            set
            {
                this.dataocorrenciamaisrecenteFieldSpecified = value;
            }
        }

        [XmlAttribute("numero-loja")]
        public int numeroloja
        {
            get
            {
                return this.numerolojaField;
            }
            set
            {
                this.numerolojaField = value;
            }
        }

        [XmlIgnore]
        public bool numerolojaSpecified
        {
            get
            {
                return this.numerolojaFieldSpecified;
            }
            set
            {
                this.numerolojaFieldSpecified = value;
            }
        }

        [XmlAttribute("origem-ocorrencia-mais-recente")]
        public string origemocorrenciamaisrecente
        {
            get
            {
                return this.origemocorrenciamaisrecenteField;
            }
            set
            {
                this.origemocorrenciamaisrecenteField = value;
            }
        }

        [XmlAttribute("quantidade-cheques")]
        public int quantidadecheques
        {
            get
            {
                return this.quantidadechequesField;
            }
            set
            {
                this.quantidadechequesField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadechequesSpecified
        {
            get
            {
                return this.quantidadechequesFieldSpecified;
            }
            set
            {
                this.quantidadechequesFieldSpecified = value;
            }
        }
    }
}

