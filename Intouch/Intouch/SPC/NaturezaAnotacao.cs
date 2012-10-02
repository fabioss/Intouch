namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Natureza-Anotacao", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class NaturezaAnotacao
    {
        private string descricaocomplementarnaturezaanotacaoField;
        private string descricaonaturezaanotacaoField;

        [XmlAttribute("descricao-complementar-natureza-anotacao")]
        public string descricaocomplementarnaturezaanotacao
        {
            get
            {
                return this.descricaocomplementarnaturezaanotacaoField;
            }
            set
            {
                this.descricaocomplementarnaturezaanotacaoField = value;
            }
        }

        [XmlAttribute("descricao-natureza-anotacao")]
        public string descricaonaturezaanotacao
        {
            get
            {
                return this.descricaonaturezaanotacaoField;
            }
            set
            {
                this.descricaonaturezaanotacaoField = value;
            }
        }
    }
}

