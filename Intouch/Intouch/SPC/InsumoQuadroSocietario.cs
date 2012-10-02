namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Quadro-Societario", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(InsumoParticipacaoEmpresas)), XmlInclude(typeof(InsumoQuadroAdministrativo)), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoQuadroSocietario
    {
        private string cargoadministracaoField;
        private string cargodirecaoField;
        private string condicaoField;
        private DateTime dataentradaField;
        private bool dataentradaFieldSpecified;
        private DateTime datasaidaField;
        private bool datasaidaFieldSpecified;
        private DateTime dataultimaatualizacaoField;
        private bool dataultimaatualizacaoFieldSpecified;
        private string documentoField;
        private Estado estadoEMBRATELField;
        private bool indicadorrestricaoField;
        private bool indicadorrestricaoFieldSpecified;
        private string municipioEMBRATELField;
        private Pais nacionalidadeField;
        private string nomeField;
        private decimal porcentualparticipacaoField;
        private bool porcentualparticipacaoFieldSpecified;
        private string situacaodocumentoField;
        private string tiporelacionamentoField;
        private decimal valorparticipacaoField;
        private bool valorparticipacaoFieldSpecified;

        [XmlAttribute("cargo-administracao")]
        public string cargoadministracao
        {
            get
            {
                return this.cargoadministracaoField;
            }
            set
            {
                this.cargoadministracaoField = value;
            }
        }

        [XmlAttribute("cargo-direcao")]
        public string cargodirecao
        {
            get
            {
                return this.cargodirecaoField;
            }
            set
            {
                this.cargodirecaoField = value;
            }
        }

        [XmlAttribute]
        public string condicao
        {
            get
            {
                return this.condicaoField;
            }
            set
            {
                this.condicaoField = value;
            }
        }

        [XmlAttribute("data-entrada")]
        public DateTime dataentrada
        {
            get
            {
                return this.dataentradaField;
            }
            set
            {
                this.dataentradaField = value;
            }
        }

        [XmlIgnore]
        public bool dataentradaSpecified
        {
            get
            {
                return this.dataentradaFieldSpecified;
            }
            set
            {
                this.dataentradaFieldSpecified = value;
            }
        }

        [XmlAttribute("data-saida")]
        public DateTime datasaida
        {
            get
            {
                return this.datasaidaField;
            }
            set
            {
                this.datasaidaField = value;
            }
        }

        [XmlIgnore]
        public bool datasaidaSpecified
        {
            get
            {
                return this.datasaidaFieldSpecified;
            }
            set
            {
                this.datasaidaFieldSpecified = value;
            }
        }

        [XmlAttribute("data-ultima-atualizacao")]
        public DateTime dataultimaatualizacao
        {
            get
            {
                return this.dataultimaatualizacaoField;
            }
            set
            {
                this.dataultimaatualizacaoField = value;
            }
        }

        [XmlIgnore]
        public bool dataultimaatualizacaoSpecified
        {
            get
            {
                return this.dataultimaatualizacaoFieldSpecified;
            }
            set
            {
                this.dataultimaatualizacaoFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
            }
        }

        [XmlElement("estado-EMBRATEL", Form=XmlSchemaForm.Unqualified)]
        public Estado estadoEMBRATEL
        {
            get
            {
                return this.estadoEMBRATELField;
            }
            set
            {
                this.estadoEMBRATELField = value;
            }
        }

        [XmlAttribute("indicador-restricao")]
        public bool indicadorrestricao
        {
            get
            {
                return this.indicadorrestricaoField;
            }
            set
            {
                this.indicadorrestricaoField = value;
            }
        }

        [XmlIgnore]
        public bool indicadorrestricaoSpecified
        {
            get
            {
                return this.indicadorrestricaoFieldSpecified;
            }
            set
            {
                this.indicadorrestricaoFieldSpecified = value;
            }
        }

        [XmlAttribute("municipio-EMBRATEL")]
        public string municipioEMBRATEL
        {
            get
            {
                return this.municipioEMBRATELField;
            }
            set
            {
                this.municipioEMBRATELField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Pais nacionalidade
        {
            get
            {
                return this.nacionalidadeField;
            }
            set
            {
                this.nacionalidadeField = value;
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

        [XmlAttribute("porcentual-participacao")]
        public decimal porcentualparticipacao
        {
            get
            {
                return this.porcentualparticipacaoField;
            }
            set
            {
                this.porcentualparticipacaoField = value;
            }
        }

        [XmlIgnore]
        public bool porcentualparticipacaoSpecified
        {
            get
            {
                return this.porcentualparticipacaoFieldSpecified;
            }
            set
            {
                this.porcentualparticipacaoFieldSpecified = value;
            }
        }

        [XmlAttribute("situacao-documento")]
        public string situacaodocumento
        {
            get
            {
                return this.situacaodocumentoField;
            }
            set
            {
                this.situacaodocumentoField = value;
            }
        }

        [XmlAttribute("tipo-relacionamento")]
        public string tiporelacionamento
        {
            get
            {
                return this.tiporelacionamentoField;
            }
            set
            {
                this.tiporelacionamentoField = value;
            }
        }

        [XmlAttribute("valor-participacao")]
        public decimal valorparticipacao
        {
            get
            {
                return this.valorparticipacaoField;
            }
            set
            {
                this.valorparticipacaoField = value;
            }
        }

        [XmlIgnore]
        public bool valorparticipacaoSpecified
        {
            get
            {
                return this.valorparticipacaoFieldSpecified;
            }
            set
            {
                this.valorparticipacaoFieldSpecified = value;
            }
        }
    }
}

