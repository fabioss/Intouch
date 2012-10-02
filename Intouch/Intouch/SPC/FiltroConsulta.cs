namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Filtro-Consulta", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class FiltroConsulta
    {
        private int agenciachequeinicialField;
        private bool agenciachequeinicialFieldSpecified;
        private int bancochequeinicialField;
        private bool bancochequeinicialFieldSpecified;
        private string cepconsumidorField;
        private string ceporigemField;
        private ChequeFiltro[] chequedetalhadoField;
        private string cmc71chequeinicialField;
        private string cmc72chequeinicialField;
        private string cmc73chequeinicialField;
        private string codigoestacaoconsultanteField;
        private long[] codigoinsumoopcionalField;
        private string codigoprodutoField;
        private long contacorrentechequeinicialField;
        private bool contacorrentechequeinicialFieldSpecified;
        private DateTime datanascimentorgField;
        private bool datanascimentorgFieldSpecified;
        private int digitochequeinicialField;
        private bool digitochequeinicialFieldSpecified;
        private string digitocontacorrentechequeinicialField;
        private string documentoconsumidorField;
        private int numerochequeinicialField;
        private bool numerochequeinicialFieldSpecified;
        private string numerorgField;
        private int quantidadechequeField;
        private bool quantidadechequeFieldSpecified;
        private TelefoneFiltro telefoneconsultarField;
        private TipoPessoa tipoconsumidorField;
        private bool tipoconsumidorFieldSpecified;
        private string ufemissaorgField;
        private bool utilizaCMC7Field;
        private bool utilizaCMC7FieldSpecified;

        [XmlElement("agencia-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public int agenciachequeinicial
        {
            get
            {
                return this.agenciachequeinicialField;
            }
            set
            {
                this.agenciachequeinicialField = value;
            }
        }

        [XmlIgnore]
        public bool agenciachequeinicialSpecified
        {
            get
            {
                return this.agenciachequeinicialFieldSpecified;
            }
            set
            {
                this.agenciachequeinicialFieldSpecified = value;
            }
        }

        [XmlElement("banco-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public int bancochequeinicial
        {
            get
            {
                return this.bancochequeinicialField;
            }
            set
            {
                this.bancochequeinicialField = value;
            }
        }

        [XmlIgnore]
        public bool bancochequeinicialSpecified
        {
            get
            {
                return this.bancochequeinicialFieldSpecified;
            }
            set
            {
                this.bancochequeinicialFieldSpecified = value;
            }
        }

        [XmlElement("cep-consumidor", Form=XmlSchemaForm.Unqualified)]
        public string cepconsumidor
        {
            get
            {
                return this.cepconsumidorField;
            }
            set
            {
                this.cepconsumidorField = value;
            }
        }

        [XmlElement("cep-origem", Form=XmlSchemaForm.Unqualified)]
        public string ceporigem
        {
            get
            {
                return this.ceporigemField;
            }
            set
            {
                this.ceporigemField = value;
            }
        }

        [XmlElement("cheque-detalhado", Form=XmlSchemaForm.Unqualified)]
        public ChequeFiltro[] chequedetalhado
        {
            get
            {
                return this.chequedetalhadoField;
            }
            set
            {
                this.chequedetalhadoField = value;
            }
        }

        [XmlElement("cmc71-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public string cmc71chequeinicial
        {
            get
            {
                return this.cmc71chequeinicialField;
            }
            set
            {
                this.cmc71chequeinicialField = value;
            }
        }

        [XmlElement("cmc72-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public string cmc72chequeinicial
        {
            get
            {
                return this.cmc72chequeinicialField;
            }
            set
            {
                this.cmc72chequeinicialField = value;
            }
        }

        [XmlElement("cmc73-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public string cmc73chequeinicial
        {
            get
            {
                return this.cmc73chequeinicialField;
            }
            set
            {
                this.cmc73chequeinicialField = value;
            }
        }

        [XmlElement("codigo-estacao-consultante", Form=XmlSchemaForm.Unqualified)]
        public string codigoestacaoconsultante
        {
            get
            {
                return this.codigoestacaoconsultanteField;
            }
            set
            {
                this.codigoestacaoconsultanteField = value;
            }
        }

        [XmlElement("codigo-insumo-opcional", Form=XmlSchemaForm.Unqualified)]
        public long[] codigoinsumoopcional
        {
            get
            {
                return this.codigoinsumoopcionalField;
            }
            set
            {
                this.codigoinsumoopcionalField = value;
            }
        }

        [XmlElement("codigo-produto", Form=XmlSchemaForm.Unqualified)]
        public string codigoproduto
        {
            get
            {
                return this.codigoprodutoField;
            }
            set
            {
                this.codigoprodutoField = value;
            }
        }

        [XmlElement("conta-corrente-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public long contacorrentechequeinicial
        {
            get
            {
                return this.contacorrentechequeinicialField;
            }
            set
            {
                this.contacorrentechequeinicialField = value;
            }
        }

        [XmlIgnore]
        public bool contacorrentechequeinicialSpecified
        {
            get
            {
                return this.contacorrentechequeinicialFieldSpecified;
            }
            set
            {
                this.contacorrentechequeinicialFieldSpecified = value;
            }
        }

        [XmlElement("data-nascimento-rg", Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement("digito-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public int digitochequeinicial
        {
            get
            {
                return this.digitochequeinicialField;
            }
            set
            {
                this.digitochequeinicialField = value;
            }
        }

        [XmlIgnore]
        public bool digitochequeinicialSpecified
        {
            get
            {
                return this.digitochequeinicialFieldSpecified;
            }
            set
            {
                this.digitochequeinicialFieldSpecified = value;
            }
        }

        [XmlElement("digito-conta-corrente-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public string digitocontacorrentechequeinicial
        {
            get
            {
                return this.digitocontacorrentechequeinicialField;
            }
            set
            {
                this.digitocontacorrentechequeinicialField = value;
            }
        }

        [XmlElement("documento-consumidor", Form=XmlSchemaForm.Unqualified)]
        public string documentoconsumidor
        {
            get
            {
                return this.documentoconsumidorField;
            }
            set
            {
                this.documentoconsumidorField = value;
            }
        }

        [XmlElement("numero-cheque-inicial", Form=XmlSchemaForm.Unqualified)]
        public int numerochequeinicial
        {
            get
            {
                return this.numerochequeinicialField;
            }
            set
            {
                this.numerochequeinicialField = value;
            }
        }

        [XmlIgnore]
        public bool numerochequeinicialSpecified
        {
            get
            {
                return this.numerochequeinicialFieldSpecified;
            }
            set
            {
                this.numerochequeinicialFieldSpecified = value;
            }
        }

        [XmlElement("numero-rg", Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement("quantidade-cheque", Form=XmlSchemaForm.Unqualified)]
        public int quantidadecheque
        {
            get
            {
                return this.quantidadechequeField;
            }
            set
            {
                this.quantidadechequeField = value;
            }
        }

        [XmlIgnore]
        public bool quantidadechequeSpecified
        {
            get
            {
                return this.quantidadechequeFieldSpecified;
            }
            set
            {
                this.quantidadechequeFieldSpecified = value;
            }
        }

        [XmlElement("telefone-consultar", Form=XmlSchemaForm.Unqualified)]
        public TelefoneFiltro telefoneconsultar
        {
            get
            {
                return this.telefoneconsultarField;
            }
            set
            {
                this.telefoneconsultarField = value;
            }
        }

        [XmlElement("tipo-consumidor", Form=XmlSchemaForm.Unqualified)]
        public TipoPessoa tipoconsumidor
        {
            get
            {
                return this.tipoconsumidorField;
            }
            set
            {
                this.tipoconsumidorField = value;
            }
        }

        [XmlIgnore]
        public bool tipoconsumidorSpecified
        {
            get
            {
                return this.tipoconsumidorFieldSpecified;
            }
            set
            {
                this.tipoconsumidorFieldSpecified = value;
            }
        }

        [XmlElement("uf-emissao-rg", Form=XmlSchemaForm.Unqualified)]
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

        [XmlElement("utiliza-CMC7", Form=XmlSchemaForm.Unqualified)]
        public bool utilizaCMC7
        {
            get
            {
                return this.utilizaCMC7Field;
            }
            set
            {
                this.utilizaCMC7Field = value;
            }
        }

        [XmlIgnore]
        public bool utilizaCMC7Specified
        {
            get
            {
                return this.utilizaCMC7FieldSpecified;
            }
            set
            {
                this.utilizaCMC7FieldSpecified = value;
            }
        }
    }
}

