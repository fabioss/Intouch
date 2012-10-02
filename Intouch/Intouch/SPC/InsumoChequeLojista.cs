namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Cheque-Lojista", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoChequeLojista
    {
        private Alinea alineaField;
        private ChequeFinal chequefinalField;
        private ChequeLojista chequeinicialField;
        private Cidade cidadeassociadoField;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private string informanteField;
        private string nomeassociadoField;
        private string nomeentidadeField;
        private string origemField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Alinea alinea
        {
            get
            {
                return this.alineaField;
            }
            set
            {
                this.alineaField = value;
            }
        }

        [XmlElement("cheque-final", Form=XmlSchemaForm.Unqualified)]
        public ChequeFinal chequefinal
        {
            get
            {
                return this.chequefinalField;
            }
            set
            {
                this.chequefinalField = value;
            }
        }

        [XmlElement("cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public ChequeLojista chequeinicial
        {
            get
            {
                return this.chequeinicialField;
            }
            set
            {
                this.chequeinicialField = value;
            }
        }

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

        [XmlAttribute]
        public string informante
        {
            get
            {
                return this.informanteField;
            }
            set
            {
                this.informanteField = value;
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
        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
            }
        }
    }
}

