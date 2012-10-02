namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Contra-Ordem-Documento-Diferente", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(InsumoContraOrdemAgenciaDiferente)), DesignerCategory("code"), XmlInclude(typeof(InsumoContraOrdemAgenciaContaDiferente))]
    public class InsumoContraOrdemDocumentoDiferente : InsumoContraOrdem
    {
        private string documentoField;

        [XmlAttribute]
        public string documento
        {
            get
            {
                return this.documentoField;
            }
            set
            {
                this.documentoField = value;
            }
        }
    }
}

