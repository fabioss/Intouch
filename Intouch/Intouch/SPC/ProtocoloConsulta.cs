namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Protocolo-Consulta", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code")]
    public class ProtocoloConsulta
    {
        private int digitoField;
        private bool digitoFieldSpecified;
        private long numeroField;
        private bool numeroFieldSpecified;

        [XmlAttribute]
        public int digito
        {
            get
            {
                return this.digitoField;
            }
            set
            {
                this.digitoField = value;
            }
        }

        [XmlIgnore]
        public bool digitoSpecified
        {
            get
            {
                return this.digitoFieldSpecified;
            }
            set
            {
                this.digitoFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public long numero
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

        [XmlIgnore]
        public bool numeroSpecified
        {
            get
            {
                return this.numeroFieldSpecified;
            }
            set
            {
                this.numeroFieldSpecified = value;
            }
        }
    }
}

