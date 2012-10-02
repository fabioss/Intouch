namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Cheque-Consulta-Online-SRS", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoChequeConsultaOnlineSRS
    {
        private DateTime datasituacaocontacorrenteField;
        private bool datasituacaocontacorrenteFieldSpecified;
        private string mensagemsituacaocontacorrenteField;
        private OcorrenciaRechequeOnline ocorrenciarechequeonlineField;
        private string tipodocumentoidentificacaoField;
        private string tipopessoarechequeonlineField;

        [XmlAttribute("data-situacao-conta-corrente")]
        public DateTime datasituacaocontacorrente
        {
            get
            {
                return this.datasituacaocontacorrenteField;
            }
            set
            {
                this.datasituacaocontacorrenteField = value;
            }
        }

        [XmlIgnore]
        public bool datasituacaocontacorrenteSpecified
        {
            get
            {
                return this.datasituacaocontacorrenteFieldSpecified;
            }
            set
            {
                this.datasituacaocontacorrenteFieldSpecified = value;
            }
        }

        [XmlAttribute("mensagem-situacao-conta-corrente")]
        public string mensagemsituacaocontacorrente
        {
            get
            {
                return this.mensagemsituacaocontacorrenteField;
            }
            set
            {
                this.mensagemsituacaocontacorrenteField = value;
            }
        }

        [XmlElement("ocorrencia-recheque-online", Form=XmlSchemaForm.Unqualified)]
        public OcorrenciaRechequeOnline ocorrenciarechequeonline
        {
            get
            {
                return this.ocorrenciarechequeonlineField;
            }
            set
            {
                this.ocorrenciarechequeonlineField = value;
            }
        }

        [XmlAttribute("tipo-documento-identificacao")]
        public string tipodocumentoidentificacao
        {
            get
            {
                return this.tipodocumentoidentificacaoField;
            }
            set
            {
                this.tipodocumentoidentificacaoField = value;
            }
        }

        [XmlAttribute("tipo-pessoa-recheque-online")]
        public string tipopessoarechequeonline
        {
            get
            {
                return this.tipopessoarechequeonlineField;
            }
            set
            {
                this.tipopessoarechequeonlineField = value;
            }
        }
    }
}

