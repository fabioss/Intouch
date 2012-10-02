namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Grafia-PJ", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, DesignerCategory("code")]
    public class GrafiaPJ
    {
        private string razaosocialField;

        [XmlAttribute("razao-social")]
        public string razaosocial
        {
            get
            {
                return this.razaosocialField;
            }
            set
            {
                this.razaosocialField = value;
            }
        }
    }
}

