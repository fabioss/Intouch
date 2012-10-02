namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Capital-Social", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoCapitalSocial
    {
        private DateTime dataultimaatualizacaoField;
        private bool dataultimaatualizacaoFieldSpecified;
        private string nacionalidadeField;
        private string naturezaField;
        private string origemField;
        private decimal valorcapitalautorizadoField;
        private bool valorcapitalautorizadoFieldSpecified;
        private decimal valorcapitalrealizadoField;
        private bool valorcapitalrealizadoFieldSpecified;
        private decimal valorcapitalsocialField;
        private bool valorcapitalsocialFieldSpecified;

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
        public string nacionalidade
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
        public string natureza
        {
            get
            {
                return this.naturezaField;
            }
            set
            {
                this.naturezaField = value;
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

        [XmlAttribute("valor-capital-autorizado")]
        public decimal valorcapitalautorizado
        {
            get
            {
                return this.valorcapitalautorizadoField;
            }
            set
            {
                this.valorcapitalautorizadoField = value;
            }
        }

        [XmlIgnore]
        public bool valorcapitalautorizadoSpecified
        {
            get
            {
                return this.valorcapitalautorizadoFieldSpecified;
            }
            set
            {
                this.valorcapitalautorizadoFieldSpecified = value;
            }
        }

        [XmlAttribute("valor-capital-realizado")]
        public decimal valorcapitalrealizado
        {
            get
            {
                return this.valorcapitalrealizadoField;
            }
            set
            {
                this.valorcapitalrealizadoField = value;
            }
        }

        [XmlIgnore]
        public bool valorcapitalrealizadoSpecified
        {
            get
            {
                return this.valorcapitalrealizadoFieldSpecified;
            }
            set
            {
                this.valorcapitalrealizadoFieldSpecified = value;
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

