namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Natureza-Juridica", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough]
    public class NaturezaJuridica
    {
        private long codigoField;
        private bool codigoFieldSpecified;
        private string descricaoField;

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
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }
}

