namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Cheque-Lojista", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class ChequeLojista : Cheque
    {
        private DateTime dataemissaoField;
        private bool dataemissaoFieldSpecified;

        [XmlAttribute("data-emissao")]
        public DateTime dataemissao
        {
            get
            {
                return this.dataemissaoField;
            }
            set
            {
                this.dataemissaoField = value;
            }
        }

        [XmlIgnore]
        public bool dataemissaoSpecified
        {
            get
            {
                return this.dataemissaoFieldSpecified;
            }
            set
            {
                this.dataemissaoFieldSpecified = value;
            }
        }
    }
}

