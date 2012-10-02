namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Dados-Bancarios", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class DadosBancarios
    {
        private Banco bancoField;
        private string digitocontacorrenteField;
        private Endereco enderecoField;
        private Telefone faxField;
        private string nomeagenciaField;
        private int numeroagenciaField;
        private bool numeroagenciaFieldSpecified;
        private string numerocontacorrenteField;
        private Telefone telefoneField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Banco banco
        {
            get
            {
                return this.bancoField;
            }
            set
            {
                this.bancoField = value;
            }
        }

        [XmlAttribute("digito-conta-corrente")]
        public string digitocontacorrente
        {
            get
            {
                return this.digitocontacorrenteField;
            }
            set
            {
                this.digitocontacorrenteField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Endereco endereco
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Telefone fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        [XmlAttribute("nome-agencia")]
        public string nomeagencia
        {
            get
            {
                return this.nomeagenciaField;
            }
            set
            {
                this.nomeagenciaField = value;
            }
        }

        [XmlAttribute("numero-agencia")]
        public int numeroagencia
        {
            get
            {
                return this.numeroagenciaField;
            }
            set
            {
                this.numeroagenciaField = value;
            }
        }

        [XmlIgnore]
        public bool numeroagenciaSpecified
        {
            get
            {
                return this.numeroagenciaFieldSpecified;
            }
            set
            {
                this.numeroagenciaFieldSpecified = value;
            }
        }

        [XmlAttribute("numero-conta-corrente")]
        public string numerocontacorrente
        {
            get
            {
                return this.numerocontacorrenteField;
            }
            set
            {
                this.numerocontacorrenteField = value;
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
    }
}

