namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Ramo-Atividade", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class RamoAtividade
    {
        private long codigoField;
        private bool codigoFieldSpecified;
        private string descricaoField;

        [XmlAttribute]
        public long codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        [XmlIgnore]
        public bool codigoSpecified
        {
            get
            {
                return this.codigoFieldSpecified;
            }
            set
            {
                this.codigoFieldSpecified = value;
            }
        }

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

