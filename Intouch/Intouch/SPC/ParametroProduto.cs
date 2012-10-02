namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(TypeName="Parametro-Produto", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class ParametroProduto
    {
        private string nomeField;
        private bool obrigatorioField;

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
        public bool obrigatorio
        {
            get
            {
                return this.obrigatorioField;
            }
            set
            {
                this.obrigatorioField = value;
            }
        }
    }
}

