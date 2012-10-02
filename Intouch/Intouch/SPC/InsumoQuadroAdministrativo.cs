namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Quadro-Administrativo", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough]
    public class InsumoQuadroAdministrativo : InsumoQuadroSocietario
    {
        private string estadocivilField;

        [XmlAttribute("estado-civil")]
        public string estadocivil
        {
            get
            {
                return this.estadocivilField;
            }
            set
            {
                this.estadocivilField = value;
            }
        }
    }
}

