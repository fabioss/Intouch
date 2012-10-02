namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Cartorio-Obito", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class CartorioObito
    {
        private string cartorioField;
        private Cidade cidadecartorioField;

        [XmlAttribute]
        public string cartorio
        {
            get
            {
                return this.cartorioField;
            }
            set
            {
                this.cartorioField = value;
            }
        }

        [XmlElement("cidade-cartorio", Form=XmlSchemaForm.Unqualified)]
        public Cidade cidadecartorio
        {
            get
            {
                return this.cidadecartorioField;
            }
            set
            {
                this.cidadecartorioField = value;
            }
        }
    }
}

