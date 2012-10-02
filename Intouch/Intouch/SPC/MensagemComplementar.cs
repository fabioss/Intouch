namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName="Mensagem-Complementar", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class MensagemComplementar
    {
        private string[] mensagemField;
        private string origemField;

        [XmlElement("mensagem", Form=XmlSchemaForm.Unqualified)]
        public string[] mensagem
        {
            get
            {
                return this.mensagemField;
            }
            set
            {
                this.mensagemField = value;
            }
        }

        [XmlAttribute]
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
            }
        }
    }
}

