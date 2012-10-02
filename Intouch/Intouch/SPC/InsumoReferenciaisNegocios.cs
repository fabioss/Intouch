namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Referenciais-Negocios", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough]
    public class InsumoReferenciaisNegocios
    {
        private DateTime datapotencialField;
        private bool datapotencialFieldSpecified;
        private string descricaonegocioField;
        private decimal mediapotencialField;
        private bool mediapotencialFieldSpecified;
        private decimal valorpotencialField;
        private bool valorpotencialFieldSpecified;

        [XmlAttribute("data-potencial")]
        public DateTime datapotencial
        {
            get
            {
                return this.datapotencialField;
            }
            set
            {
                this.datapotencialField = value;
            }
        }

        [XmlIgnore]
        public bool datapotencialSpecified
        {
            get
            {
                return this.datapotencialFieldSpecified;
            }
            set
            {
                this.datapotencialFieldSpecified = value;
            }
        }

        [XmlAttribute("descricao-negocio")]
        public string descricaonegocio
        {
            get
            {
                return this.descricaonegocioField;
            }
            set
            {
                this.descricaonegocioField = value;
            }
        }

        [XmlAttribute("media-potencial")]
        public decimal mediapotencial
        {
            get
            {
                return this.mediapotencialField;
            }
            set
            {
                this.mediapotencialField = value;
            }
        }

        [XmlIgnore]
        public bool mediapotencialSpecified
        {
            get
            {
                return this.mediapotencialFieldSpecified;
            }
            set
            {
                this.mediapotencialFieldSpecified = value;
            }
        }

        [XmlAttribute("valor-potencial")]
        public decimal valorpotencial
        {
            get
            {
                return this.valorpotencialField;
            }
            set
            {
                this.valorpotencialField = value;
            }
        }

        [XmlIgnore]
        public bool valorpotencialSpecified
        {
            get
            {
                return this.valorpotencialFieldSpecified;
            }
            set
            {
                this.valorpotencialFieldSpecified = value;
            }
        }
    }
}

