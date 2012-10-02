namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Antecessora", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class InsumoAntecessora
    {
        private DateTime datamotivoField;
        private bool datamotivoFieldSpecified;
        private string razaosocialanteriorField;

        [XmlAttribute("data-motivo")]
        public DateTime datamotivo
        {
            get
            {
                return this.datamotivoField;
            }
            set
            {
                this.datamotivoField = value;
            }
        }

        [XmlIgnore]
        public bool datamotivoSpecified
        {
            get
            {
                return this.datamotivoFieldSpecified;
            }
            set
            {
                this.datamotivoFieldSpecified = value;
            }
        }

        [XmlAttribute("razao-social-anterior")]
        public string razaosocialanterior
        {
            get
            {
                return this.razaosocialanteriorField;
            }
            set
            {
                this.razaosocialanteriorField = value;
            }
        }
    }
}

