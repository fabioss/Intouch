namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Resumo-Insumo", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class ResumoInsumo
    {
        private DateTime dataultimaocorrenciaField;
        private bool dataultimaocorrenciaFieldSpecified;
        private int quantidadetotalField;
        private bool quantidadetotalFieldSpecified;
        private decimal valortotalField;
        private bool valortotalFieldSpecified;
        private decimal valorultimaocorrenciaField;
        private bool valorultimaocorrenciaFieldSpecified;

        [XmlAttribute("data-ultima-ocorrencia")]
        public DateTime dataultimaocorrencia
        {
            get
            {
                return this.dataultimaocorrenciaField;
            }
            set
            {
                this.dataultimaocorrenciaField = value;
            }
        }

        [XmlIgnore]
        public bool dataultimaocorrenciaSpecified
        {
            get
            {
                return this.dataultimaocorrenciaFieldSpecified;
            }
            set
            {
                this.dataultimaocorrenciaFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-total")]
        public int quantidadetotal
        {
            get
            {
                return this.quantidadetotalField;
            }
            set
            {
                this.quantidadetotalField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadetotalSpecified
        {
            get
            {
                return this.quantidadetotalFieldSpecified;
            }
            set
            {
                this.quantidadetotalFieldSpecified = value;
            }
        }

        [XmlAttribute("valor-total")]
        public decimal valortotal
        {
            get
            {
                return this.valortotalField;
            }
            set
            {
                this.valortotalField = value;
            }
        }

        [XmlIgnore]
        public bool valortotalSpecified
        {
            get
            {
                return this.valortotalFieldSpecified;
            }
            set
            {
                this.valortotalFieldSpecified = value;
            }
        }

        [XmlAttribute("valor-ultima-ocorrencia")]
        public decimal valorultimaocorrencia
        {
            get
            {
                return this.valorultimaocorrenciaField;
            }
            set
            {
                this.valorultimaocorrenciaField = value;
            }
        }

        [XmlIgnore]
        public bool valorultimaocorrenciaSpecified
        {
            get
            {
                return this.valorultimaocorrenciaFieldSpecified;
            }
            set
            {
                this.valorultimaocorrenciaFieldSpecified = value;
            }
        }
    }
}

