namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class Telefone
    {
        private int numerodddField;
        private bool numerodddFieldSpecified;
        private long numeroField;
        private bool numeroFieldSpecified;

        [XmlAttribute]
        public long numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        [XmlAttribute("numero-ddd")]
        public int numeroddd
        {
            get
            {
                return this.numerodddField;
            }
            set
            {
                this.numerodddField = value;
            }
        }

        [XmlIgnore]
        public bool numerodddSpecified
        {
            get
            {
                return this.numerodddFieldSpecified;
            }
            set
            {
                this.numerodddFieldSpecified = value;
            }
        }

        [XmlIgnore]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
            }
        }
    }
}

