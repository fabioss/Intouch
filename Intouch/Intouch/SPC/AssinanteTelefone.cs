namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Assinante-Telefone", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class AssinanteTelefone
    {
        private EnderecoAssinanteTelefone enderecoField;
        private string nomeField;
        private Telefone telefoneField;
        private TipoAssinanteTelefone tipotelefoneField;
        private bool tipotelefoneFieldSpecified;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public EnderecoAssinanteTelefone endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }

        [XmlAttribute("tipo-telefone")]
        public TipoAssinanteTelefone tipotelefone
        {
            get
            {
                return this.tipotelefoneField;
            }
            set
            {
                this.tipotelefoneField = value;
            }
        }

        [XmlIgnore]
        public bool tipotelefoneSpecified
        {
            get
            {
                return this.tipotelefoneFieldSpecified;
            }
            set
            {
                this.tipotelefoneFieldSpecified = value;
            }
        }
    }
}

