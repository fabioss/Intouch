namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class Cpf
    {
        private string numeroField;
        private string regiaoorigemField;

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

        [XmlAttribute("regiao-origem")]
        public string regiaoorigem
        {
            get
            {
                return this.regiaoorigemField;
            }
            set
            {
                this.regiaoorigemField = value;
            }
        }
    }
}

