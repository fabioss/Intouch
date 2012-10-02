namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Consulta-Realizada-Cheque", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoConsultaRealizadaCheque
    {
        private DateTime dataemissaoprimeirochequeField;
        private bool dataemissaoprimeirochequeFieldSpecified;
        private DateTime dataemissaoultimochequeField;
        private bool dataemissaoultimochequeFieldSpecified;
        private ReferenciaComercial[] referenciacomercialField;
        private int totalchequesaprazoemitidosField;
        private bool totalchequesaprazoemitidosFieldSpecified;
        private int totalchequesaprazoentre31e60diasField;
        private bool totalchequesaprazoentre31e60diasFieldSpecified;
        private int totalchequesaprazoentre61e90diasField;
        private bool totalchequesaprazoentre61e90diasFieldSpecified;
        private int totalchequesaprazoultimos30diasField;
        private bool totalchequesaprazoultimos30diasFieldSpecified;
        private int totalchequesavistaField;
        private bool totalchequesavistaFieldSpecified;

        [XmlAttribute("data-emissao-primeiro-cheque")]
        public DateTime dataemissaoprimeirocheque
        {
            get
            {
                return this.dataemissaoprimeirochequeField;
            }
            set
            {
                this.dataemissaoprimeirochequeField = value;
            }
        }

        [XmlIgnore]
        public bool dataemissaoprimeirochequeSpecified
        {
            get
            {
                return this.dataemissaoprimeirochequeFieldSpecified;
            }
            set
            {
                this.dataemissaoprimeirochequeFieldSpecified = value;
            }
        }

        [XmlAttribute("data-emissao-ultimo-cheque")]
        public DateTime dataemissaoultimocheque
        {
            get
            {
                return this.dataemissaoultimochequeField;
            }
            set
            {
                this.dataemissaoultimochequeField = value;
            }
        }

        [XmlIgnore]
        public bool dataemissaoultimochequeSpecified
        {
            get
            {
                return this.dataemissaoultimochequeFieldSpecified;
            }
            set
            {
                this.dataemissaoultimochequeFieldSpecified = value;
            }
        }

        [XmlElement("referencia-comercial", Form=XmlSchemaForm.Unqualified)]
        public ReferenciaComercial[] referenciacomercial
        {
            get
            {
                return this.referenciacomercialField;
            }
            set
            {
                this.referenciacomercialField = value;
            }
        }

        [XmlAttribute("total-cheques-a-prazo-emitidos")]
        public int totalchequesaprazoemitidos
        {
            get
            {
                return this.totalchequesaprazoemitidosField;
            }
            set
            {
                this.totalchequesaprazoemitidosField = value;
            }
        }

        [XmlIgnore]
        public bool totalchequesaprazoemitidosSpecified
        {
            get
            {
                return this.totalchequesaprazoemitidosFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoemitidosFieldSpecified = value;
            }
        }

        [XmlAttribute("total-cheques-a-prazo-entre-31-e-60dias")]
        public int totalchequesaprazoentre31e60dias
        {
            get
            {
                return this.totalchequesaprazoentre31e60diasField;
            }
            set
            {
                this.totalchequesaprazoentre31e60diasField = value;
            }
        }

        [XmlIgnore]
        public bool totalchequesaprazoentre31e60diasSpecified
        {
            get
            {
                return this.totalchequesaprazoentre31e60diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoentre31e60diasFieldSpecified = value;
            }
        }

        [XmlAttribute("total-cheques-a-prazo-entre-61-e-90dias")]
        public int totalchequesaprazoentre61e90dias
        {
            get
            {
                return this.totalchequesaprazoentre61e90diasField;
            }
            set
            {
                this.totalchequesaprazoentre61e90diasField = value;
            }
        }

        [XmlIgnore]
        public bool totalchequesaprazoentre61e90diasSpecified
        {
            get
            {
                return this.totalchequesaprazoentre61e90diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoentre61e90diasFieldSpecified = value;
            }
        }

        [XmlAttribute("total-cheques-a-prazo-ultimos-30dias")]
        public int totalchequesaprazoultimos30dias
        {
            get
            {
                return this.totalchequesaprazoultimos30diasField;
            }
            set
            {
                this.totalchequesaprazoultimos30diasField = value;
            }
        }

        [XmlIgnore]
        public bool totalchequesaprazoultimos30diasSpecified
        {
            get
            {
                return this.totalchequesaprazoultimos30diasFieldSpecified;
            }
            set
            {
                this.totalchequesaprazoultimos30diasFieldSpecified = value;
            }
        }

        [XmlAttribute("total-cheques-a-vista")]
        public int totalchequesavista
        {
            get
            {
                return this.totalchequesavistaField;
            }
            set
            {
                this.totalchequesavistaField = value;
            }
        }

        [XmlIgnore]
        public bool totalchequesavistaSpecified
        {
            get
            {
                return this.totalchequesavistaFieldSpecified;
            }
            set
            {
                this.totalchequesavistaFieldSpecified = value;
            }
        }
    }
}

