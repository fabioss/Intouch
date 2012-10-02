namespace Intouch.SPC
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "2.0.50727.4927"), XmlInclude(typeof(ResultadoInsumoConsultaRealizada)), XmlInclude(typeof(ResultadoInsumoContumacia)), XmlType(TypeName="Resultado-Insumo", Namespace="http://webservice.consulta.spcjava.spcbrasil.org/"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(ResultadoInsumoContraOrdem))]
    public class ResultadoInsumo
    {
        private object[] itemsField;
        private ResumoInsumo resumoField;

        [XmlElement("detalhe-telefone-consultado", typeof(InsumoDadosTelefoneConsultado), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-restricao-financeira", typeof(InsumoRestricaoFinanceira), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-socio", typeof(InsumoQuadroSocietario), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-relacionamento-mais-antigo-com-fornecedores", typeof(InsumoRelacionamentoMaisAntigoComFornecedores), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-registro-consulta", typeof(InsumoRegistroConsultas), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-telefone-vinculado-assinante-consultado", typeof(InsumoTelefoneVinculadoAssinanteConsultado), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-incorporacao-fusao-cisao", typeof(InsumoIncorporacaoFusaoCisao), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-historico-pagamento", typeof(InsumoHistoricoPagamento), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-historico-conta-corrente", typeof(InsumoHistoricoContaCorrente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-spc-score-3-meses", typeof(InsumoSPCScore3Meses), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-informacao-poder-judiciario", typeof(InsumoInformacaoPoderJudiciario), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-spc-score-12-meses", typeof(InsumoSPCScore12Meses), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-consulta-realizada", typeof(InsumoConsultaRealizada), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-telefone-vinculado-consumidor", typeof(InsumoTelefoneVinculadoConsumidor), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-historico-cheque-documento-diferente", typeof(InsumoHistoricoChequeDocumentoDiferente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-pendencia-financeira", typeof(InsumoPendenciaFinanceira), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-ultimas-consultas", typeof(InsumoUltimasConsultas), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-grafia-pj", typeof(GrafiaPJ), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-filial", typeof(InsumoFilial), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-riskscoring-6-meses", typeof(InsumoRiskscoring6Meses), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-endereco-cep-consultado", typeof(InsumoEnderecoCEPConsultado), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-divida-vencida", typeof(InsumoDividaVencida), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-dados-agencia-bancaria", typeof(DadosAgenciaBancaria), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-credito-concedido", typeof(InsumoCreditoConcedido), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contumacia-srs", typeof(InsumoContumaciaSRS), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-riskscoring-12-meses", typeof(InsumoRiskscoring12Meses), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-referenciais-negocios", typeof(InsumoReferenciaisNegocios), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-protesto", typeof(InsumoProtesto), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-principais-produtos", typeof(InsumoPrincipaisProdutos), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contumacia", typeof(InsumoContumacia), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem-srs", typeof(InsumoContraOrdemSRS), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem-documento-diferente-srs", typeof(InsumoContraOrdemDocumentoDiferenteSRS), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem-documento-diferente", typeof(InsumoContraOrdemDocumentoDiferente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem-agencia-diferente", typeof(InsumoContraOrdemAgenciaDiferente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem-agencia-conta-diferente", typeof(InsumoContraOrdemAgenciaContaDiferente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-contra-ordem", typeof(InsumoContraOrdem), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-consulta-realizada-cheque", typeof(InsumoConsultaRealizadaCheque), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-confirmacao-rg", typeof(InsumoRg), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-historico-cheque", typeof(InsumoHistoricoCheque), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-sem-fundo-varejo", typeof(InsumoChequeSemFundoVarejo), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-sem-fundo-achei-ccf", typeof(InsumoChequeSemFundoAcheiCCF), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-sem-fundo-achei", typeof(InsumoChequeSemFundoAchei), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-outras-ocorrencias-srs", typeof(InsumoChequeOutrasOcorrenciasSRS), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-lojista", typeof(InsumoChequeLojista), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-cheque-consulta-online-srs", typeof(InsumoChequeConsultaOnlineSRS), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-ccf", typeof(InsumoCCF), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-capital-social", typeof(InsumoCapitalSocial), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-banco-agencia-conta-documento-diferente", typeof(AgenciaContaDocumentoDiferente), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-atividade-empresa", typeof(InsumoAtividadeEmpresa), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-antecessora", typeof(InsumoAntecessora), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-alerta-documento", typeof(InsumoAlertaDocumento), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-administrador", typeof(InsumoQuadroAdministrativo), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-acao", typeof(InsumoAcao), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-spc-obito", typeof(InsumoObito), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-spc", typeof(InsumoSPC), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-participacao-falencia", typeof(InsumoParticipacaoFalencia), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-participacao-empresa", typeof(InsumoParticipacaoEmpresas), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-informacoes-adicionais", typeof(InsumoInformacoesAdicionais), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-ultimo-telefone-informado", typeof(InsumoTelefoneConsultado), Form=XmlSchemaForm.Unqualified), XmlElement("detalhe-ultimo-endereco-informado", typeof(InsumoOcorrenciaConsumidor), Form=XmlSchemaForm.Unqualified)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement(Form=XmlSchemaForm.Unqualified)]
        public ResumoInsumo resumo
        {
            get
            {
                return this.resumoField;
            }
            set
            {
                this.resumoField = value;
            }
        }
    }
}

