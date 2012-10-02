namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(EnderecoAssinanteTelefone)), DebuggerStepThrough, XmlInclude(typeof(EnderecoOcorrenciaConsumidor)), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class Endereco
    {
        private string bairroField;
        private int cepField;
        private bool cepFieldSpecified;
        private Cidade cidadeField;
        private string complementoField;
        private string logradouroField;
        private string numeroField;

        [XmlAttribute]
        public string bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }

        [XmlAttribute]
        public int cep
        {
            get
            {
                return this.cepField;
            }
            set
            {
                this.cepField = value;
            }
        }

        [XmlIgnore]
        public bool cepSpecified
        {
            get
            {
                return this.cepFieldSpecified;
            }
            set
            {
                this.cepFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cidade cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }

        [XmlAttribute]
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        [XmlAttribute]
        public string logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
            }
        }

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

