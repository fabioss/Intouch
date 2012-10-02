namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlInclude(typeof(ChequeLojista)), XmlInclude(typeof(ChequeContraOrdem)), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, XmlInclude(typeof(ChequeFinal)), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class Cheque
    {
        private DadosBancarios dadosbancariosField;
        private int digitoField;
        private bool digitoFieldSpecified;
        private int numeroField;
        private bool numeroFieldSpecified;
        private decimal valorField;
        private bool valorFieldSpecified;

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

        [XmlAttribute]
        public int digito
        {
            get
            {
                return this.digitoField;
            }
            set
            {
                this.digitoField = value;
            }
        }

        [XmlIgnore]
        public bool digitoSpecified
        {
            get
            {
                return this.digitoFieldSpecified;
            }
            set
            {
                this.digitoFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int numero
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

        [XmlAttribute]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        [XmlIgnore]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
            }
        }
    }
}

