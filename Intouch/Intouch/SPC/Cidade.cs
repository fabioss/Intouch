namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class Cidade
    {
        private Estado estadoField;
        private string nomeField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Estado estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
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

