namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Ultimas-Consultas", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoUltimasConsultas
    {
        private DateTime dataconsultaField;
        private bool dataconsultaFieldSpecified;
        private string nomeclienteconsultanteField;
        private int quantidadeconsultaField;
        private bool quantidadeconsultaFieldSpecified;

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

        [XmlAttribute("nome-cliente-consultante")]
        public string nomeclienteconsultante
        {
            get
            {
                return this.nomeclienteconsultanteField;
            }
            set
            {
                this.nomeclienteconsultanteField = value;
            }
        }

        [XmlAttribute("quantidade-consulta")]
        public int quantidadeconsulta
        {
            get
            {
                return this.quantidadeconsultaField;
            }
            set
            {
                this.quantidadeconsultaField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeconsultaSpecified
        {
            get
            {
                return this.quantidadeconsultaFieldSpecified;
            }
            set
            {
                this.quantidadeconsultaFieldSpecified = value;
            }
        }
    }
}

