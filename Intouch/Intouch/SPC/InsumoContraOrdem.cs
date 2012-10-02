namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(InsumoContumacia)), XmlInclude(typeof(InsumoContraOrdemDocumentoDiferente)), XmlType(TypeName="Insumo-Contra-Ordem", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(InsumoContraOrdemAgenciaContaDiferente)), XmlInclude(typeof(InsumoContraOrdemAgenciaDiferente))]
    public class InsumoContraOrdem
    {
        private ChequeFinal chequefinalField;
        private ChequeContraOrdem chequeinicialField;
        private DateTime datainclusaoField;
        private bool datainclusaoFieldSpecified;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private string informanteField;
        private Alinea motivoField;
        private string origemField;

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
        public ChequeContraOrdem chequeinicial
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

        [XmlAttribute("data-ocorrencia")]
        public DateTime dataocorrencia
        {
            get
            {
                return this.dataocorrenciaField;
            }
            set
            {
                this.dataocorrenciaField = value;
            }
        }

        [XmlIgnore]
        public bool dataocorrenciaSpecified
        {
            get
            {
                return this.dataocorrenciaFieldSpecified;
            }
            set
            {
                this.dataocorrenciaFieldSpecified = value;
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

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Alinea motivo
        {
            get
            {
                return this.motivoField;
            }
            set
            {
                this.motivoField = value;
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

