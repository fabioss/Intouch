namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Referencia-Comercial", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class ReferenciaComercial
    {
        private DateTime dataconsultachequeField;
        private bool dataconsultachequeFieldSpecified;
        private string nomeempresaconsultanteField;
        private int ordemconsultaField;
        private bool ordemconsultaFieldSpecified;

        [XmlAttribute("data-consulta-cheque")]
        public DateTime dataconsultacheque
        {
            get
            {
                return this.dataconsultachequeField;
            }
            set
            {
                this.dataconsultachequeField = value;
            }
        }

        [XmlIgnore]
        public bool dataconsultachequeSpecified
        {
            get
            {
                return this.dataconsultachequeFieldSpecified;
            }
            set
            {
                this.dataconsultachequeFieldSpecified = value;
            }
        }

        [XmlAttribute("nome-empresa-consultante")]
        public string nomeempresaconsultante
        {
            get
            {
                return this.nomeempresaconsultanteField;
            }
            set
            {
                this.nomeempresaconsultanteField = value;
            }
        }

        [XmlAttribute("ordem-consulta")]
        public int ordemconsulta
        {
            get
            {
                return this.ordemconsultaField;
            }
            set
            {
                this.ordemconsultaField = value;
            }
        }

        [XmlIgnore]
        public bool ordemconsultaSpecified
        {
            get
            {
                return this.ordemconsultaFieldSpecified;
            }
            set
            {
                this.ordemconsultaFieldSpecified = value;
            }
        }
    }
}

