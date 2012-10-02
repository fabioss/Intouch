namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Dados-Agencia-Bancaria", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough, DesignerCategory("code")]
    public class DadosAgenciaBancaria
    {
        private DadosBancarios dadosbancariosField;

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
    }
}

