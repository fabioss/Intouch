namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class Vara
    {
        private Cidade comarcaField;
        private string nomeField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cidade comarca
        {
            get
            {
                return this.comarcaField;
            }
            set
            {
                this.comarcaField = value;
            }
        }

        [XmlAttribute]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }
    }
}

