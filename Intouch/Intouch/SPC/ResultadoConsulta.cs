namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlType(TypeName="Resultado-Consulta", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough]
    public class ResultadoConsulta
    {
        private ResultadoInsumo acaoField;
        private ResultadoInsumo administradorField;
        private ResultadoInsumo alertadocumentoField;
        private ResultadoInsumo antecessoraField;
        private ResultadoInsumo atividadeempresaField;
        private ResultadoInsumo bancoagenciacontadocumentodiferenteField;
        private string[] baseinoperanteField;
        private ResultadoInsumo capitalsocialField;
        private ResultadoInsumo ccfField;
        private ResultadoInsumo chequeconsultaonlinesrsField;
        private ResultadoInsumo chequelojistaField;
        private ResultadoInsumo chequeoutrasocorrenciassrsField;
        private ResultadoInsumo chequesemfundoacheiccfField;
        private ResultadoInsumo chequesemfundoacheiField;
        private ResultadoInsumo chequesemfundovarejoField;
        private ResultadoInsumo confirmacaorgField;
        private ResultadoInsumo consultarealizadachequeField;
        private ResultadoInsumoConsultaRealizada consultarealizadaField;
        private ResultadoConsumidor consumidorField;
        private ResultadoInsumoContraOrdem contraordemagenciacontadiferenteField;
        private ResultadoInsumoContraOrdem contraordemagenciadiferenteField;
        private ResultadoInsumoContraOrdem contraordemdocumentodiferenteField;
        private ResultadoInsumo contraordemdocumentodiferentesrsField;
        private ResultadoInsumoContraOrdem contraordemField;
        private ResultadoInsumo contraordemsrsField;
        private ResultadoInsumoContumacia contumaciaField;
        private ResultadoInsumo contumaciasrsField;
        private ResultadoInsumo creditoconcedidoField;
        private ResultadoInsumo dadosagenciabancariaField;
        private DateTime dataField;
        private bool dataFieldSpecified;
        private ResultadoInsumo enderecocepconsultadoField;
        private ResultadoInsumo filialField;
        private ResultadoInsumo grafiapjField;
        private ResultadoInsumo historicopagamentoField;
        private ResultadoInsumo incorporacaofusaocisaoField;
        private ResultadoInsumo informacaopoderjudiciarioField;
        private ResultadoInsumo informacoesadicionaisField;
        private MensagemComplementar[] mensagemcomplementarField;
        private Operador operadorField;
        private ResultadoInsumo participacaoempresaField;
        private ResultadoInsumo participacaofalenciaField;
        private ResultadoInsumo pendenciafinanceiraField;
        private ResultadoInsumo principaisprodutosField;
        private ResultadoInsumo protestoField;
        private ProtocoloConsulta protocoloField;
        private ResultadoInsumo referenciaisnegociosField;
        private ResultadoInsumo registroconsultaField;
        private ResultadoInsumo relacionamentomaisantigocomfornecedoresField;
        private bool restricaoField;
        private bool restricaoFieldSpecified;
        private ResultadoInsumo restricaofinanceiraField;
        private ResultadoInsumo riskscoring12mesesField;
        private ResultadoInsumo riskscoring6mesesField;
        private ResultadoInsumo socioField;
        private ResultadoInsumo spcField;
        private ResultadoInsumo spcobitoField;
        private ResultadoInsumo spcscore12mesesField;
        private ResultadoInsumo spcscore3mesesField;
        private ResultadoInsumo telefoneconsultadoField;
        private ResultadoInsumo telefonevinculadoassinanteconsultadoField;
        private ResultadoInsumo telefonevinculadoconsumidorField;
        private ResultadoInsumo ultimasconsultasField;
        private ResultadoInsumo ultimoenderecoinformadoField;
        private ResultadoInsumo ultimotelefoneinformadoField;

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo acao
        {
            get
            {
                return this.acaoField;
            }
            set
            {
                this.acaoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo administrador
        {
            get
            {
                return this.administradorField;
            }
            set
            {
                this.administradorField = value;
            }
        }

        [XmlElement("alerta-documento", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo alertadocumento
        {
            get
            {
                return this.alertadocumentoField;
            }
            set
            {
                this.alertadocumentoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo antecessora
        {
            get
            {
                return this.antecessoraField;
            }
            set
            {
                this.antecessoraField = value;
            }
        }

        [XmlElement("atividade-empresa", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo atividadeempresa
        {
            get
            {
                return this.atividadeempresaField;
            }
            set
            {
                this.atividadeempresaField = value;
            }
        }

        [XmlElement("banco-agencia-conta-documento-diferente", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo bancoagenciacontadocumentodiferente
        {
            get
            {
                return this.bancoagenciacontadocumentodiferenteField;
            }
            set
            {
                this.bancoagenciacontadocumentodiferenteField = value;
            }
        }

        [XmlElement("base-inoperante", Form=XmlSchemaForm.Unqualified)]
        public string[] baseinoperante
        {
            get
            {
                return this.baseinoperanteField;
            }
            set
            {
                this.baseinoperanteField = value;
            }
        }

        [XmlElement("capital-social", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo capitalsocial
        {
            get
            {
                return this.capitalsocialField;
            }
            set
            {
                this.capitalsocialField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo ccf
        {
            get
            {
                return this.ccfField;
            }
            set
            {
                this.ccfField = value;
            }
        }

        [XmlElement("cheque-consulta-online-srs", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequeconsultaonlinesrs
        {
            get
            {
                return this.chequeconsultaonlinesrsField;
            }
            set
            {
                this.chequeconsultaonlinesrsField = value;
            }
        }

        [XmlElement("cheque-lojista", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequelojista
        {
            get
            {
                return this.chequelojistaField;
            }
            set
            {
                this.chequelojistaField = value;
            }
        }

        [XmlElement("cheque-outras-ocorrencias-srs", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequeoutrasocorrenciassrs
        {
            get
            {
                return this.chequeoutrasocorrenciassrsField;
            }
            set
            {
                this.chequeoutrasocorrenciassrsField = value;
            }
        }

        [XmlElement("cheque-sem-fundo-achei", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequesemfundoachei
        {
            get
            {
                return this.chequesemfundoacheiField;
            }
            set
            {
                this.chequesemfundoacheiField = value;
            }
        }

        [XmlElement("cheque-sem-fundo-achei-ccf", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequesemfundoacheiccf
        {
            get
            {
                return this.chequesemfundoacheiccfField;
            }
            set
            {
                this.chequesemfundoacheiccfField = value;
            }
        }

        [XmlElement("cheque-sem-fundo-varejo", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo chequesemfundovarejo
        {
            get
            {
                return this.chequesemfundovarejoField;
            }
            set
            {
                this.chequesemfundovarejoField = value;
            }
        }

        [XmlElement("confirmacao-rg", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo confirmacaorg
        {
            get
            {
                return this.confirmacaorgField;
            }
            set
            {
                this.confirmacaorgField = value;
            }
        }

        [XmlElement("consulta-realizada", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoConsultaRealizada consultarealizada
        {
            get
            {
                return this.consultarealizadaField;
            }
            set
            {
                this.consultarealizadaField = value;
            }
        }

        [XmlElement("consulta-realizada-cheque", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo consultarealizadacheque
        {
            get
            {
                return this.consultarealizadachequeField;
            }
            set
            {
                this.consultarealizadachequeField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoConsumidor consumidor
        {
            get
            {
                return this.consumidorField;
            }
            set
            {
                this.consumidorField = value;
            }
        }

        [XmlElement("contra-ordem", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoContraOrdem contraordem
        {
            get
            {
                return this.contraordemField;
            }
            set
            {
                this.contraordemField = value;
            }
        }

        [XmlElement("contra-ordem-agencia-conta-diferente", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoContraOrdem contraordemagenciacontadiferente
        {
            get
            {
                return this.contraordemagenciacontadiferenteField;
            }
            set
            {
                this.contraordemagenciacontadiferenteField = value;
            }
        }

        [XmlElement("contra-ordem-agencia-diferente", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoContraOrdem contraordemagenciadiferente
        {
            get
            {
                return this.contraordemagenciadiferenteField;
            }
            set
            {
                this.contraordemagenciadiferenteField = value;
            }
        }

        [XmlElement("contra-ordem-documento-diferente", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoContraOrdem contraordemdocumentodiferente
        {
            get
            {
                return this.contraordemdocumentodiferenteField;
            }
            set
            {
                this.contraordemdocumentodiferenteField = value;
            }
        }

        [XmlElement("contra-ordem-documento-diferente-srs", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo contraordemdocumentodiferentesrs
        {
            get
            {
                return this.contraordemdocumentodiferentesrsField;
            }
            set
            {
                this.contraordemdocumentodiferentesrsField = value;
            }
        }

        [XmlElement("contra-ordem-srs", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo contraordemsrs
        {
            get
            {
                return this.contraordemsrsField;
            }
            set
            {
                this.contraordemsrsField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumoContumacia contumacia
        {
            get
            {
                return this.contumaciaField;
            }
            set
            {
                this.contumaciaField = value;
            }
        }

        [XmlElement("contumacia-srs", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo contumaciasrs
        {
            get
            {
                return this.contumaciasrsField;
            }
            set
            {
                this.contumaciasrsField = value;
            }
        }

        [XmlElement("credito-concedido", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo creditoconcedido
        {
            get
            {
                return this.creditoconcedidoField;
            }
            set
            {
                this.creditoconcedidoField = value;
            }
        }

        [XmlElement("dados-agencia-bancaria", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo dadosagenciabancaria
        {
            get
            {
                return this.dadosagenciabancariaField;
            }
            set
            {
                this.dadosagenciabancariaField = value;
            }
        }

        [XmlAttribute]
        public DateTime data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        [XmlIgnore]
        public bool dataSpecified
        {
            get
            {
                return this.dataFieldSpecified;
            }
            set
            {
                this.dataFieldSpecified = value;
            }
        }

        [XmlElement("endereco-cep-consultado", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo enderecocepconsultado
        {
            get
            {
                return this.enderecocepconsultadoField;
            }
            set
            {
                this.enderecocepconsultadoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo filial
        {
            get
            {
                return this.filialField;
            }
            set
            {
                this.filialField = value;
            }
        }

        [XmlElement("grafia-pj", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo grafiapj
        {
            get
            {
                return this.grafiapjField;
            }
            set
            {
                this.grafiapjField = value;
            }
        }

        [XmlElement("historico-pagamento", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo historicopagamento
        {
            get
            {
                return this.historicopagamentoField;
            }
            set
            {
                this.historicopagamentoField = value;
            }
        }

        [XmlElement("incorporacao-fusao-cisao", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo incorporacaofusaocisao
        {
            get
            {
                return this.incorporacaofusaocisaoField;
            }
            set
            {
                this.incorporacaofusaocisaoField = value;
            }
        }

        [XmlElement("informacao-poder-judiciario", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo informacaopoderjudiciario
        {
            get
            {
                return this.informacaopoderjudiciarioField;
            }
            set
            {
                this.informacaopoderjudiciarioField = value;
            }
        }

        [XmlElement("informacoes-adicionais", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo informacoesadicionais
        {
            get
            {
                return this.informacoesadicionaisField;
            }
            set
            {
                this.informacoesadicionaisField = value;
            }
        }

        [XmlElement("mensagem-complementar", Form=XmlSchemaForm.Unqualified)]
        public MensagemComplementar[] mensagemcomplementar
        {
            get
            {
                return this.mensagemcomplementarField;
            }
            set
            {
                this.mensagemcomplementarField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public Operador operador
        {
            get
            {
                return this.operadorField;
            }
            set
            {
                this.operadorField = value;
            }
        }

        [XmlElement("participacao-empresa", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo participacaoempresa
        {
            get
            {
                return this.participacaoempresaField;
            }
            set
            {
                this.participacaoempresaField = value;
            }
        }

        [XmlElement("participacao-falencia", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo participacaofalencia
        {
            get
            {
                return this.participacaofalenciaField;
            }
            set
            {
                this.participacaofalenciaField = value;
            }
        }

        [XmlElement("pendencia-financeira", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo pendenciafinanceira
        {
            get
            {
                return this.pendenciafinanceiraField;
            }
            set
            {
                this.pendenciafinanceiraField = value;
            }
        }

        [XmlElement("principais-produtos", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo principaisprodutos
        {
            get
            {
                return this.principaisprodutosField;
            }
            set
            {
                this.principaisprodutosField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo protesto
        {
            get
            {
                return this.protestoField;
            }
            set
            {
                this.protestoField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ProtocoloConsulta protocolo
        {
            get
            {
                return this.protocoloField;
            }
            set
            {
                this.protocoloField = value;
            }
        }

        [XmlElement("referenciais-negocios", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo referenciaisnegocios
        {
            get
            {
                return this.referenciaisnegociosField;
            }
            set
            {
                this.referenciaisnegociosField = value;
            }
        }

        [XmlElement("registro-consulta", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo registroconsulta
        {
            get
            {
                return this.registroconsultaField;
            }
            set
            {
                this.registroconsultaField = value;
            }
        }

        [XmlElement("relacionamento-mais-antigo-com-fornecedores", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo relacionamentomaisantigocomfornecedores
        {
            get
            {
                return this.relacionamentomaisantigocomfornecedoresField;
            }
            set
            {
                this.relacionamentomaisantigocomfornecedoresField = value;
            }
        }

        [XmlAttribute]
        public bool restricao
        {
            get
            {
                return this.restricaoField;
            }
            set
            {
                this.restricaoField = value;
            }
        }

        [XmlElement("restricao-financeira", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo restricaofinanceira
        {
            get
            {
                return this.restricaofinanceiraField;
            }
            set
            {
                this.restricaofinanceiraField = value;
            }
        }

        [XmlIgnore]
        public bool restricaoSpecified
        {
            get
            {
                return this.restricaoFieldSpecified;
            }
            set
            {
                this.restricaoFieldSpecified = value;
            }
        }

        [XmlElement("riskscoring-12-meses", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo riskscoring12meses
        {
            get
            {
                return this.riskscoring12mesesField;
            }
            set
            {
                this.riskscoring12mesesField = value;
            }
        }

        [XmlElement("riskscoring-6-meses", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo riskscoring6meses
        {
            get
            {
                return this.riskscoring6mesesField;
            }
            set
            {
                this.riskscoring6mesesField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo socio
        {
            get
            {
                return this.socioField;
            }
            set
            {
                this.socioField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo spc
        {
            get
            {
                return this.spcField;
            }
            set
            {
                this.spcField = value;
            }
        }

        [XmlElement("spc-obito", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo spcobito
        {
            get
            {
                return this.spcobitoField;
            }
            set
            {
                this.spcobitoField = value;
            }
        }

        [XmlElement("spc-score-12-meses", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo spcscore12meses
        {
            get
            {
                return this.spcscore12mesesField;
            }
            set
            {
                this.spcscore12mesesField = value;
            }
        }

        [XmlElement("spc-score-3-meses", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo spcscore3meses
        {
            get
            {
                return this.spcscore3mesesField;
            }
            set
            {
                this.spcscore3mesesField = value;
            }
        }

        [XmlElement("telefone-consultado", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo telefoneconsultado
        {
            get
            {
                return this.telefoneconsultadoField;
            }
            set
            {
                this.telefoneconsultadoField = value;
            }
        }

        [XmlElement("telefone-vinculado-assinante-consultado", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo telefonevinculadoassinanteconsultado
        {
            get
            {
                return this.telefonevinculadoassinanteconsultadoField;
            }
            set
            {
                this.telefonevinculadoassinanteconsultadoField = value;
            }
        }

        [XmlElement("telefone-vinculado-consumidor", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo telefonevinculadoconsumidor
        {
            get
            {
                return this.telefonevinculadoconsumidorField;
            }
            set
            {
                this.telefonevinculadoconsumidorField = value;
            }
        }

        [XmlElement("ultimas-consultas", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo ultimasconsultas
        {
            get
            {
                return this.ultimasconsultasField;
            }
            set
            {
                this.ultimasconsultasField = value;
            }
        }

        [XmlElement("ultimo-endereco-informado", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo ultimoenderecoinformado
        {
            get
            {
                return this.ultimoenderecoinformadoField;
            }
            set
            {
                this.ultimoenderecoinformadoField = value;
            }
        }

        [XmlElement("ultimo-telefone-informado", Form=XmlSchemaForm.Unqualified)]
        public ResultadoInsumo ultimotelefoneinformado
        {
            get
            {
                return this.ultimotelefoneinformadoField;
            }
            set
            {
                this.ultimotelefoneinformadoField = value;
            }
        }
    }
}

