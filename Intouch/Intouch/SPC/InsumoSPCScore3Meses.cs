namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-SPC-Score-3-Meses", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, DesignerCategory("code")]
    public class InsumoSPCScore3Meses
    {
        private string classeField;
        private int horizonteField;
        private string mesageminterpretativaprobabilidadeField;
        private string mesageminterpretativascoreField;
        private string mesagemsemaforoField;
        private double probabilidadeField;
        private bool probabilidadeFieldSpecified;
        private int scoreField;

        [XmlAttribute]
        public string classe
        {
            get
            {
                return this.classeField;
            }
            set
            {
                this.classeField = value;
            }
        }

        [XmlAttribute]
        public int horizonte
        {
            get
            {
                return this.horizonteField;
            }
            set
            {
                this.horizonteField = value;
            }
        }

        [XmlAttribute("mesagem-interpretativa-probabilidade")]
        public string mesageminterpretativaprobabilidade
        {
            get
            {
                return this.mesageminterpretativaprobabilidadeField;
            }
            set
            {
                this.mesageminterpretativaprobabilidadeField = value;
            }
        }

        [XmlAttribute("mesagem-interpretativa-score")]
        public string mesageminterpretativascore
        {
            get
            {
                return this.mesageminterpretativascoreField;
            }
            set
            {
                this.mesageminterpretativascoreField = value;
            }
        }

        [XmlAttribute("mesagem-semaforo")]
        public string mesagemsemaforo
        {
            get
            {
                return this.mesagemsemaforoField;
            }
            set
            {
                this.mesagemsemaforoField = value;
            }
        }

        [XmlAttribute]
        public double probabilidade
        {
            get
            {
                return this.probabilidadeField;
            }
            set
            {
                this.probabilidadeField = value;
            }
        }

        [XmlIgnore]
        public bool probabilidadeSpecified
        {
            get
            {
                return this.probabilidadeFieldSpecified;
            }
            set
            {
                this.probabilidadeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }
    }
}

