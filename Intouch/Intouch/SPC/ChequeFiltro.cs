namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Cheque-Filtro", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ChequeFiltro
    {
        private DateTime datadepositoField;
        private int digitoField;
        private int numeroField;
        private decimal valorField;

        [XmlElement("data-deposito", Form=XmlSchemaForm.Unqualified)]
        public DateTime datadeposito
        {
            get
            {
                return this.datadepositoField;
            }
            set
            {
                this.datadepositoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
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
    }
}

