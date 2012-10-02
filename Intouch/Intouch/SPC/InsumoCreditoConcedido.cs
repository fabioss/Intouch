namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Credito-Concedido", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoCreditoConcedido
    {
        private int anovencimentoField;
        private bool anovencimentoFieldSpecified;
        private int mesvencimentoField;
        private bool mesvencimentoFieldSpecified;
        private int quantidadecreditoField;
        private bool quantidadecreditoFieldSpecified;
        private decimal valorField;
        private bool valorFieldSpecified;

        [XmlAttribute("ano-vencimento")]
        public int anovencimento
        {
            get
            {
                return this.anovencimentoField;
            }
            set
            {
                this.anovencimentoField = value;
            }
        }

        [XmlIgnore]
        public bool anovencimentoSpecified
        {
            get
            {
                return this.anovencimentoFieldSpecified;
            }
            set
            {
                this.anovencimentoFieldSpecified = value;
            }
        }

        [XmlAttribute("mes-vencimento")]
        public int mesvencimento
        {
            get
            {
                return this.mesvencimentoField;
            }
            set
            {
                this.mesvencimentoField = value;
            }
        }

        [XmlIgnore]
        public bool mesvencimentoSpecified
        {
            get
            {
                return this.mesvencimentoFieldSpecified;
            }
            set
            {
                this.mesvencimentoFieldSpecified = value;
            }
        }

        [XmlAttribute("quantidade-credito")]
        public int quantidadecredito
        {
            get
            {
                return this.quantidadecreditoField;
            }
            set
            {
                this.quantidadecreditoField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadecreditoSpecified
        {
            get
            {
                return this.quantidadecreditoFieldSpecified;
            }
            set
            {
                this.quantidadecreditoFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        [XmlIgnore]
        public bool valorSpecified
        {
            get
            {
                return this.valorFieldSpecified;
            }
            set
            {
                this.valorFieldSpecified = value;
            }
        }
    }
}

