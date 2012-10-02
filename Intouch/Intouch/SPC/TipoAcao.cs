namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Tipo-Acao", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, DesignerCategory("code")]
    public class TipoAcao
    {
        private string descricaoField;

        [XmlAttribute]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }
}

