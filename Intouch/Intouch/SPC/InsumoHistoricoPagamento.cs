namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Historico-Pagamento", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoHistoricoPagamento
    {
        private string descricaoperiodoField;
        private int percentualperiodoField;
        private bool percentualperiodoFieldSpecified;
        private int quantidadefontesField;
        private bool quantidadefontesFieldSpecified;
        private int quantidadeperiodoField;
        private bool quantidadeperiodoFieldSpecified;

        [XmlAttribute("descricao-periodo")]
        public string descricaoperiodo
        {
            get
            {
                return this.descricaoperiodoField;
            }
            set
            {
                this.descricaoperiodoField = value;
            }
        }

        [XmlAttribute("percentual-periodo")]
        public int percentualperiodo
        {
            get
            {
                return this.percentualperiodoField;
            }
            set
            {
                this.percentualperiodoField = value;
            }
        }

        [XmlIgnore]
        public bool percentualperiodoSpecified
        {
            get
            {
                return this.percentualperiodoFieldSpecified;
            }
            set
            {
                this.percentualperiodoFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-fontes")]
        public int quantidadefontes
        {
            get
            {
                return this.quantidadefontesField;
            }
            set
            {
                this.quantidadefontesField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadefontesSpecified
        {
            get
            {
                return this.quantidadefontesFieldSpecified;
            }
            set
            {
                this.quantidadefontesFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-periodo")]
        public int quantidadeperiodo
        {
            get
            {
                return this.quantidadeperiodoField;
            }
            set
            {
                this.quantidadeperiodoField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeperiodoSpecified
        {
            get
            {
                return this.quantidadeperiodoFieldSpecified;
            }
            set
            {
                this.quantidadeperiodoFieldSpecified = value;
            }
        }
    }
}

