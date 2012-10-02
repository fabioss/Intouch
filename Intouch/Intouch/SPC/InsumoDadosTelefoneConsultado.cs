namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Dados-Telefone-Consultado", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoDadosTelefoneConsultado
    {
        private AssinanteTelefone assinanteField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public AssinanteTelefone assinante
        {
            get
            {
                return this.assinanteField;
            }
            set
            {
                this.assinanteField = value;
            }
        }
    }
}

