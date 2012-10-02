namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Insumo-Historico-Conta-Corrente", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoHistoricoContaCorrente
    {
        private DateTime dataconsultamaisantigaField;
        private bool dataconsultamaisantigaFieldSpecified;
        private DateTime dataconsultamaisrecenteField;
        private bool dataconsultamaisrecenteFieldSpecified;
        private int quantidadeconsultasField;
        private bool quantidadeconsultasFieldSpecified;
        private Cheque ultimochequeconsultadoField;

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

        [XmlElement("ultimo-cheque-consultado", Form=XmlSchemaForm.Unqualified)]
        public Cheque ultimochequeconsultado
        {
            get
            {
                return this.ultimochequeconsultadoField;
            }
            set
            {
                this.ultimochequeconsultadoField = value;
            }
        }
    }
}

