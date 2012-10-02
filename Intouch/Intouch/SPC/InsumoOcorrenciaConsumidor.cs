namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Ocorrencia-Consumidor", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class InsumoOcorrenciaConsumidor
    {
        private EnderecoOcorrenciaConsumidor enderecoField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public EnderecoOcorrenciaConsumidor endereco
        {
            get
            {
                return this.enderecoField;
            }
            set
            {
                this.enderecoField = value;
            }
        }
    }
}

