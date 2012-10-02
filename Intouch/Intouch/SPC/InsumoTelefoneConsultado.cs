namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Telefone-Consultado", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class InsumoTelefoneConsultado
    {
        private DateTime dataprimeiraconsultaField;
        private bool dataprimeiraconsultaFieldSpecified;
        private DateTime dataultimaconsultaField;
        private bool dataultimaconsultaFieldSpecified;
        private long quantidadeconsultaField;
        private bool quantidadeconsultaFieldSpecified;
        private Telefone telefoneField;

        [XmlAttribute("data-primeira-consulta")]
        public DateTime dataprimeiraconsulta
        {
            get
            {
                return this.dataprimeiraconsultaField;
            }
            set
            {
                this.dataprimeiraconsultaField = value;
            }
        }

        [XmlIgnore]
        public bool dataprimeiraconsultaSpecified
        {
            get
            {
                return this.dataprimeiraconsultaFieldSpecified;
            }
            set
            {
                this.dataprimeiraconsultaFieldSpecified = value;
            }
        }

        [XmlAttribute("data-ultima-consulta")]
        public DateTime dataultimaconsulta
        {
            get
            {
                return this.dataultimaconsultaField;
            }
            set
            {
                this.dataultimaconsultaField = value;
            }
        }

        [XmlIgnore]
        public bool dataultimaconsultaSpecified
        {
            get
            {
                return this.dataultimaconsultaFieldSpecified;
            }
            set
            {
                this.dataultimaconsultaFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-consulta")]
        public long quantidadeconsulta
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Telefone telefone
        {
            get
            {
                return this.telefoneField;
            }
            set
            {
                this.telefoneField = value;
            }
        }
    }
}

