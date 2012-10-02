namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Endereco-Assinante-Telefone", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class EnderecoAssinanteTelefone : Endereco
    {
        private string tipologradouroField;

        [XmlAttribute("tipo-logradouro")]
        public string tipologradouro
        {
            get
            {
                return this.tipologradouroField;
            }
            set
            {
                this.tipologradouroField = value;
            }
        }
    }
}

