namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Informacoes-Adicionais", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class InsumoInformacoesAdicionais
    {
        private string frasestatusempresaField;

        [XmlAttribute("frase-status-empresa")]
        public string frasestatusempresa
        {
            get
            {
                return this.frasestatusempresaField;
            }
            set
            {
                this.frasestatusempresaField = value;
            }
        }
    }
}

