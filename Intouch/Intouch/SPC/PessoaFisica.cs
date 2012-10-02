namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Pessoa-Fisica", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class PessoaFisica
    {
        private Cpf cpfField;
        private DateTime datanascimentoField;
        private bool datanascimentoFieldSpecified;
        private Endereco enderecoField;
        private EstadoCivil estadocivilField;
        private bool estadocivilFieldSpecified;
        private Estado estadorgField;
        private Telefone faxField;
        private int idadeField;
        private bool idadeFieldSpecified;
        private string nomeField;
        private string nomemaeField;
        private string nomepaiField;
        private string numerorgField;
        private long numerotituloeleitorField;
        private bool numerotituloeleitorFieldSpecified;
        private Sexo sexoField;
        private bool sexoFieldSpecified;
        private Signo signoField;
        private bool signoFieldSpecified;
        private SituacaoDocumentoWS situacaocpfField;
        private Telefone telefonecelularField;
        private Telefone telefonecomercialField;
        private Telefone telefoneresidencialField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cpf cpf
        {
            get
            {
                return this.cpfField;
            }
            set
            {
                this.cpfField = value;
            }
        }

        [XmlAttribute("data-nascimento")]
        public DateTime datanascimento
        {
            get
            {
                return this.datanascimentoField;
            }
            set
            {
                this.datanascimentoField = value;
            }
        }

        [XmlIgnore]
        public bool datanascimentoSpecified
        {
            get
            {
                return this.datanascimentoFieldSpecified;
            }
            set
            {
                this.datanascimentoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Endereco endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }

        [XmlAttribute("estado-civil")]
        public EstadoCivil estadocivil
        {
            get
            {
                return this.estadocivilField;
            }
            set
            {
                this.estadocivilField = value;
            }
        }

        [XmlIgnore]
        public bool estadocivilSpecified
        {
            get
            {
                return this.estadocivilFieldSpecified;
            }
            set
            {
                this.estadocivilFieldSpecified = value;
            }
        }

        [XmlElement("estado-rg", Form=XmlSchemaForm.Unqualified)]
        public Estado estadorg
        {
            get
            {
                return this.estadorgField;
            }
            set
            {
                this.estadorgField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Telefone fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        [XmlAttribute]
        public int idade
        {
            get
            {
                return this.idadeField;
            }
            set
            {
                this.idadeField = value;
            }
        }

        [XmlIgnore]
        public bool idadeSpecified
        {
            get
            {
                return this.idadeFieldSpecified;
            }
            set
            {
                this.idadeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        [XmlAttribute("nome-mae")]
        public string nomemae
        {
            get
            {
                return this.nomemaeField;
            }
            set
            {
                this.nomemaeField = value;
            }
        }

        [XmlAttribute("nome-pai")]
        public string nomepai
        {
            get
            {
                return this.nomepaiField;
            }
            set
            {
                this.nomepaiField = value;
            }
        }

        [XmlAttribute("numero-rg")]
        public string numerorg
        {
            get
            {
                return this.numerorgField;
            }
            set
            {
                this.numerorgField = value;
            }
        }

        [XmlAttribute("numero-titulo-eleitor")]
        public long numerotituloeleitor
        {
            get
            {
                return this.numerotituloeleitorField;
            }
            set
            {
                this.numerotituloeleitorField = value;
            }
        }

        [XmlIgnore]
        public bool numerotituloeleitorSpecified
        {
            get
            {
                return this.numerotituloeleitorFieldSpecified;
            }
            set
            {
                this.numerotituloeleitorFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public Sexo sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
            }
        }

        [XmlIgnore]
        public bool sexoSpecified
        {
            get
            {
                return this.sexoFieldSpecified;
            }
            set
            {
                this.sexoFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public Signo signo
        {
            get
            {
                return this.signoField;
            }
            set
            {
                this.signoField = value;
            }
        }

        [XmlIgnore]
        public bool signoSpecified
        {
            get
            {
                return this.signoFieldSpecified;
            }
            set
            {
                this.signoFieldSpecified = value;
            }
        }

        [XmlElement("situacao-cpf", Form=XmlSchemaForm.Unqualified)]
        public SituacaoDocumentoWS situacaocpf
        {
            get
            {
                return this.situacaocpfField;
            }
            set
            {
                this.situacaocpfField = value;
            }
        }

        [XmlElement("telefone-celular", Form=XmlSchemaForm.Unqualified)]
        public Telefone telefonecelular
        {
            get
            {
                return this.telefonecelularField;
            }
            set
            {
                this.telefonecelularField = value;
            }
        }

        [XmlElement("telefone-comercial", Form=XmlSchemaForm.Unqualified)]
        public Telefone telefonecomercial
        {
            get
            {
                return this.telefonecomercialField;
            }
            set
            {
                this.telefonecomercialField = value;
            }
        }

        [XmlElement("telefone-residencial", Form=XmlSchemaForm.Unqualified)]
        public Telefone telefoneresidencial
        {
            get
            {
                return this.telefoneresidencialField;
            }
            set
            {
                this.telefoneresidencialField = value;
            }
        }
    }
}

