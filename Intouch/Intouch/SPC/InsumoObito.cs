namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Obito", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoObito
    {
        private CartorioObito cartorioobitoField;
        private DateTime dataobitoField;
        private bool dataobitoFieldSpecified;

        [XmlElement("cartorio-obito", Form=XmlSchemaForm.Unqualified)]
        public CartorioObito cartorioobito
        {
            get
            {
                return this.cartorioobitoField;
            }
            set
            {
                this.cartorioobitoField = value;
            }
        }

        [XmlAttribute("data-obito")]
        public DateTime dataobito
        {
            get
            {
                return this.dataobitoField;
            }
            set
            {
                this.dataobitoField = value;
            }
        }

        [XmlIgnore]
        public bool dataobitoSpecified
        {
            get
            {
                return this.dataobitoFieldSpecified;
            }
            set
            {
                this.dataobitoFieldSpecified = value;
            }
        }
    }
}

