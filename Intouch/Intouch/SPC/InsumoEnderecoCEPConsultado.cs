namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Endereco-CEP-Consultado", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoEnderecoCEPConsultado
    {
        private Endereco enderecoField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Endereco endereco
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

