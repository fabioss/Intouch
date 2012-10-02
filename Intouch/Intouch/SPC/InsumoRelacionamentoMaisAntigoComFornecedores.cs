namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Insumo-Relacionamento-Mais-Antigo-Com-Fornecedores", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DebuggerStepThrough, DesignerCategory("code")]
    public class InsumoRelacionamentoMaisAntigoComFornecedores
    {
        private DateTime datarelacionamentomaisantigoField;
        private bool datarelacionamentomaisantigoFieldSpecified;

        [XmlAttribute("data-relacionamento-mais-antigo")]
        public DateTime datarelacionamentomaisantigo
        {
            get
            {
                return this.datarelacionamentomaisantigoField;
            }
            set
            {
                this.datarelacionamentomaisantigoField = value;
            }
        }

        [XmlIgnore]
        public bool datarelacionamentomaisantigoSpecified
        {
            get
            {
                return this.datarelacionamentomaisantigoFieldSpecified;
            }
            set
            {
                this.datarelacionamentomaisantigoFieldSpecified = value;
            }
        }
    }
}

