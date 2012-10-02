namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName="Situacao-Documento-WS", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class SituacaoDocumentoWS
    {
        private DateTime datasituacaoField;
        private bool datasituacaoFieldSpecified;
        private string descricaosituacaoField;
        private string ufField;

        [XmlAttribute("data-situacao")]
        public DateTime datasituacao
        {
            get
            {
                return this.datasituacaoField;
            }
            set
            {
                this.datasituacaoField = value;
            }
        }

        [XmlIgnore]
        public bool datasituacaoSpecified
        {
            get
            {
                return this.datasituacaoFieldSpecified;
            }
            set
            {
                this.datasituacaoFieldSpecified = value;
            }
        }

        [XmlAttribute("descricao-situacao")]
        public string descricaosituacao
        {
            get
            {
                return this.descricaosituacaoField;
            }
            set
            {
                this.descricaosituacaoField = value;
            }
        }

        [XmlAttribute]
        public string uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }
}

