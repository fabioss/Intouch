namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Agencia-Conta-Documento-Diferente", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class AgenciaContaDocumentoDiferente
    {
        private DadosBancarios dadosbancariosField;
        private string documentoField;
        private string origemField;

        [XmlElement("dados-bancarios", Form=XmlSchemaForm.Unqualified)]
        public DadosBancarios dadosbancarios
        {
            get
            {
                return this.dadosbancariosField;
            }
            set
            {
                this.dadosbancariosField = value;
            }
        }

        [XmlAttribute]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
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

