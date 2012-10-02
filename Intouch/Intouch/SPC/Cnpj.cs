namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class Cnpj
    {
        private string numeroField;

        [XmlAttribute]
        public string numero
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
    }
}

