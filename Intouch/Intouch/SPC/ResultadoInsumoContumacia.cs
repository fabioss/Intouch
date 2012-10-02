namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Resultado-Insumo-Contumacia", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough]
    public class ResultadoInsumoContumacia : ResultadoInsumo
    {
        private DateTime datafinalperiodoconsultadoField;
        private bool datafinalperiodoconsultadoFieldSpecified;
        private DateTime datainicialperiodoconsultadoField;
        private bool datainicialperiodoconsultadoFieldSpecified;

        [XmlAttribute("data-final-periodo-consultado")]
        public DateTime datafinalperiodoconsultado
        {
            get
            {
                return this.datafinalperiodoconsultadoField;
            }
            set
            {
                this.datafinalperiodoconsultadoField = value;
            }
        }

        [XmlIgnore]
        public bool datafinalperiodoconsultadoSpecified
        {
            get
            {
                return this.datafinalperiodoconsultadoFieldSpecified;
            }
            set
            {
                this.datafinalperiodoconsultadoFieldSpecified = value;
            }
        }

        [XmlAttribute("data-inicial-periodo-consultado")]
        public DateTime datainicialperiodoconsultado
        {
            get
            {
                return this.datainicialperiodoconsultadoField;
            }
            set
            {
                this.datainicialperiodoconsultadoField = value;
            }
        }

        [XmlIgnore]
        public bool datainicialperiodoconsultadoSpecified
        {
            get
            {
                return this.datainicialperiodoconsultadoFieldSpecified;
            }
            set
            {
                this.datainicialperiodoconsultadoFieldSpecified = value;
            }
        }
    }
}

