namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Telefone-Filtro", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough, DesignerCategory("code")]
    public class TelefoneFiltro
    {
        private int dddField;
        private int numeroField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int ddd
        {
            get
            {
                return this.dddField;
            }
            set
            {
                this.dddField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public int numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
    }
}

