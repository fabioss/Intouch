namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(TypeName="Insumo-Registro-Consultas", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoRegistroConsultas
    {
        private DateTime dataconsultaField;
        private bool dataconsultaFieldSpecified;
        private int quantidadeconsultabancoField;
        private bool quantidadeconsultabancoFieldSpecified;
        private int quantidadeconsultaempresaField;
        private bool quantidadeconsultaempresaFieldSpecified;

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

        [XmlAttribute("quantidade-consulta-banco")]
        public int quantidadeconsultabanco
        {
            get
            {
                return this.quantidadeconsultabancoField;
            }
            set
            {
                this.quantidadeconsultabancoField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeconsultabancoSpecified
        {
            get
            {
                return this.quantidadeconsultabancoFieldSpecified;
            }
            set
            {
                this.quantidadeconsultabancoFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-consulta-empresa")]
        public int quantidadeconsultaempresa
        {
            get
            {
                return this.quantidadeconsultaempresaField;
            }
            set
            {
                this.quantidadeconsultaempresaField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeconsultaempresaSpecified
        {
            get
            {
                return this.quantidadeconsultaempresaFieldSpecified;
            }
            set
            {
                this.quantidadeconsultaempresaFieldSpecified = value;
            }
        }
    }
}

