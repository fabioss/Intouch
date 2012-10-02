namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Filial", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough]
    public class InsumoFilial
    {
        private string codigoembratelField;
        private string nomefilialField;

        [XmlAttribute("codigo-embratel")]
        public string codigoembratel
        {
            get
            {
                return this.codigoembratelField;
            }
            set
            {
                this.codigoembratelField = value;
            }
        }

        [XmlAttribute("nome-filial")]
        public string nomefilial
        {
            get
            {
                return this.nomefilialField;
            }
            set
            {
                this.nomefilialField = value;
            }
        }
    }
}

