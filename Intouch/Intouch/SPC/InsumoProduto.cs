namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Produto", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoProduto
    {
        private long codigoField;
        private bool codigoFieldSpecified;
        private string nomeField;
        private bool opcionalField;

        [XmlAttribute]
        public long codigo
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

        [XmlIgnore]
        public bool codigoSpecified
        {
            get
            {
                return this.codigoFieldSpecified;
            }
            set
            {
                this.codigoFieldSpecified = value;
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

        [XmlAttribute]
        public bool opcional
        {
            get
            {
                return this.opcionalField;
            }
            set
            {
                this.opcionalField = value;
            }
        }
    }
}

