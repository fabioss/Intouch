namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), DesignerCategory("code"), XmlType(TypeName="Insumo-Participacao-Empresas", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/")]
    public class InsumoParticipacaoEmpresas : InsumoQuadroSocietario
    {
        private InsumoQuadroSocietario[] participanteField;

        [XmlElement("participante", Form=XmlSchemaForm.Unqualified)]
        public InsumoQuadroSocietario[] participante
        {
            get
            {
                return this.participanteField;
            }
            set
            {
                this.participanteField = value;
            }
        }
    }
}

