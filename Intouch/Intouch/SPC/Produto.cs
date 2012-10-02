namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, DesignerCategory("code")]
    public class Produto
    {
        private string codigoField;
        private InsumoProduto[] insumoopcionalField;
        private InsumoProduto[] insumoretornoField;
        private string nomeField;
        private ParametroProduto[] parametroField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        [XmlElement("insumo-opcional", Form=XmlSchemaForm.Unqualified)]
        public InsumoProduto[] insumoopcional
        {
            get
            {
                return this.insumoopcionalField;
            }
            set
            {
                this.insumoopcionalField = value;
            }
        }

        [XmlElement("insumo-retorno", Form=XmlSchemaForm.Unqualified)]
        public InsumoProduto[] insumoretorno
        {
            get
            {
                return this.insumoretornoField;
            }
            set
            {
                this.insumoretornoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement("parametro", Form=XmlSchemaForm.Unqualified)]
        public ParametroProduto[] parametro
        {
            get
            {
                return this.parametroField;
            }
            set
            {
                this.parametroField = value;
            }
        }
    }
}

