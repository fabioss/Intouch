namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class Estado
    {
        private string siglaufField;

        [XmlAttribute("sigla-uf")]
        public string siglauf
        {
            get
            {
                return this.siglaufField;
            }
            set
            {
                this.siglaufField = value;
            }
        }
    }
}

