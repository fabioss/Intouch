namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Pessoa-Juridica", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class PessoaJuridica
    {
        private RamoAtividade atividadeeconomicaprincipalField;
        private RamoAtividade[] atividadeeconomicasecundariaField;
        private Cnpj cnpjField;
        private DateTime datafundacaoField;
        private bool datafundacaoFieldSpecified;
        private Endereco enderecoField;
        private Telefone faxField;
        private long inscricaoestadualField;
        private bool inscricaoestadualFieldSpecified;
        private NaturezaJuridica naturezajuridicaField;
        private string nomecomercialField;
        private long numeroNIRENIRCField;
        private bool numeroNIRENIRCFieldSpecified;
        private string razaosocialanteriorField;
        private string razaosocialField;
        private SituacaoDocumentoWS situacaocnpjField;
        private SituacaoDocumentoWS situacaoinscricaoestadualField;
        private Telefone telefoneField;
        private decimal valorcapitalsocialField;
        private bool valorcapitalsocialFieldSpecified;

        [XmlElement("atividade-economica-principal", Form=XmlSchemaForm.Unqualified)]
        public RamoAtividade atividadeeconomicaprincipal
        {
            get
            {
                return this.atividadeeconomicaprincipalField;
            }
            set
            {
                this.atividadeeconomicaprincipalField = value;
            }
        }

        [XmlElement("atividade-economica-secundaria", Form=XmlSchemaForm.Unqualified)]
        public RamoAtividade[] atividadeeconomicasecundaria
        {
            get
            {
                return this.atividadeeconomicasecundariaField;
            }
            set
            {
                this.atividadeeconomicasecundariaField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cnpj cnpj
        {
            get
            {
                return this.cnpjField;
            }
            set
            {
                this.cnpjField = value;
            }
        }

        [XmlAttribute("data-fundacao")]
        public DateTime datafundacao
        {
            get
            {
                return this.datafundacaoField;
            }
            set
            {
                this.datafundacaoField = value;
            }
        }

        [XmlIgnore]
        public bool datafundacaoSpecified
        {
            get
            {
                return this.datafundacaoFieldSpecified;
            }
            set
            {
                this.datafundacaoFieldSpecified = value;
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

        [XmlAttribute("inscricao-estadual")]
        public long inscricaoestadual
        {
            get
            {
                return this.inscricaoestadualField;
            }
            set
            {
                this.inscricaoestadualField = value;
            }
        }

        [XmlIgnore]
        public bool inscricaoestadualSpecified
        {
            get
            {
                return this.inscricaoestadualFieldSpecified;
            }
            set
            {
                this.inscricaoestadualFieldSpecified = value;
            }
        }

        [XmlElement("natureza-juridica", Form=XmlSchemaForm.Unqualified)]
        public NaturezaJuridica naturezajuridica
        {
            get
            {
                return this.naturezajuridicaField;
            }
            set
            {
                this.naturezajuridicaField = value;
            }
        }

        [XmlAttribute("nome-comercial")]
        public string nomecomercial
        {
            get
            {
                return this.nomecomercialField;
            }
            set
            {
                this.nomecomercialField = value;
            }
        }

        [XmlAttribute("numero-NIRE-NIRC")]
        public long numeroNIRENIRC
        {
            get
            {
                return this.numeroNIRENIRCField;
            }
            set
            {
                this.numeroNIRENIRCField = value;
            }
        }

        [XmlIgnore]
        public bool numeroNIRENIRCSpecified
        {
            get
            {
                return this.numeroNIRENIRCFieldSpecified;
            }
            set
            {
                this.numeroNIRENIRCFieldSpecified = value;
            }
        }

        [XmlAttribute("razao-social")]
        public string razaosocial
        {
            get
            {
                return this.razaosocialField;
            }
            set
            {
                this.razaosocialField = value;
            }
        }

        [XmlAttribute("razao-social-anterior")]
        public string razaosocialanterior
        {
            get
            {
                return this.razaosocialanteriorField;
            }
            set
            {
                this.razaosocialanteriorField = value;
            }
        }

        [XmlElement("situacao-cnpj", Form=XmlSchemaForm.Unqualified)]
        public SituacaoDocumentoWS situacaocnpj
        {
            get
            {
                return this.situacaocnpjField;
            }
            set
            {
                this.situacaocnpjField = value;
            }
        }

        [XmlElement("situacao-inscricao-estadual", Form=XmlSchemaForm.Unqualified)]
        public SituacaoDocumentoWS situacaoinscricaoestadual
        {
            get
            {
                return this.situacaoinscricaoestadualField;
            }
            set
            {
                this.situacaoinscricaoestadualField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }

        [XmlAttribute("valor-capital-social")]
        public decimal valorcapitalsocial
        {
            get
            {
                return this.valorcapitalsocialField;
            }
            set
            {
                this.valorcapitalsocialField = value;
            }
        }

        [XmlIgnore]
        public bool valorcapitalsocialSpecified
        {
            get
            {
                return this.valorcapitalsocialFieldSpecified;
            }
            set
            {
                this.valorcapitalsocialFieldSpecified = value;
            }
        }
    }
}

