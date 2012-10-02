namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Telefone-Vinculado-Consumidor", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(InsumoTelefoneVinculadoAssinanteConsultado)), DesignerCategory("code")]
    public class InsumoTelefoneVinculadoConsumidor
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

