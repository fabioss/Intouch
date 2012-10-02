namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlInclude(typeof(InsumoHistoricoChequeDocumentoDiferente)), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Historico-Cheque", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class InsumoHistoricoCheque
    {
        private Cheque chequeconsultadoField;
        private DateTime dataconsultamaisantigaField;
        private bool dataconsultamaisantigaFieldSpecified;
        private DateTime dataconsultamaisrecenteField;
        private bool dataconsultamaisrecenteFieldSpecified;
        private string nomeempresaultimaconsultaField;
        private int quantidadeconsultasField;
        private bool quantidadeconsultasFieldSpecified;

        [XmlElement("cheque-consultado", Form=XmlSchemaForm.Unqualified)]
        public Cheque chequeconsultado
        {
            get
            {
                return this.chequeconsultadoField;
            }
            set
            {
                this.chequeconsultadoField = value;
            }
        }

        [XmlAttribute("data-consulta-mais-antiga")]
        public DateTime dataconsultamaisantiga
        {
            get
            {
                return this.dataconsultamaisantigaField;
            }
            set
            {
                this.dataconsultamaisantigaField = value;
            }
        }

        [XmlIgnore]
        public bool dataconsultamaisantigaSpecified
        {
            get
            {
                return this.dataconsultamaisantigaFieldSpecified;
            }
            set
            {
                this.dataconsultamaisantigaFieldSpecified = value;
            }
        }

        [XmlAttribute("data-consulta-mais-recente")]
        public DateTime dataconsultamaisrecente
        {
            get
            {
                return this.dataconsultamaisrecenteField;
            }
            set
            {
                this.dataconsultamaisrecenteField = value;
            }
        }

        [XmlIgnore]
        public bool dataconsultamaisrecenteSpecified
        {
            get
            {
                return this.dataconsultamaisrecenteFieldSpecified;
            }
            set
            {
                this.dataconsultamaisrecenteFieldSpecified = value;
            }
        }

        [XmlAttribute("nome-empresa-ultima-consulta")]
        public string nomeempresaultimaconsulta
        {
            get
            {
                return this.nomeempresaultimaconsultaField;
            }
            set
            {
                this.nomeempresaultimaconsultaField = value;
            }
        }

        [XmlAttribute("quantidade-consultas")]
        public int quantidadeconsultas
        {
            get
            {
                return this.quantidadeconsultasField;
            }
            set
            {
                this.quantidadeconsultasField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadeconsultasSpecified
        {
            get
            {
                return this.quantidadeconsultasFieldSpecified;
            }
            set
            {
                this.quantidadeconsultasFieldSpecified = value;
            }
        }
    }
}

