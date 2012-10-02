namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class Moeda
    {
        private string simboloField;

        [XmlAttribute]
        public string simbolo
        {
            get
            {
                return this.simboloField;
            }
            set
            {
                this.simboloField = value;
            }
        }
    }
}

