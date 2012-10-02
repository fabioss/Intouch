namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Protesto", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoProtesto
    {
        private CartaAnuencia cartaanuenciaField;
        private bool cartaanuenciaFieldSpecified;
        private Cartorio cartorioField;
        private DateTime datacartaanuenciaField;
        private bool datacartaanuenciaFieldSpecified;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private DateTime dataprotestoField;
        private bool dataprotestoFieldSpecified;
        private Moeda moedaField;
        private NaturezaAnotacao naturezaanotacaoField;
        private string numeroprotestoField;
        private string requerentecredorField;
        private Subjudice subjudiceField;
        private decimal valorField;
        private bool valorFieldSpecified;

        [XmlAttribute("carta-anuencia")]
        public CartaAnuencia cartaanuencia
        {
            get
            {
                return this.cartaanuenciaField;
            }
            set
            {
                this.cartaanuenciaField = value;
            }
        }

        [XmlIgnore]
        public bool cartaanuenciaSpecified
        {
            get
            {
                return this.cartaanuenciaFieldSpecified;
            }
            set
            {
                this.cartaanuenciaFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Cartorio cartorio
        {
            get
            {
                return this.cartorioField;
            }
            set
            {
                this.cartorioField = value;
            }
        }

        [XmlAttribute("data-carta-anuencia")]
        public DateTime datacartaanuencia
        {
            get
            {
                return this.datacartaanuenciaField;
            }
            set
            {
                this.datacartaanuenciaField = value;
            }
        }

        [XmlIgnore]
        public bool datacartaanuenciaSpecified
        {
            get
            {
                return this.datacartaanuenciaFieldSpecified;
            }
            set
            {
                this.datacartaanuenciaFieldSpecified = value;
            }
        }

        [XmlAttribute("data-inclusao")]
        public DateTime datainclusao
        {
            get
            {
                return this.datainclusaoField;
            }
            set
            {
                this.datainclusaoField = value;
            }
        }

        [XmlIgnore]
        public bool datainclusaoSpecified
        {
            get
            {
                return this.datainclusaoFieldSpecified;
            }
            set
            {
                this.datainclusaoFieldSpecified = value;
            }
        }

        [XmlAttribute("data-protesto")]
        public DateTime dataprotesto
        {
            get
            {
                return this.dataprotestoField;
            }
            set
            {
                this.dataprotestoField = value;
            }
        }

        [XmlIgnore]
        public bool dataprotestoSpecified
        {
            get
            {
                return this.dataprotestoFieldSpecified;
            }
            set
            {
                this.dataprotestoFieldSpecified = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Moeda moeda
        {
            get
            {
                return this.moedaField;
            }
            set
            {
                this.moedaField = value;
            }
        }

        [XmlElement("natureza-anotacao", Form=XmlSchemaForm.Unqualified)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
            }
        }

        [XmlAttribute("numero-protesto")]
        public string numeroprotesto
        {
            get
            {
                return this.numeroprotestoField;
            }
            set
            {
                this.numeroprotestoField = value;
            }
        }

        [XmlAttribute("requerente-credor")]
        public string requerentecredor
        {
            get
            {
                return this.requerentecredorField;
            }
            set
            {
                this.requerentecredorField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Subjudice subjudice
        {
            get
            {
                return this.subjudiceField;
            }
            set
            {
                this.subjudiceField = value;
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

