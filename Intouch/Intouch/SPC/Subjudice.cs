namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class Subjudice
    {
        private DateTime datasubjudiceField;
        private bool datasubjudiceFieldSpecified;
        private string distritosubjudiceField;
        private string mensagemsubjudiceField;
        private string pracasubjudiceField;
        private string processosubjudiceField;
        private string varasubjudiceField;

        [XmlAttribute("data-subjudice")]
        public DateTime datasubjudice
        {
            get
            {
                return this.datasubjudiceField;
            }
            set
            {
                this.datasubjudiceField = value;
            }
        }

        [XmlIgnore]
        public bool datasubjudiceSpecified
        {
            get
            {
                return this.datasubjudiceFieldSpecified;
            }
            set
            {
                this.datasubjudiceFieldSpecified = value;
            }
        }

        [XmlAttribute("distrito-subjudice")]
        public string distritosubjudice
        {
            get
            {
                return this.distritosubjudiceField;
            }
            set
            {
                this.distritosubjudiceField = value;
            }
        }

        [XmlAttribute("mensagem-subjudice")]
        public string mensagemsubjudice
        {
            get
            {
                return this.mensagemsubjudiceField;
            }
            set
            {
                this.mensagemsubjudiceField = value;
            }
        }

        [XmlAttribute("praca-subjudice")]
        public string pracasubjudice
        {
            get
            {
                return this.pracasubjudiceField;
            }
            set
            {
                this.pracasubjudiceField = value;
            }
        }

        [XmlAttribute("processo-subjudice")]
        public string processosubjudice
        {
            get
            {
                return this.processosubjudiceField;
            }
            set
            {
                this.processosubjudiceField = value;
            }
        }

        [XmlAttribute("vara-subjudice")]
        public string varasubjudice
        {
            get
            {
                return this.varasubjudiceField;
            }
            set
            {
                this.varasubjudiceField = value;
            }
        }
    }
}

