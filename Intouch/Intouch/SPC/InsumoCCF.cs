namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-CCF", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoCCF
    {
        private DateTime dataultimochequeField;
        private bool dataultimochequeFieldSpecified;
        private Alinea motivoField;
        private string origemField;
        private int quantidadeField;
        private bool quantidadeFieldSpecified;
        private Cheque ultimochequeField;

        [XmlAttribute("data-ultimo-cheque")]
        public DateTime dataultimocheque
        {
            get
            {
                return this.dataultimochequeField;
            }
            set
            {
                this.dataultimochequeField = value;
            }
        }

        [XmlIgnore]
        public bool dataultimochequeSpecified
        {
            get
            {
                return this.dataultimochequeFieldSpecified;
            }
            set
            {
                this.dataultimochequeFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Alinea motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
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

        [XmlAttribute]
        public int quantidade
        {
            get
            {
                return this.quantidadeField;
            }
            set
            {
                this.quantidadeField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeSpecified
        {
            get
            {
                return this.quantidadeFieldSpecified;
            }
            set
            {
                this.quantidadeFieldSpecified = value;
            }
        }

        [XmlElement("ultimo-cheque", Form=XmlSchemaForm.Unqualified)]
        public Cheque ultimocheque
        {
            get
            {
                return this.ultimochequeField;
            }
            set
            {
                this.ultimochequeField = value;
            }
        }
    }
}

