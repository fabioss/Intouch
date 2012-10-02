namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(InsumoRiskscoring12Meses)), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Riskscoring-6-Meses", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoRiskscoring6Meses
    {
        private DateTime datafatorField;
        private bool datafatorFieldSpecified;
        private decimal fatorprinadField;
        private bool fatorprinadFieldSpecified;
        private decimal fatorriskscoringField;
        private bool fatorriskscoringFieldSpecified;
        private int horizontetempoField;
        private bool horizontetempoFieldSpecified;
        private string mensageminterpretacaoField;
        private string mensagemprinadField;
        private MensagemRiskscoring[] mensagemriskscoringField;

        [XmlAttribute("data-fator")]
        public DateTime datafator
        {
            get
            {
                return this.datafatorField;
            }
            set
            {
                this.datafatorField = value;
            }
        }

        [XmlIgnore]
        public bool datafatorSpecified
        {
            get
            {
                return this.datafatorFieldSpecified;
            }
            set
            {
                this.datafatorFieldSpecified = value;
            }
        }

        [XmlAttribute("fator-prinad")]
        public decimal fatorprinad
        {
            get
            {
                return this.fatorprinadField;
            }
            set
            {
                this.fatorprinadField = value;
            }
        }

        [XmlIgnore]
        public bool fatorprinadSpecified
        {
            get
            {
                return this.fatorprinadFieldSpecified;
            }
            set
            {
                this.fatorprinadFieldSpecified = value;
            }
        }

        [XmlAttribute("fator-riskscoring")]
        public decimal fatorriskscoring
        {
            get
            {
                return this.fatorriskscoringField;
            }
            set
            {
                this.fatorriskscoringField = value;
            }
        }

        [XmlIgnore]
        public bool fatorriskscoringSpecified
        {
            get
            {
                return this.fatorriskscoringFieldSpecified;
            }
            set
            {
                this.fatorriskscoringFieldSpecified = value;
            }
        }

        [XmlElement("horizonte-tempo", Form=XmlSchemaForm.Unqualified)]
        public int horizontetempo
        {
            get
            {
                return this.horizontetempoField;
            }
            set
            {
                this.horizontetempoField = value;
            }
        }

        [XmlIgnore]
        public bool horizontetempoSpecified
        {
            get
            {
                return this.horizontetempoFieldSpecified;
            }
            set
            {
                this.horizontetempoFieldSpecified = value;
            }
        }

        [XmlElement("mensagem-interpretacao", Form=XmlSchemaForm.Unqualified)]
        public string mensageminterpretacao
        {
            get
            {
                return this.mensageminterpretacaoField;
            }
            set
            {
                this.mensageminterpretacaoField = value;
            }
        }

        [XmlElement("mensagem-prinad", Form=XmlSchemaForm.Unqualified)]
        public string mensagemprinad
        {
            get
            {
                return this.mensagemprinadField;
            }
            set
            {
                this.mensagemprinadField = value;
            }
        }

        [XmlElement("mensagem-riskscoring", Form=XmlSchemaForm.Unqualified)]
        public MensagemRiskscoring[] mensagemriskscoring
        {
            get
            {
                return this.mensagemriskscoringField;
            }
            set
            {
                this.mensagemriskscoringField = value;
            }
        }
    }
}

