namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Insumo-Rg", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoRg
    {
        private DateTime datanascimentorgField;
        private bool datanascimentorgFieldSpecified;
        private string fotoField;
        private string municipioField;
        private string nomeField;
        private string nomemaeField;
        private string nomepaiField;
        private string numerorgField;
        private string ufemissaorgField;

        [XmlAttribute("data-nascimento-rg")]
        public DateTime datanascimentorg
        {
            get
            {
                return this.datanascimentorgField;
            }
            set
            {
                this.datanascimentorgField = value;
            }
        }

        [XmlIgnore]
        public bool datanascimentorgSpecified
        {
            get
            {
                return this.datanascimentorgFieldSpecified;
            }
            set
            {
                this.datanascimentorgFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string foto
        {
            get
            {
                return this.fotoField;
            }
            set
            {
                this.fotoField = value;
            }
        }

        [XmlAttribute]
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
            }
        }

        [XmlAttribute]
        public string nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        [XmlAttribute("nome-mae")]
        public string nomemae
        {
            get
            {
                return this.nomemaeField;
            }
            set
            {
                this.nomemaeField = value;
            }
        }

        [XmlAttribute("nome-pai")]
        public string nomepai
        {
            get
            {
                return this.nomepaiField;
            }
            set
            {
                this.nomepaiField = value;
            }
        }

        [XmlAttribute("numero-rg")]
        public string numerorg
        {
            get
            {
                return this.numerorgField;
            }
            set
            {
                this.numerorgField = value;
            }
        }

        [XmlAttribute("uf-emissao-rg")]
        public string ufemissaorg
        {
            get
            {
                return this.ufemissaorgField;
            }
            set
            {
                this.ufemissaorgField = value;
            }
        }
    }
}

