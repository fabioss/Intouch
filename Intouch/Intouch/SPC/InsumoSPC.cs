namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-SPC", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoSPC
    {
        private Cidade cidadeassociadoField;
        private string compradorfiadoravalistaField;
        private string contratoField;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private DateTime datavencimentoField;
        private bool datavencimentoFieldSpecified;
        private string nomeassociadoField;
        private string nomeentidadeField;
        private decimal valorField;
        private bool valorFieldSpecified;

        [XmlElement("cidade-associado", Form=XmlSchemaForm.Unqualified)]
        public Cidade cidadeassociado
        {
            get
            {
                return this.cidadeassociadoField;
            }
            set
            {
                this.cidadeassociadoField = value;
            }
        }

        [XmlAttribute("comprador-fiador-avalista")]
        public string compradorfiadoravalista
        {
            get
            {
                return this.compradorfiadoravalistaField;
            }
            set
            {
                this.compradorfiadoravalistaField = value;
            }
        }

        [XmlAttribute]
        public string contrato
        {
            get
            {
                return this.contratoField;
            }
            set
            {
                this.contratoField = value;
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

        [XmlAttribute("data-vencimento")]
        public DateTime datavencimento
        {
            get
            {
                return this.datavencimentoField;
            }
            set
            {
                this.datavencimentoField = value;
            }
        }

        [XmlIgnore]
        public bool datavencimentoSpecified
        {
            get
            {
                return this.datavencimentoFieldSpecified;
            }
            set
            {
                this.datavencimentoFieldSpecified = value;
            }
        }

        [XmlAttribute("nome-associado")]
        public string nomeassociado
        {
            get
            {
                return this.nomeassociadoField;
            }
            set
            {
                this.nomeassociadoField = value;
            }
        }

        [XmlAttribute("nome-entidade")]
        public string nomeentidade
        {
            get
            {
                return this.nomeentidadeField;
            }
            set
            {
                this.nomeentidadeField = value;
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

