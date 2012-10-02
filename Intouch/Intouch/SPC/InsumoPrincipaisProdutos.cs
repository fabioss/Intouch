namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Insumo-Principais-Produtos", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoPrincipaisProdutos
    {
        private string descricaoprincipaisprodutosField;

        [XmlAttribute("descricao-principais-produtos")]
        public string descricaoprincipaisprodutos
        {
            get
            {
                return this.descricaoprincipaisprodutosField;
            }
            set
            {
                this.descricaoprincipaisprodutosField = value;
            }
        }
    }
}

