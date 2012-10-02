namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Resultado-Insumo-Consulta-Realizada", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class ResultadoInsumoConsultaRealizada : ResultadoInsumo
    {
        private int quantidadediasconsultadosField;
        private bool quantidadediasconsultadosFieldSpecified;

        [XmlAttribute("quantidade-dias-consultados")]
        public int quantidadediasconsultados
        {
            get
            {
                return this.quantidadediasconsultadosField;
            }
            set
            {
                this.quantidadediasconsultadosField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadediasconsultadosSpecified
        {
            get
            {
                return this.quantidadediasconsultadosFieldSpecified;
            }
            set
            {
                this.quantidadediasconsultadosFieldSpecified = value;
            }
        }
    }
}

