namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlInclude(typeof(InsumoContraOrdemSRS)), XmlInclude(typeof(InsumoChequeOutrasOcorrenciasSRS)), XmlType(TypeName="Insumo-Contumacia-SRS", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(InsumoContraOrdemDocumentoDiferenteSRS))]
    public class InsumoContumaciaSRS
    {
        private Cheque chequefinalField;
        private Cheque chequeinicialField;
        private DateTime dataocorrenciaField;
        private bool dataocorrenciaFieldSpecified;
        private string motivoField;

        [XmlElement("cheque-final", Form=XmlSchemaForm.Unqualified)]
        public Cheque chequefinal
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
        public Cheque chequeinicial
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
        public string motivo
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
    }
}

