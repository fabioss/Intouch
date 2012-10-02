namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(TypeName="Insumo-Participacao-Falencia", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), GeneratedCode("System.Xml", "2.0.50727.4927")]
    public class InsumoParticipacaoFalencia
    {
        private DateTime dataacaoField;
        private bool dataacaoFieldSpecified;
        private string descricaotipoparticipacaoField;
        private string empresaparticipacaoField;
        private NaturezaAnotacao naturezaanotacaoField;
        private string qualificacaoparticipanteempresafalidaField;
        private TipoAcao tipoacaoField;
        private Vara varacivelField;

        [XmlAttribute("data-acao")]
        public DateTime dataacao
        {
            get
            {
                return this.dataacaoField;
            }
            set
            {
                this.dataacaoField = value;
            }
        }

        [XmlIgnore]
        public bool dataacaoSpecified
        {
            get
            {
                return this.dataacaoFieldSpecified;
            }
            set
            {
                this.dataacaoFieldSpecified = value;
            }
        }

        [XmlAttribute("descricao-tipo-participacao")]
        public string descricaotipoparticipacao
        {
            get
            {
                return this.descricaotipoparticipacaoField;
            }
            set
            {
                this.descricaotipoparticipacaoField = value;
            }
        }

        [XmlAttribute("empresa-participacao")]
        public string empresaparticipacao
        {
            get
            {
                return this.empresaparticipacaoField;
            }
            set
            {
                this.empresaparticipacaoField = value;
            }
        }

        [XmlElement("natureza-anotacao", Form=XmlSchemaForm.Unqualified)]
        public NaturezaAnotacao naturezaanotacao
        {
            get
            {
                return this.naturezaanotacaoField;
            }
            set
            {
                this.naturezaanotacaoField = value;
            }
        }

        [XmlAttribute("qualificacao-participante-empresa-falida")]
        public string qualificacaoparticipanteempresafalida
        {
            get
            {
                return this.qualificacaoparticipanteempresafalidaField;
            }
            set
            {
                this.qualificacaoparticipanteempresafalidaField = value;
            }
        }

        [XmlElement("tipo-acao", Form=XmlSchemaForm.Unqualified)]
        public TipoAcao tipoacao
        {
            get
            {
                return this.tipoacaoField;
            }
            set
            {
                this.tipoacaoField = value;
            }
        }

        [XmlElement("vara-civel", Form=XmlSchemaForm.Unqualified)]
        public Vara varacivel
        {
            get
            {
                return this.varacivelField;
            }
            set
            {
                this.varacivelField = value;
            }
        }
    }
}

