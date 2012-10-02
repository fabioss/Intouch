namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Mensagem-Riskscoring", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class MensagemRiskscoring
    {
        private DateTime datamensagemriskscoringField;
        private bool datamensagemriskscoringFieldSpecified;
        private string textomensagemriskscoringField;

        [XmlAttribute("data-mensagem-riskscoring")]
        public DateTime datamensagemriskscoring
        {
            get
            {
                return this.datamensagemriskscoringField;
            }
            set
            {
                this.datamensagemriskscoringField = value;
            }
        }

        [XmlIgnore]
        public bool datamensagemriskscoringSpecified
        {
            get
            {
                return this.datamensagemriskscoringFieldSpecified;
            }
            set
            {
                this.datamensagemriskscoringFieldSpecified = value;
            }
        }

        [XmlAttribute("texto-mensagem-riskscoring")]
        public string textomensagemriskscoring
        {
            get
            {
                return this.textomensagemriskscoringField;
            }
            set
            {
                this.textomensagemriskscoringField = value;
            }
        }
    }
}

