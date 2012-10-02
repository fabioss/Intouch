namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Resultado-Insumo-Contra-Ordem", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class ResultadoInsumoContraOrdem : ResultadoInsumo
    {
        private int quantidadetaloescontraordenadosField;
        private bool quantidadetaloescontraordenadosFieldSpecified;

        [XmlAttribute("quantidade-taloes-contra-ordenados")]
        public int quantidadetaloescontraordenados
        {
            get
            {
                return this.quantidadetaloescontraordenadosField;
            }
            set
            {
                this.quantidadetaloescontraordenadosField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadetaloescontraordenadosSpecified
        {
            get
            {
                return this.quantidadetaloescontraordenadosFieldSpecified;
            }
            set
            {
                this.quantidadetaloescontraordenadosFieldSpecified = value;
            }
        }
    }
}

