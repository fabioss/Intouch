namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName="Insumo-Consulta-Realizada", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoConsultaRealizada
    {
        private DateTime dataconsultaField;
        private bool dataconsultaFieldSpecified;
        private string nomeassociadoField;
        private string nomeentidadeorigemField;
        private Cidade origemassociadoField;

        [XmlAttribute("data-consulta")]
        public DateTime dataconsulta
        {
            get
            {
                return this.dataconsultaField;
            }
            set
            {
                this.dataconsultaField = value;
            }
        }

        [XmlIgnore]
        public bool dataconsultaSpecified
        {
            get
            {
                return this.dataconsultaFieldSpecified;
            }
            set
            {
                this.dataconsultaFieldSpecified = value;
            }
        }

        [XmlAttribute("nome-associado")]
        public string nomeassociado
        {
            get
            {
                return this.nomeassociadoField;
            }
            set
            {
                this.nomeassociadoField = value;
            }
        }

        [XmlAttribute("nome-entidade-origem")]
        public string nomeentidadeorigem
        {
            get
            {
                return this.nomeentidadeorigemField;
            }
            set
            {
                this.nomeentidadeorigemField = value;
            }
        }

        [XmlElement("origem-associado", Form=XmlSchemaForm.Unqualified)]
        public Cidade origemassociado
        {
            get
            {
                return this.origemassociadoField;
            }
            set
            {
                this.origemassociadoField = value;
            }
        }
    }
}

