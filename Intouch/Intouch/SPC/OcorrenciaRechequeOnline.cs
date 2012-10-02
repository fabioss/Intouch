namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Ocorrencia-Recheque-Online", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code")]
    public class OcorrenciaRechequeOnline
    {
        private string bancoparticipacaorechequeonlineField;
        private string mensagemindisponibilidadeField;

        [XmlAttribute("banco-participacao-recheque-online")]
        public string bancoparticipacaorechequeonline
        {
            get
            {
                return this.bancoparticipacaorechequeonlineField;
            }
            set
            {
                this.bancoparticipacaorechequeonlineField = value;
            }
        }

        [XmlAttribute("mensagem-indisponibilidade")]
        public string mensagemindisponibilidade
        {
            get
            {
                return this.mensagemindisponibilidadeField;
            }
            set
            {
                this.mensagemindisponibilidadeField = value;
            }
        }
    }
}

