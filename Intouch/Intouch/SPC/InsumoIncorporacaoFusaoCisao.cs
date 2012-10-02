namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(TypeName="Insumo-Incorporacao-Fusao-Cisao", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), GeneratedCode("System.Xml", "2.0.50727.4927"), DebuggerStepThrough, DesignerCategory("code")]
    public class InsumoIncorporacaoFusaoCisao
    {
        private DateTime dataatualizacaoField;
        private bool dataatualizacaoFieldSpecified;
        private string mensagemobservacoesField;

        [XmlAttribute("data-atualizacao")]
        public DateTime dataatualizacao
        {
            get
            {
                return this.dataatualizacaoField;
            }
            set
            {
                this.dataatualizacaoField = value;
            }
        }

        [XmlIgnore]
        public bool dataatualizacaoSpecified
        {
            get
            {
                return this.dataatualizacaoFieldSpecified;
            }
            set
            {
                this.dataatualizacaoFieldSpecified = value;
            }
        }

        [XmlAttribute("mensagem-observacoes")]
        public string mensagemobservacoes
        {
            get
            {
                return this.mensagemobservacoesField;
            }
            set
            {
                this.mensagemobservacoesField = value;
            }
        }
    }
}

