namespace Intouch
{
    using AjaxControlToolkit;
    using BIUnit4;
    using DllPainelDeControle;
    using DLLUnitShop;
    using Intouch.SPC;
    using Intouch.wsConsignado;
    using Microsoft.ApplicationBlocks.Data;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class Home : GlobalPage
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("AccordionOpcoesAvancadas")]
        private Accordion _AccordionOpcoesAvancadas;
        [AccessedThroughProperty("AccordionPaneOpcoesAvancadas")]
        private AccordionPane _AccordionPaneOpcoesAvancadas;
        [AccessedThroughProperty("AutoCompleteExtender1")]
        private AutoCompleteExtender _AutoCompleteExtender1;
        [AccessedThroughProperty("btnAguardeConsultaINSS")]
        private Button _btnAguardeConsultaINSS;
        [AccessedThroughProperty("btnAtualizarStatusParticipacaoEmpresarialSocios")]
        private Button _btnAtualizarStatusParticipacaoEmpresarialSocios;
        [AccessedThroughProperty("btnAtualizaStatusTel")]
        private Button _btnAtualizaStatusTel;
        [AccessedThroughProperty("btndataprev")]
        private Button _btndataprev;
        [AccessedThroughProperty("btnMpeAguarde")]
        private Button _btnMpeAguarde;
        [AccessedThroughProperty("btnNovaConsulta")]
        private Button _btnNovaConsulta;
        [AccessedThroughProperty("btnSPC")]
        private HiddenField _btnSPC;
        [AccessedThroughProperty("btnTrat")]
        private Button _btnTrat;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("calendarDataFinalApresentacao")]
        private CalendarExtender _calendarDataFinalApresentacao;
        [AccessedThroughProperty("calendarDataInicialApresentacao")]
        private CalendarExtender _calendarDataInicialApresentacao;
        [AccessedThroughProperty("CalendarExtender1")]
        private CalendarExtender _CalendarExtender1;
        [AccessedThroughProperty("CalendarExtender2")]
        private CalendarExtender _CalendarExtender2;
        [AccessedThroughProperty("CalendarExtender3")]
        private CalendarExtender _CalendarExtender3;
        [AccessedThroughProperty("dataBairroSPCCNPJ")]
        private TextBox _dataBairroSPCCNPJ;
        [AccessedThroughProperty("dataCEPCNPJ")]
        private TextBox _dataCEPCNPJ;
        [AccessedThroughProperty("dataCitySPC")]
        private TextBox _dataCitySPC;
        [AccessedThroughProperty("dataCnpjSPC")]
        private TextBox _dataCnpjSPC;
        [AccessedThroughProperty("dataComplSPCCNPJ")]
        private TextBox _dataComplSPCCNPJ;
        [AccessedThroughProperty("dataCPFSPC")]
        private TextBox _dataCPFSPC;
        [AccessedThroughProperty("dataDDDFaxSPCCNPJ")]
        private TextBox _dataDDDFaxSPCCNPJ;
        [AccessedThroughProperty("dataDDDSPCCNPJ")]
        private TextBox _dataDDDSPCCNPJ;
        [AccessedThroughProperty("dataDscNarJurSPCCNPJ")]
        private TextBox _dataDscNarJurSPCCNPJ;
        [AccessedThroughProperty("dataDscSituacaoSPC")]
        private TextBox _dataDscSituacaoSPC;
        [AccessedThroughProperty("dataEndSPCCNPJ")]
        private TextBox _dataEndSPCCNPJ;
        [AccessedThroughProperty("dataFaxSPCCNPJ")]
        private TextBox _dataFaxSPCCNPJ;
        [AccessedThroughProperty("dataFoneSPCCNPJ")]
        private TextBox _dataFoneSPCCNPJ;
        [AccessedThroughProperty("dataInscrEstadualSPC")]
        private TextBox _dataInscrEstadualSPC;
        [AccessedThroughProperty("dataNarJurSPCCNPJ")]
        private TextBox _dataNarJurSPCCNPJ;
        [AccessedThroughProperty("dataNmComercial")]
        private TextBox _dataNmComercial;
        [AccessedThroughProperty("dataNomeSPC")]
        private TextBox _dataNomeSPC;
        [AccessedThroughProperty("dataNumSPCCNPJ")]
        private TextBox _dataNumSPCCNPJ;
        [AccessedThroughProperty("dataRazaoAntSpc")]
        private TextBox _dataRazaoAntSpc;
        [AccessedThroughProperty("dataRazaoSpc")]
        private TextBox _dataRazaoSpc;
        [AccessedThroughProperty("dataSituacaoSPCCNPJ")]
        private TextBox _dataSituacaoSPCCNPJ;
        [AccessedThroughProperty("dataUfSPCCNPJ")]
        private TextBox _dataUfSPCCNPJ;
        [AccessedThroughProperty("dataVlCapitalSPCCNPJ")]
        private TextBox _dataVlCapitalSPCCNPJ;
        [AccessedThroughProperty("dgAlertaDocumentos")]
        private DataGrid _dgAlertaDocumentos;
        [AccessedThroughProperty("dgCadastroEmitentesChequeSemFundo")]
        private DataGrid _dgCadastroEmitentesChequeSemFundo;
        [AccessedThroughProperty("dgClienteAcessoRegistro")]
        private DataGrid _dgClienteAcessoRegistro;
        [AccessedThroughProperty("dgCnaeSPCCNPJ")]
        private DataGrid _dgCnaeSPCCNPJ;
        [AccessedThroughProperty("dgCnpjCheque")]
        private DataGrid _dgCnpjCheque;
        [AccessedThroughProperty("dgConsulta")]
        private DataGrid _dgConsulta;
        [AccessedThroughProperty("dgConsultaCNPJ")]
        private DataGrid _dgConsultaCNPJ;
        [AccessedThroughProperty("dgConsultasRealizadas")]
        private DataGrid _dgConsultasRealizadas;
        [AccessedThroughProperty("dgDadosComerciais")]
        private DataGrid _dgDadosComerciais;
        [AccessedThroughProperty("dgDadosDireto")]
        private DataGrid _dgDadosDireto;
        [AccessedThroughProperty("dgDadosExtra")]
        private DataGrid _dgDadosExtra;
        [AccessedThroughProperty("dgDataPrevGuia1")]
        private DataGrid _dgDataPrevGuia1;
        [AccessedThroughProperty("dgDataPrevGuia1Resumo")]
        private DataGrid _dgDataPrevGuia1Resumo;
        [AccessedThroughProperty("dgDataPrevGuia2Credito")]
        private DataGrid _dgDataPrevGuia2Credito;
        [AccessedThroughProperty("dgDataPrevGuia2Debito")]
        private DataGrid _dgDataPrevGuia2Debito;
        [AccessedThroughProperty("dgEmail")]
        private DataGrid _dgEmail;
        [AccessedThroughProperty("dgEndereco")]
        private DataGrid _dgEndereco;
        [AccessedThroughProperty("dgIpsLoginDia")]
        private DataGrid _dgIpsLoginDia;
        [AccessedThroughProperty("dgParticipacaoEmpresarial")]
        private DataGrid _dgParticipacaoEmpresarial;
        [AccessedThroughProperty("dgPesquisasRecentes")]
        private DataGrid _dgPesquisasRecentes;
        [AccessedThroughProperty("dgServicoInadimplenciaChequeLogista")]
        private DataGrid _dgServicoInadimplenciaChequeLogista;
        [AccessedThroughProperty("dgServicoInadimplenciaSPC")]
        private DataGrid _dgServicoInadimplenciaSPC;
        [AccessedThroughProperty("dgTelefone")]
        private DataGrid _dgTelefone;
        [AccessedThroughProperty("dgVizinhos")]
        private DataGrid _dgVizinhos;
        [AccessedThroughProperty("div2")]
        private HtmlGenericControl _div2;
        [AccessedThroughProperty("divBannerCampanha")]
        private HtmlGenericControl _divBannerCampanha;
        [AccessedThroughProperty("divBannersHome")]
        private HtmlGenericControl _divBannersHome;
        [AccessedThroughProperty("divBoxAtualize")]
        private HtmlGenericControl _divBoxAtualize;
        [AccessedThroughProperty("divConsulta")]
        private HtmlGenericControl _divConsulta;
        [AccessedThroughProperty("divEditarPopup")]
        private HtmlGenericControl _divEditarPopup;
        [AccessedThroughProperty("divLateralPerfil")]
        private HtmlGenericControl _divLateralPerfil;
        [AccessedThroughProperty("divOpcional")]
        private HtmlGenericControl _divOpcional;
        [AccessedThroughProperty("FilteredTxtDddApresentacao")]
        private FilteredTextBoxExtender _FilteredTxtDddApresentacao;
        [AccessedThroughProperty("FilteredTxtDDDNovo")]
        private FilteredTextBoxExtender _FilteredTxtDDDNovo;
        [AccessedThroughProperty("filteredTxtPesqDdd")]
        private FilteredTextBoxExtender _filteredTxtPesqDdd;
        [AccessedThroughProperty("FilteredTxtPesqTelefone")]
        private FilteredTextBoxExtender _FilteredTxtPesqTelefone;
        [AccessedThroughProperty("FilteredTxtTelApresentacao")]
        private FilteredTextBoxExtender _FilteredTxtTelApresentacao;
        [AccessedThroughProperty("FilteredTxtTelNovo")]
        private FilteredTextBoxExtender _FilteredTxtTelNovo;
        [AccessedThroughProperty("hdnFieldPesquisa")]
        private HiddenField _hdnFieldPesquisa;
        [AccessedThroughProperty("hdnFieldTipoPessoa")]
        private HiddenField _hdnFieldTipoPessoa;
        [AccessedThroughProperty("hdnFldOpcoesAvancadas")]
        private HiddenField _hdnFldOpcoesAvancadas;
        [AccessedThroughProperty("HyperLink1")]
        private HyperLink _HyperLink1;
        [AccessedThroughProperty("HyperLink2")]
        private HyperLink _HyperLink2;
        [AccessedThroughProperty("ImageButton1")]
        private ImageButton _ImageButton1;
        [AccessedThroughProperty("ImageButton2")]
        private ImageButton _ImageButton2;
        [AccessedThroughProperty("ImageButton3")]
        private ImageButton _ImageButton3;
        [AccessedThroughProperty("imgBannerHomeCampanha")]
        private HtmlImage _imgBannerHomeCampanha;
        [AccessedThroughProperty("imgBtnAtualizaEndereco")]
        private Button _imgBtnAtualizaEndereco;
        [AccessedThroughProperty("imgBtnAtualizarEmail")]
        private Button _imgBtnAtualizarEmail;
        [AccessedThroughProperty("imgBtnAtualizarPopup")]
        private ImageButton _imgBtnAtualizarPopup;
        [AccessedThroughProperty("imgBtnCancelar")]
        private ImageButton _imgBtnCancelar;
        [AccessedThroughProperty("imgBtnCancelarPopup")]
        private ImageButton _imgBtnCancelarPopup;
        [AccessedThroughProperty("imgBtnCarregaDadosMae")]
        private ImageButton _imgBtnCarregaDadosMae;
        [AccessedThroughProperty("imgBtnEditar")]
        private ImageButton _imgBtnEditar;
        [AccessedThroughProperty("imgBtnEditarPopup")]
        private ImageButton _imgBtnEditarPopup;
        [AccessedThroughProperty("imgBtnLimpar")]
        private ImageButton _imgBtnLimpar;
        [AccessedThroughProperty("imgBtnPrintTab1")]
        private ImageButton _imgBtnPrintTab1;
        [AccessedThroughProperty("imgBtnPrintTab2")]
        private ImageButton _imgBtnPrintTab2;
        [AccessedThroughProperty("imgBtnPrintTab3")]
        private ImageButton _imgBtnPrintTab3;
        [AccessedThroughProperty("imgBtnPrintTab4")]
        private ImageButton _imgBtnPrintTab4;
        [AccessedThroughProperty("imgBtnPrintTab5")]
        private ImageButton _imgBtnPrintTab5;
        [AccessedThroughProperty("imgBtnSalvar")]
        private ImageButton _imgBtnSalvar;
        [AccessedThroughProperty("imgBtnSalvarEnd")]
        private ImageButton _imgBtnSalvarEnd;
        [AccessedThroughProperty("imgBtnTratar")]
        private ImageButton _imgBtnTratar;
        [AccessedThroughProperty("lblAlertaDocumentosQtd")]
        private Label _lblAlertaDocumentosQtd;
        [AccessedThroughProperty("lblAlertaDocumentosUltimaOcorrencia")]
        private Label _lblAlertaDocumentosUltimaOcorrencia;
        [AccessedThroughProperty("lblAlertaDocumentosValor")]
        private Label _lblAlertaDocumentosValor;
        [AccessedThroughProperty("lblBairroSPCCNPJ")]
        private Label _lblBairroSPCCNPJ;
        [AccessedThroughProperty("lblCepSPCCNPJ")]
        private Label _lblCepSPCCNPJ;
        [AccessedThroughProperty("lblChequeSemFundoCCFQtd")]
        private Label _lblChequeSemFundoCCFQtd;
        [AccessedThroughProperty("lblChequeSemFundoCCFUltimaOcorrencia")]
        private Label _lblChequeSemFundoCCFUltimaOcorrencia;
        [AccessedThroughProperty("lblChequeSemFundoCCFValor")]
        private Label _lblChequeSemFundoCCFValor;
        [AccessedThroughProperty("lblChequesSustadosMotivo21Qtd")]
        private Label _lblChequesSustadosMotivo21Qtd;
        [AccessedThroughProperty("lblChequesSustadosMotivo21UltimaOcorrencia")]
        private Label _lblChequesSustadosMotivo21UltimaOcorrencia;
        [AccessedThroughProperty("lblChequesSustadosMotivo21Valor")]
        private Label _lblChequesSustadosMotivo21Valor;
        [AccessedThroughProperty("lblChqCNPJ")]
        private Label _lblChqCNPJ;
        [AccessedThroughProperty("lblCitySPC")]
        private Label _lblCitySPC;
        [AccessedThroughProperty("lblCnaeinfor")]
        private Label _lblCnaeinfor;
        [AccessedThroughProperty("lblCnpjSPC")]
        private Label _lblCnpjSPC;
        [AccessedThroughProperty("lblComplSPCCNPJ")]
        private Label _lblComplSPCCNPJ;
        [AccessedThroughProperty("lblConfDadosTelQtd")]
        private Label _lblConfDadosTelQtd;
        [AccessedThroughProperty("lblConfDadosTelUltimaOcorrencia")]
        private Label _lblConfDadosTelUltimaOcorrencia;
        [AccessedThroughProperty("lblConfDadosTelValor")]
        private Label _lblConfDadosTelValor;
        [AccessedThroughProperty("lblConsultaRealizadaQtd")]
        private Label _lblConsultaRealizadaQtd;
        [AccessedThroughProperty("lblConsultaRealizadaUltimaOcorrencia")]
        private Label _lblConsultaRealizadaUltimaOcorrencia;
        [AccessedThroughProperty("lblConsultaRealizadaValor")]
        private Label _lblConsultaRealizadaValor;
        [AccessedThroughProperty("lblContraOrdemQtd")]
        private Label _lblContraOrdemQtd;
        [AccessedThroughProperty("lblContraOrdemUltimaOcorrencia")]
        private Label _lblContraOrdemUltimaOcorrencia;
        [AccessedThroughProperty("lblContraOrdemValor")]
        private Label _lblContraOrdemValor;
        [AccessedThroughProperty("lblCpfCampanha")]
        private Label _lblCpfCampanha;
        [AccessedThroughProperty("lblCpfSPC")]
        private Label _lblCpfSPC;
        [AccessedThroughProperty("lblCreditoConcedidoQtd")]
        private Label _lblCreditoConcedidoQtd;
        [AccessedThroughProperty("lblCreditoConcedidoUltimaOcorrencia")]
        private Label _lblCreditoConcedidoUltimaOcorrencia;
        [AccessedThroughProperty("lblCreditoConcedidoValor")]
        private Label _lblCreditoConcedidoValor;
        [AccessedThroughProperty("lblDDDFaxSPCCNPJ")]
        private Label _lblDDDFaxSPCCNPJ;
        [AccessedThroughProperty("lblDDDSPCCNPJ")]
        private Label _lblDDDSPCCNPJ;
        [AccessedThroughProperty("lblDocumentoPeSo")]
        private Label _lblDocumentoPeSo;
        [AccessedThroughProperty("lblDscNatJurSPCCNPJ")]
        private Label _lblDscNatJurSPCCNPJ;
        [AccessedThroughProperty("lblDscSituacaoSPC")]
        private Label _lblDscSituacaoSPC;
        [AccessedThroughProperty("lblEmpresaCNPJ")]
        private Label _lblEmpresaCNPJ;
        [AccessedThroughProperty("lblEndSPCCNPJ")]
        private Label _lblEndSPCCNPJ;
        [AccessedThroughProperty("lblFax")]
        private Label _lblFax;
        [AccessedThroughProperty("lblFoneSPCCNPJ")]
        private Label _lblFoneSPCCNPJ;
        [AccessedThroughProperty("lblInfoPoderJudiciarioQtd")]
        private Label _lblInfoPoderJudiciarioQtd;
        [AccessedThroughProperty("lblInfoPoderJudiciarioUltimaOcorrencia")]
        private Label _lblInfoPoderJudiciarioUltimaOcorrencia;
        [AccessedThroughProperty("lblInfoPoderJudiciarioValor")]
        private Label _lblInfoPoderJudiciarioValor;
        [AccessedThroughProperty("lblInformacaoCabecalho")]
        private Label _lblInformacaoCabecalho;
        [AccessedThroughProperty("lblInscrEstadualSPC")]
        private Label _lblInscrEstadualSPC;
        [AccessedThroughProperty("lblItemMenuEsquerda")]
        private Label _lblItemMenuEsquerda;
        [AccessedThroughProperty("lblMsgValidacao")]
        private Label _lblMsgValidacao;
        [AccessedThroughProperty("lblNatJurSPCCNPJ")]
        private Label _lblNatJurSPCCNPJ;
        [AccessedThroughProperty("lblNmComercial")]
        private Label _lblNmComercial;
        [AccessedThroughProperty("lblNomeSPC")]
        private Label _lblNomeSPC;
        [AccessedThroughProperty("lblNumSPCCNPJ")]
        private Label _lblNumSPCCNPJ;
        [AccessedThroughProperty("lblParticipacaoEmpresarial")]
        private Label _lblParticipacaoEmpresarial;
        [AccessedThroughProperty("lblQtdLogadoMesmoLogin")]
        private Label _lblQtdLogadoMesmoLogin;
        [AccessedThroughProperty("lblRazaoAnterior")]
        private Label _lblRazaoAnterior;
        [AccessedThroughProperty("lblRazaoSPC")]
        private Label _lblRazaoSPC;
        [AccessedThroughProperty("lblRegistroChequeLogistaQtd")]
        private Label _lblRegistroChequeLogistaQtd;
        [AccessedThroughProperty("lblRegistroChequeLogistaUltimaOcorrencia")]
        private Label _lblRegistroChequeLogistaUltimaOcorrencia;
        [AccessedThroughProperty("lblRegistroChequeLogistaValor")]
        private Label _lblRegistroChequeLogistaValor;
        [AccessedThroughProperty("lblRegSpcQtd")]
        private Label _lblRegSpcQtd;
        [AccessedThroughProperty("lblRegSpcUltimaOcorrencia")]
        private Label _lblRegSpcUltimaOcorrencia;
        [AccessedThroughProperty("lblRegSpcValor")]
        private Label _lblRegSpcValor;
        [AccessedThroughProperty("lblSaldoPrePago")]
        private Label _lblSaldoPrePago;
        [AccessedThroughProperty("lblSigno")]
        private TextBox _lblSigno;
        [AccessedThroughProperty("lblSituacaoSPCCNPJ")]
        private Label _lblSituacaoSPCCNPJ;
        [AccessedThroughProperty("lblUfSPCCNPJ")]
        private Label _lblUfSPCCNPJ;
        [AccessedThroughProperty("lblVlCapitalSPCCNPJ")]
        private Label _lblVlCapitalSPCCNPJ;
        [AccessedThroughProperty("linhaDataApresentacao")]
        private HtmlGenericControl _linhaDataApresentacao;
        [AccessedThroughProperty("linhaIdadeApresentacao")]
        private HtmlGenericControl _linhaIdadeApresentacao;
        [AccessedThroughProperty("lnkBtnBasico")]
        private LinkButton _lnkBtnBasico;
        [AccessedThroughProperty("lnkBtnCcf")]
        private LinkButton _lnkBtnCcf;
        [AccessedThroughProperty("lnkBtnContinuar")]
        private ImageButton _lnkBtnContinuar;
        [AccessedThroughProperty("lnkBtnDataPrev")]
        private LinkButton _lnkBtnDataPrev;
        [AccessedThroughProperty("lnkBtnImprimirConteudoPagina")]
        private LinkButton _lnkBtnImprimirConteudoPagina;
        [AccessedThroughProperty("lnkBtnLimparFormularioBuscaApresentacao")]
        private LinkButton _lnkBtnLimparFormularioBuscaApresentacao;
        [AccessedThroughProperty("lnkBtnMaisTelefone")]
        private LinkButton _lnkBtnMaisTelefone;
        [AccessedThroughProperty("lnkBtnNovoEndereco")]
        private LinkButton _lnkBtnNovoEndereco;
        [AccessedThroughProperty("lnkBtnNovoStatusParticipacaoEmpresarialSocios")]
        private LinkButton _lnkBtnNovoStatusParticipacaoEmpresarialSocios;
        [AccessedThroughProperty("lnkBtnPerfilConsumo")]
        private LinkButton _lnkBtnPerfilConsumo;
        [AccessedThroughProperty("lnkBtnPerfilPessoa")]
        private LinkButton _lnkBtnPerfilPessoa;
        [AccessedThroughProperty("lnkBtnSalvarConteudoPagina")]
        private LinkButton _lnkBtnSalvarConteudoPagina;
        [AccessedThroughProperty("lnkBtnSalvarNovoEmail")]
        private LinkButton _lnkBtnSalvarNovoEmail;
        [AccessedThroughProperty("lnkBtnSalvarNovoTel")]
        private LinkButton _lnkBtnSalvarNovoTel;
        [AccessedThroughProperty("lnkBtnVeiculos")]
        private LinkButton _lnkBtnVeiculos;
        [AccessedThroughProperty("lnkBtnVizinhos")]
        private LinkButton _lnkBtnVizinhos;
        [AccessedThroughProperty("lnkConsSPC")]
        private LinkButton _lnkConsSPC;
        [AccessedThroughProperty("lnkLimparCampos")]
        private LinkButton _lnkLimparCampos;
        [AccessedThroughProperty("lnkOpcoesAvancadas")]
        private LinkButton _lnkOpcoesAvancadas;
        [AccessedThroughProperty("lnkPesqBuscaApresentacao")]
        private LinkButton _lnkPesqBuscaApresentacao;
        [AccessedThroughProperty("lnkPesqCep")]
        private LinkButton _lnkPesqCep;
        [AccessedThroughProperty("lnkPesqEndereco")]
        private LinkButton _lnkPesqEndereco;
        [AccessedThroughProperty("lnkPesqNome")]
        private LinkButton _lnkPesqNome;
        [AccessedThroughProperty("lnkPesqPlacaVeiculo")]
        private LinkButton _lnkPesqPlacaVeiculo;
        [AccessedThroughProperty("lnkPesqTelefone")]
        private LinkButton _lnkPesqTelefone;
        [AccessedThroughProperty("lnkPessoasLigadas")]
        private LinkButton _lnkPessoasLigadas;
        [AccessedThroughProperty("mpeAguarde")]
        private ModalPopupExtender _mpeAguarde;
        [AccessedThroughProperty("mpeAguardeConsultaINSS")]
        private ModalPopupExtender _mpeAguardeConsultaINSS;
        [AccessedThroughProperty("mpeDataPrev")]
        private ModalPopupExtender _mpeDataPrev;
        [AccessedThroughProperty("mpeMsg")]
        private ModalPopupExtender _mpeMsg;
        [AccessedThroughProperty("mpeResultadoMenuEsquerda")]
        private ModalPopupExtender _mpeResultadoMenuEsquerda;
        [AccessedThroughProperty("mpeSPC")]
        private ModalPopupExtender _mpeSPC;
        [AccessedThroughProperty("mpeTratarDados")]
        private ModalPopupExtender _mpeTratarDados;
        [AccessedThroughProperty("pnlAguarde")]
        private Panel _pnlAguarde;
        [AccessedThroughProperty("pnlAguardeConsultaINSS")]
        private Panel _pnlAguardeConsultaINSS;
        [AccessedThroughProperty("pnlAlertaDocumentos")]
        private Panel _pnlAlertaDocumentos;
        [AccessedThroughProperty("pnlBuscaApresentacao")]
        private Panel _pnlBuscaApresentacao;
        [AccessedThroughProperty("pnlCadastroEmitentesChequeSemFundo")]
        private Panel _pnlCadastroEmitentesChequeSemFundo;
        [AccessedThroughProperty("pnlDataPrev")]
        private Panel _pnlDataPrev;
        [AccessedThroughProperty("pnlInformacoesCnpj")]
        private Panel _pnlInformacoesCnpj;
        [AccessedThroughProperty("pnlInformacoesCpf")]
        private Panel _pnlInformacoesCpf;
        [AccessedThroughProperty("pnlMsg")]
        private Panel _pnlMsg;
        [AccessedThroughProperty("pnlPesqCep")]
        private Panel _pnlPesqCep;
        [AccessedThroughProperty("pnlPesqEndereco")]
        private Panel _pnlPesqEndereco;
        [AccessedThroughProperty("pnlPesqPlacaVeiculo")]
        private Panel _pnlPesqPlacaVeiculo;
        [AccessedThroughProperty("pnlPesqPorNome")]
        private Panel _pnlPesqPorNome;
        [AccessedThroughProperty("pnlPesqTel")]
        private Panel _pnlPesqTel;
        [AccessedThroughProperty("pnlResultadoMenuEsquerda")]
        private Panel _pnlResultadoMenuEsquerda;
        [AccessedThroughProperty("pnlResultados")]
        private Panel _pnlResultados;
        [AccessedThroughProperty("pnlResumoOcorrencia")]
        private Panel _pnlResumoOcorrencia;
        [AccessedThroughProperty("pnlServicoInadimplenciaChequeLogista")]
        private Panel _pnlServicoInadimplenciaChequeLogista;
        [AccessedThroughProperty("pnlServicoInadimplenciaSPC")]
        private Panel _pnlServicoInadimplenciaSPC;
        [AccessedThroughProperty("pnlSPC")]
        private Panel _pnlSPC;
        [AccessedThroughProperty("pnlSpcCnpj")]
        private Panel _pnlSpcCnpj;
        [AccessedThroughProperty("pnlSpcCpf")]
        private Panel _pnlSpcCpf;
        [AccessedThroughProperty("pnlTratarDados")]
        private Panel _pnlTratarDados;
        [AccessedThroughProperty("radioBtnTipoPesquisa")]
        private RadioButtonList _radioBtnTipoPesquisa;
        [AccessedThroughProperty("radionBtnSexo")]
        private RadioButtonList _radionBtnSexo;
        [AccessedThroughProperty("rdBtnOpcoesCampanha")]
        private RadioButtonList _rdBtnOpcoesCampanha;
        [AccessedThroughProperty("smBuscaClean")]
        private ToolkitScriptManager _smBuscaClean;
        [AccessedThroughProperty("tabContainerDataPrev")]
        private TabContainer _tabContainerDataPrev;
        [AccessedThroughProperty("tabContainerSpcPf")]
        private TabContainer _tabContainerSpcPf;
        [AccessedThroughProperty("tabPanel1")]
        private TabPanel _tabPanel1;
        [AccessedThroughProperty("tabPanel2")]
        private TabPanel _tabPanel2;
        [AccessedThroughProperty("tabPanel3")]
        private TabPanel _tabPanel3;
        [AccessedThroughProperty("tabPanel4")]
        private TabPanel _tabPanel4;
        [AccessedThroughProperty("tabPanel5")]
        private TabPanel _tabPanel5;
        [AccessedThroughProperty("tabPanelDataGuia1")]
        private TabPanel _tabPanelDataGuia1;
        [AccessedThroughProperty("tabPanelDataGuia2")]
        private TabPanel _tabPanelDataGuia2;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("txtBairroT")]
        private TextBox _txtBairroT;
        [AccessedThroughProperty("txtCepApresentacao")]
        private TextBox _txtCepApresentacao;
        [AccessedThroughProperty("txtCEPT")]
        private TextBox _txtCEPT;
        [AccessedThroughProperty("txtCidadeApresentacao")]
        private TextBox _txtCidadeApresentacao;
        [AccessedThroughProperty("txtCidadeT")]
        private TextBox _txtCidadeT;
        [AccessedThroughProperty("txtCnae")]
        private TextBox _txtCnae;
        [AccessedThroughProperty("txtCnpj")]
        private TextBox _txtCnpj;
        [AccessedThroughProperty("txtComplementoApresentacao")]
        private TextBox _txtComplementoApresentacao;
        [AccessedThroughProperty("txtComplT")]
        private TextBox _txtComplT;
        [AccessedThroughProperty("txtCpf")]
        private TextBox _txtCpf;
        [AccessedThroughProperty("txtCpfCampanha")]
        private TextBox _txtCpfCampanha;
        [AccessedThroughProperty("txtDataAbertura")]
        private TextBox _txtDataAbertura;
        [AccessedThroughProperty("txtDataDesdePeSo")]
        private TextBox _txtDataDesdePeSo;
        [AccessedThroughProperty("txtDataFinalApresentacao")]
        private TextBox _txtDataFinalApresentacao;
        [AccessedThroughProperty("txtDataInicialApresentacao")]
        private TextBox _txtDataInicialApresentacao;
        [AccessedThroughProperty("txtDataNascimento")]
        private TextBox _txtDataNascimento;
        [AccessedThroughProperty("txtDddApresentacao")]
        private TextBox _txtDddApresentacao;
        [AccessedThroughProperty("txtDDDNovo")]
        private TextBox _txtDDDNovo;
        [AccessedThroughProperty("txtDocumentoPeSo")]
        private TextBox _txtDocumentoPeSo;
        [AccessedThroughProperty("txtDtSitCad")]
        private TextBox _txtDtSitCad;
        [AccessedThroughProperty("txtDtSitCadPJ")]
        private TextBox _txtDtSitCadPJ;
        [AccessedThroughProperty("txtEnderecoApresentacao")]
        private TextBox _txtEnderecoApresentacao;
        [AccessedThroughProperty("txtEnderecoT")]
        private TextBox _txtEnderecoT;
        [AccessedThroughProperty("txtEstadoT")]
        private TextBox _txtEstadoT;
        [AccessedThroughProperty("txtIdade")]
        private TextBox _txtIdade;
        [AccessedThroughProperty("txtIdadeFinalApresentacao")]
        private TextBox _txtIdadeFinalApresentacao;
        [AccessedThroughProperty("txtIdadeInicialApresentacao")]
        private TextBox _txtIdadeInicialApresentacao;
        [AccessedThroughProperty("txtNaturezaJuridica")]
        private TextBox _txtNaturezaJuridica;
        [AccessedThroughProperty("txtNome")]
        private TextBox _txtNome;
        [AccessedThroughProperty("txtNomeApresentacao")]
        private TextBox _txtNomeApresentacao;
        [AccessedThroughProperty("txtNomeFantasia")]
        private TextBox _txtNomeFantasia;
        [AccessedThroughProperty("txtNomeMae")]
        private TextBox _txtNomeMae;
        [AccessedThroughProperty("txtNovoEmail")]
        private TextBox _txtNovoEmail;
        [AccessedThroughProperty("txtNumeroApresentacao")]
        private TextBox _txtNumeroApresentacao;
        [AccessedThroughProperty("txtNumeroT")]
        private TextBox _txtNumeroT;
        [AccessedThroughProperty("txtPctPeSo")]
        private TextBox _txtPctPeSo;
        [AccessedThroughProperty("txtPesqBairro")]
        private TextBox _txtPesqBairro;
        [AccessedThroughProperty("txtPesqBairro2")]
        private TextBox _txtPesqBairro2;
        [AccessedThroughProperty("txtPesqCep")]
        private TextBox _txtPesqCep;
        [AccessedThroughProperty("txtPesqCidade")]
        private TextBox _txtPesqCidade;
        [AccessedThroughProperty("txtPesqCidade2")]
        private TextBox _txtPesqCidade2;
        [AccessedThroughProperty("txtPesqCpfCnpj")]
        private TextBox _txtPesqCpfCnpj;
        [AccessedThroughProperty("txtPesqDdd")]
        private TextBox _txtPesqDdd;
        [AccessedThroughProperty("txtPesqLogradouro")]
        private TextBox _txtPesqLogradouro;
        [AccessedThroughProperty("txtPesqNome")]
        private TextBox _txtPesqNome;
        [AccessedThroughProperty("txtPesqNumero")]
        private TextBox _txtPesqNumero;
        [AccessedThroughProperty("txtPesqPlacaVeiculo")]
        private TextBox _txtPesqPlacaVeiculo;
        [AccessedThroughProperty("txtPesqTelefone")]
        private TextBox _txtPesqTelefone;
        [AccessedThroughProperty("txtPesqUf")]
        private TextBox _txtPesqUf;
        [AccessedThroughProperty("txtPesqUf2")]
        private TextBox _txtPesqUf2;
        [AccessedThroughProperty("txtPorte")]
        private TextBox _txtPorte;
        [AccessedThroughProperty("txtRazao")]
        private TextBox _txtRazao;
        [AccessedThroughProperty("txtSitCadPf")]
        private TextBox _txtSitCadPf;
        [AccessedThroughProperty("txtSituacao")]
        private TextBox _txtSituacao;
        [AccessedThroughProperty("txtTelApresentacao")]
        private TextBox _txtTelApresentacao;
        [AccessedThroughProperty("txtTelNovo")]
        private TextBox _txtTelNovo;
        [AccessedThroughProperty("txtUfApresentacao")]
        private TextBox _txtUfApresentacao;

        public Home()
        {
            //base.Load += new EventHandler(this.Page_Load);
            List<WeakReference> firstXPTO = __ENCList;
            lock (firstXPTO)
            {
                __ENCList.Add(new WeakReference(this));
            }
        }

        protected void AbrirDialog(string msgCabecalho, string msgCorpo)
        {
            try
            {
                this._lblMsgValidacao.Text = msgCorpo;
                this._mpeMsg.Show();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "AbrirDialog", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void AbrirPopup(string url, string width, string height)
        {
            string strScript = "<script language='javascript' >";
            strScript = strScript + "window.open('" + url + "','Abrir','width=" + width + ",height=" + height + ", scrollbars=yes')</script>";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Open", strScript, false);
        }

        protected void AcessoControle()
        {
            PermissaoAcesso pa = ((Usuario)this.Session["USUARIO"]).PermissaoAcessoColecao.GetItemByProduto(1);
            LinkButton lnkOpcoesAvancadas = this._lnkOpcoesAvancadas;
            lnkOpcoesAvancadas.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkOpcoesAvancadas.ID);
            //lnkOpcoesAvancadas = null;
            LinkButton lnkPesqPlacaVeiculo = this._lnkPesqPlacaVeiculo;
            lnkPesqPlacaVeiculo.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkPesqPlacaVeiculo.ID);
            //lnkPesqPlacaVeiculo = null;
            LinkButton lnkPessoasLigadas = this._lnkPessoasLigadas;
            lnkPessoasLigadas.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkPessoasLigadas.ID);
            //lnkPessoasLigadas = null;
            LinkButton lnkBtnVizinhos = this._lnkBtnVizinhos;
            lnkBtnVizinhos.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkBtnVizinhos.ID);
            //lnkBtnVizinhos = null;
            LinkButton lnkBtnMaisTelefone = this._lnkBtnMaisTelefone;
            lnkBtnMaisTelefone.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkBtnMaisTelefone.ID);
            //lnkBtnMaisTelefone = null;
            LinkButton lnkBtnDataPrev = this._lnkBtnDataPrev;
            lnkBtnDataPrev.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkBtnDataPrev.ID);
            //lnkBtnDataPrev = null;
            LinkButton lnkBtnVeiculos = this._lnkBtnVeiculos;
            lnkBtnVeiculos.Visible = pa.AcessoControleModuloColecao.ControleVisivel(lnkBtnVeiculos.ID);
            //lnkBtnVeiculos = null;
        }

        private void AddJavaScriptControles()
        {
            this._txtPesqCpfCnpj.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqNome.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqBairro.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqCidade.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqUf.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqCep.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqLogradouro.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqNumero.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqBairro2.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqCidade2.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqUf2.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtPesqCep.Attributes.Add("onkeyup", "formataCEP(this,event)");
            this._txtNomeApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtIdadeInicialApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtIdadeFinalApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtEnderecoApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtComplementoApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtNumeroApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtCidadeApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtUfApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtCepApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtDddApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtTelApresentacao.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + this._btnNovaConsulta.ClientID + "').click();return false;}} else {return true}; ");
            this._txtIdadeInicialApresentacao.Attributes.Add("onkeyup", "formataInteiro(this,event)");
            this._txtIdadeFinalApresentacao.Attributes.Add("onkeyup", "formataInteiro(this,event)");
            this._txtCepApresentacao.Attributes.Add("onkeyup", "formataCEP(this,event)");
            this._txtDocumentoPeSo.Attributes.Add("onkeyup", "formataInteiro(this,event)");
            this._txtPctPeSo.Attributes.Add("onkeyup", "formataMoeda(this,event)");
        }

        protected void AtualizaBoxPontosCampanha()
        {
            this.Session["INFORMACOES_PARTICIPANTE"] = "Ol\x00e1 <strong>" + this.Session["NOME_PARTICIPANTE_CAMPANHA"].ToString() + "</strong>, voc\x00ea possui<strong> " + this.Session["QTD_CUPOM_PARTICIPANTE_CAMPANHA"].ToString() + " cupons! </strong>";
        }

        protected void AtualizaBoxPontosCampanhaInicial()
        {
            this._divBannersHome.Visible = true;
            this._divOpcional.Visible = Convert.ToBoolean(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["CPF_PARTICIPANTE_CAMPANHA"], string.Empty, false), true, false));
            this._imgBannerHomeCampanha.Visible = Convert.ToBoolean(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["CPF_PARTICIPANTE_CAMPANHA"], string.Empty, false), true, false));
            this._divBoxAtualize.Visible = Convert.ToBoolean(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["CPF_PARTICIPANTE_CAMPANHA"], string.Empty, false), false, true));
        }

        protected void btnAtualizarStatusParticipacaoEmpresarialSocios_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerator firstXPTO;
                try
                {
                    firstXPTO = this._dgParticipacaoEmpresarial.Items.GetEnumerator();
                    while (firstXPTO.MoveNext())
                    {
                        IEnumerator secondXPTO;
                        DataGridItem dgItem = (DataGridItem)firstXPTO.Current;
                        try
                        {
                            secondXPTO = ((RadioButtonList)dgItem.FindControl("radioBtnStatus")).Items.GetEnumerator();
                            while (secondXPTO.MoveNext())
                            {
                                ListItem item = (ListItem)secondXPTO.Current;
                                if (item.Selected)
                                {
                                    int identity = 0;
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false))
                                    {
                                        identity = ((IBIIntouch)this.Session["BUSINESS"]).DadosEmpresa.InserirEmpresa(Convert.ToInt32(item.Value), this._txtCpf.Text, dgItem.Cells[4].Text, "PE", dgItem.Cells[5].Text.Replace("&nbsp;", string.Empty), dgItem.Cells[6].Text.Replace("&nbsp;", string.Empty).Replace("/", "-"), ((Usuario)this.Session["USUARIO"]).IdLogin);
                                    }
                                    else
                                    {
                                        identity = ((IBIIntouch)this.Session["BUSINESS"]).DadosEmpresa.InserirEmpresa(Convert.ToInt32(item.Value), dgItem.Cells[4].Text, this._txtCnpj.Text, "SE", dgItem.Cells[5].Text.Replace("&nbsp;", string.Empty), dgItem.Cells[6].Text.Replace("&nbsp;", string.Empty).Replace("/", "-"), ((Usuario)this.Session["USUARIO"]).IdLogin);
                                    }
                                    if (this.Session["CPF_PARTICIPANTE_CAMPANHA"] != null)
                                    {
                                        this.Session["QTD_CUPOM_PARTICIPANTE_CAMPANHA"] = ((IBIIntouch)this.Session["BUSINESS"]).CampanhaAtualizeSuaSorte.PontuarCampanha(this.Session["CPF_PARTICIPANTE_CAMPANHA"].ToString(), (EnumTipoInformacao)Convert.ToInt32(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), EnumTipoInformacao.ParticipacaoEmpresarialPF, EnumTipoInformacao.SociosPJ)), identity);
                                        this.AtualizaBoxPontosCampanha();
                                    }
                                }
                            }
                        }
                        finally
                        {
                            //if (secondXPTO is IDisposable)
                            //{
                            //    (secondXPTO as IDisposable).Dispose();
                            //}
                        }
                    }
                }
                finally
                {
                    //if (firstXPTO is IDisposable)
                    //{
                    //    (firstXPTO as IDisposable).Dispose();
                    //}
                }
                this._txtDocumentoPeSo.Text = string.Empty;
                this._txtPctPeSo.Text = string.Empty;
                this._txtDataDesdePeSo.Text = string.Empty;
                this.CarregarDadosPessoa(this.Session["ID_PESSOA"].ToString());
                this._dgParticipacaoEmpresarial.Focus();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "btnSalvarStatusTel_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void btnAtualizaStatusTel_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerator firstXPTO;
                try
                {
                    firstXPTO = this._dgTelefone.Items.GetEnumerator();
                    while (firstXPTO.MoveNext())
                    {
                        IEnumerator secondXPTO;
                        DataGridItem dgItem = (DataGridItem)firstXPTO.Current;
                        try
                        {
                            secondXPTO = ((RadioButtonList)dgItem.FindControl("radioBtnStatusTel")).Items.GetEnumerator();
                            while (secondXPTO.MoveNext())
                            {
                                ListItem item = (ListItem)secondXPTO.Current;
                                if (item.Selected)
                                {
                                    int identity = 0;
                                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false))
                                    {
                                        identity = ((IBIIntouch)this.Session["BUSINESS"]).DadosTelefone.InserirNovoTelefonePf(((Usuario)this.Session["USUARIO"]).IdLogin, (this.Session["ID_PESSOA"]).ToString(), Convert.ToInt32(item.Value), dgItem.Cells[2].Text.ToString().Substring(1, 2), dgItem.Cells[2].Text.ToString().Replace("-", "").Substring(4, 8).Trim());
                                        if (this.Session["CPF_PARTICIPANTE_CAMPANHA"] != null)
                                        {
                                            this.Session["QTD_CUPOM_PARTICIPANTE_CAMPANHA"] = ((IBIIntouch)this.Session["BUSINESS"]).CampanhaAtualizeSuaSorte.PontuarCampanha(this.Session["CPF_PARTICIPANTE_CAMPANHA"].ToString(), EnumTipoInformacao.TelefonePF, identity);
                                            this.AtualizaBoxPontosCampanha();
                                        }
                                    }
                                    else
                                    {
                                        identity = ((IBIIntouch)this.Session["BUSINESS"]).DadosTelefone.InserirNovoTelefonePj(((Usuario)this.Session["USUARIO"]).IdLogin, (this.Session["ID_PESSOA"]).ToString(), Convert.ToInt32(item.Value), dgItem.Cells[2].Text.ToString().Substring(1, 2), dgItem.Cells[2].Text.ToString().Replace("-", "").Substring(4, 9).Trim());
                                        if (this.Session["CPF_PARTICIPANTE_CAMPANHA"] != null)
                                        {
                                            this.Session["QTD_CUPOM_PARTICIPANTE_CAMPANHA"] = ((IBIIntouch)this.Session["BUSINESS"]).CampanhaAtualizeSuaSorte.PontuarCampanha(this.Session["CPF_PARTICIPANTE_CAMPANHA"].ToString(), EnumTipoInformacao.TelefonePJ, identity);
                                            this.AtualizaBoxPontosCampanha();
                                        }
                                    }
                                }
                            }
                        }
                        finally
                        {
                            //if (secondXPTO is IDisposable)
                            //{
                            //    (secondXPTO as IDisposable).Dispose();
                            //}
                        }
                    }
                }
                finally
                {
                    //if (firstXPTO is IDisposable)
                    //{
                    //    (firstXPTO as IDisposable).Dispose();
                    //}
                }
                string[] opcoesAvancadas = new string[4];
                opcoesAvancadas[0] = this.Session["TIPO_PESSOA"].ToString();
                opcoesAvancadas[1] = (Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), "POR_CPF", "POR_CNPJ")).ToString();
                opcoesAvancadas[2] = this.Session["DOCUMENTO"].ToString();
                DataSet ds = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.LocalizarPessoaMarcondes(opcoesAvancadas, Convert.ToBoolean(((Acesso)this.Session["DADOS_ACESSO"]).Usuario.TipoUsuario.ToUpper() == "P" ? true : false));
                this.CarregarDadosDiretoPessoa(ds);
                this._mpeAguarde.Hide();
                //this.MostrarDadosPrincipaisJavaScript();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "btnSalvarStatusTel_Click", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            //this.LimparPesquisasAnteriores();
            this._AccordionOpcoesAvancadas.SelectedIndex = Convert.ToInt32(Interaction.IIf(this._AccordionOpcoesAvancadas.SelectedIndex == 1, 0, 1));
            if ((this._txtPesqCpfCnpj.Text.Trim() != string.Empty) | (this._hdnFieldPesquisa.Value != "APRESENTACAO"))
            {
                //this.LocalizarPessoa();
                this._txtPesqCpfCnpj.Text = "";
                this._mpeAguarde.Hide();
            }
            else if (this._hdnFieldPesquisa.Value == "APRESENTACAO")
            {
                this.Session["TIPO_PESSOA"] = this._radioBtnTipoPesquisa.SelectedValue;
                this.BuscaApresentacao(this._txtNomeApresentacao.Text, this._txtDataInicialApresentacao.Text, this._txtDataFinalApresentacao.Text, this._txtIdadeInicialApresentacao.Text, this._txtIdadeFinalApresentacao.Text, this._txtEnderecoApresentacao.Text, this._txtNumeroApresentacao.Text, this._txtComplementoApresentacao.Text, string.Empty, this._txtCidadeApresentacao.Text, this._txtUfApresentacao.Text, this._txtCepApresentacao.Text, this._txtDddApresentacao.Text, this._txtTelApresentacao.Text);
            }
            //this.LimparCamposPesquisa();
        }

        protected void BuscaApresentacao(string nome, string dataInicial, string dataFinal, string idadeInicial, string idadeFinal, string endereco, string numero, string complemento, string bairro, string cidade, string uf, string cep, string ddd, string telefone)
        {
            DataTable dt = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.BuscaApresentacao(this.Session["TIPO_PESSOA"].ToString(), nome, dataInicial, dataFinal, idadeInicial, idadeFinal, endereco, numero, complemento, bairro, cidade, uf, cep, ddd, telefone);
            if (dt != null)
            {
                //this.LimparPesquisasAnteriores();
                this._mpeAguarde.Hide();
                this._dgConsulta.Columns[1].HeaderText = (Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), "Idade", "Anos/Abertura")).ToString();
                this._dgConsulta.AllowSorting = true;
                this._dgConsulta.DataSource = dt;
                this.Session["DT_CONSULTA"] = dt;
                this._dgConsulta.CurrentPageIndex = 0;
                this._dgConsulta.DataBind();
                this._dgTelefone.Dispose();
                this._dgEmail.Dispose();
                this._dgEndereco.Dispose();
                this._dgDadosComerciais.Dispose();
                this._dgDadosExtra.Dispose();
                this._dgTelefone.DataBind();
                this._dgEmail.DataBind();
                this._dgEndereco.DataBind();
                this._dgDadosComerciais.DataBind();
                this._dgDadosExtra.DataBind();
                this._dgConsulta.Visible = true;
                this._pnlResultados.Visible = false;
            }
            else
            {
                //this.LimparPesquisasAnteriores();
                this._dgConsulta.Dispose();
                this._dgTelefone.Dispose();
                this._dgEmail.Dispose();
                this._dgEndereco.Dispose();
                this._dgDadosComerciais.Dispose();
                this._dgDadosExtra.Dispose();
                this._divLateralPerfil.Visible = false;
                this._dgConsulta.CurrentPageIndex = 0;
                this._dgConsulta.DataBind();
                this._dgTelefone.DataBind();
                this._dgEmail.DataBind();
                this._dgEndereco.DataBind();
                this._dgDadosComerciais.DataBind();
                this._dgDadosExtra.DataBind();
                this.Session["ID_PESSOA"] = null;
                this.Session["DOCUMENTO"] = null;
                this._pnlResultados.Visible = false;
                this.AbrirDialog("Localiza\x00e7\x00e3o Falhou", "Nenhum registro localizado!");
            }
            this._hdnFldOpcoesAvancadas.Value = "1";
        }

        private void CarregarDadosDiretoPessoa(DataSet dsDireto)
        {
            try
            {
                using (DataSet ds = dsDireto)
                {
                    IEnumerator thirdXPTO;
                    IEnumerator fourthXPTO;
                    IEnumerator fifthXPTO;
                    IEnumerator sixthXPTO;
                    switch (this.Session["TIPO_PESSOA"].ToString().ToUpper())
                    {
                        case "PF":
                            IEnumerator firtXPTO;
                            try
                            {
                                firtXPTO = ds.Tables[1].Rows.GetEnumerator();
                                while (firtXPTO.MoveNext())
                                {
                                    DataRow dr = (DataRow)firtXPTO.Current;
                                    this._txtCpf.Text = dr["CPF"].ToString();
                                    this._txtSitCadPf.Text = Convert.ToString(dr["SIT_RF"] == null ? string.Empty : dr["SIT_RF"].ToString());
                                    this._txtDtSitCad.Text = Convert.ToString(dr["DT_SIT_CAD"] == null ? string.Empty : dr["DT_SIT_CAD"].ToString());
                                    this._txtNome.Text = dr["NOME"].ToString();
                                    this._radionBtnSexo.Text = dr["SEXO"].ToString();
                                    if (dr["DATANASC"] == null)
                                    {
                                        this._txtDataNascimento.Text = "";
                                    }
                                    else
                                    {
                                        this._txtDataNascimento.Text = dr["DATANASC"].ToString();
                                    }
                                    this._txtIdade.Text = dr["IDADE"].ToString();
                                    this._txtNomeMae.Text = dr["NOME_MAE"].ToString();
                                    //this._lblSigno.Text = this.GetSigno(this._txtDataNascimento.Text);
                                    this.Session["ULT_NOME"] = dr["NOME_ULTIMO"].ToString();
                                }
                            }
                            finally
                            {
                                //if (firtXPTO is IDisposable)
                                //{
                                //    (firtXPTO as IDisposable).Dispose();
                                //}
                            }
                            //this.ReadyOnlyCamposPf(true);
                            break;

                        case "PJ":
                            IEnumerator secondXPTO;
                            try
                            {
                                secondXPTO = ds.Tables[1].Rows.GetEnumerator();
                                while (secondXPTO.MoveNext())
                                {
                                    DataRow dr = (DataRow)secondXPTO.Current;
                                    this._txtCnpj.Text = dr["CNPJ"].ToString();
                                    this._txtRazao.Text = dr["RAZAO"].ToString();
                                    this._txtNomeFantasia.Text = dr["NOME_FANTASIA"].ToString();
                                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DT_ABERTURA"])))
                                    {
                                        this._txtDataAbertura.Text = "";
                                    }
                                    else
                                    {
                                        this._txtDataAbertura.Text = DateTime.Parse(Convert.ToString(dr["DT_ABERTURA"])).ToString("dd/MM/yyyy");
                                    }
                                    this._txtCnae.Text = dr["COD_CNAE"].ToString() + " - " + dr["DESCRICAO_CNAE"].ToString();
                                    this._txtSituacao.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DESCR_SITUACAO_CAD"])), string.Empty, dr["DESCR_SITUACAO_CAD"].ToString()));
                                    this._txtDtSitCadPJ.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DATA_SITUACAO_CADASTRAL"])), string.Empty, dr["DATA_SITUACAO_CADASTRAL"].ToString()));
                                    this._txtNaturezaJuridica.Text = dr["NJUR"].ToString() + " - " + dr["NATUREZA"].ToString();
                                    this._txtPorte.Text = dr["PORTE"].ToString();
                                }
                            }
                            finally
                            {
                                //if (secondXPTO is IDisposable)
                                //{
                                //    (secondXPTO as IDisposable).Dispose();
                                //}
                            }
                            break;
                    }
                    this._txtNovoEmail.Text = string.Empty;
                    this._txtDDDNovo.Text = string.Empty;
                    this._txtTelNovo.Text = string.Empty;
                    //this.MostrarDadosPrincipaisJavaScript();
                    this._dgTelefone.DataSource = ds.Tables[2];
                    this._dgTelefone.DataBind();
                    int i = 0;
                    try
                    {
                        thirdXPTO = ds.Tables[2].Rows.GetEnumerator();
                        while (thirdXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)thirdXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (thirdXPTO is IDisposable)
                        //{
                        //    (thirdXPTO as IDisposable).Dispose();
                        //}
                    }
                    this._dgEndereco.DataSource = ds.Tables[3];
                    this._dgEndereco.DataBind();
                    i = 0;
                    try
                    {
                        fourthXPTO = ds.Tables[3].Rows.GetEnumerator();
                        while (fourthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)fourthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (fourthXPTO is IDisposable)
                        //{
                        //    (fourthXPTO as IDisposable).Dispose();
                        //}
                    }
                    this._dgEmail.DataSource = ds.Tables[4];
                    this._dgEmail.DataBind();
                    i = 0;
                    try
                    {
                        fifthXPTO = ds.Tables[4].Rows.GetEnumerator();
                        while (fifthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)fifthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (fifthXPTO is IDisposable)
                        //{
                        //    (fifthXPTO as IDisposable).Dispose();
                        //}
                    }
                    this._lblParticipacaoEmpresarial.Text = Convert.ToString(this.Session["TIPO_PESSOA"].ToString().ToUpper() == "PF" ? "Participa\x00e7\x00e3o Empresarial" : "S\x00f3cios");
                    this._dgParticipacaoEmpresarial.DataSource = ds.Tables[5];
                    this._dgParticipacaoEmpresarial.DataBind();
                    switch (this.Session["TIPO_PESSOA"].ToString())
                    {
                        case "PF":
                            this._lnkBtnNovoStatusParticipacaoEmpresarialSocios.ToolTip = "Adicionar novo CNPJ Participa\x00e7\x00e3o Empresarial";
                            this._lblDocumentoPeSo.Text = "Novo CNPJ: ";
                            this._lblDocumentoPeSo.ToolTip = "Novo CNPJ Participa\x00e7\x00e3o Empresarial: ";
                            break;

                        case "PJ":
                            this._lnkBtnNovoStatusParticipacaoEmpresarialSocios.ToolTip = "Adicionar novo CPF S\x00f3cio";
                            this._lblDocumentoPeSo.Text = "Novo CPF: ";
                            this._lblDocumentoPeSo.ToolTip = "Novo CPF S\x00f3cio: ";
                            break;
                    }
                    i = 0;
                    try
                    {
                        sixthXPTO = ds.Tables[5].Rows.GetEnumerator();
                        while (sixthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)sixthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (sixthXPTO is IDisposable)
                        //{
                        //    (sixthXPTO as IDisposable).Dispose();
                        //}
                    }
                    this._dgClienteAcessoRegistro.DataSource = ds.Tables[6];
                    this._dgClienteAcessoRegistro.DataBind();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "CarregarDadosDiretoPessoa", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void CarregarDadosPessoa(string idUnit)
        {
            try
            {
                DataSet ds = new DataSet();
                switch (this.Session["TIPO_PESSOA"].ToString().ToUpper())
                {
                    case "PF":
                        IEnumerator firstXPTO;
                        ds = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.CarregaDadosPf(idUnit, Convert.ToBoolean(((Acesso)this.Session["DADOS_ACESSO"]).Usuario.TipoUsuario.ToUpper() == "P" ? true : false));
                        try
                        {
                            firstXPTO = ds.Tables[0].Rows.GetEnumerator();
                            while (firstXPTO.MoveNext())
                            {
                                DataRow dr = (DataRow)firstXPTO.Current;
                                this._txtCpf.Text = dr["CPF"].ToString();
                                this._txtSitCadPf.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SIT_RF"])), string.Empty, dr["SIT_RF"].ToString()));
                                this._txtDtSitCad.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DT_SIT_CAD"])), string.Empty, dr["DT_SIT_CAD"].ToString()));
                                this._txtNome.Text = dr["NOME"].ToString();
                                this._radionBtnSexo.Text = dr["SEXO"].ToString();
                                if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DATANASC"])))
                                {
                                    this._txtDataNascimento.Text = "";
                                }
                                else
                                {
                                    this._txtDataNascimento.Text = dr["DATANASC"].ToString();
                                }
                                this._txtIdade.Text = dr["IDADE"].ToString();
                                this._txtNomeMae.Text = dr["NOME_MAE"].ToString();
                                //this._lblSigno.Text = this.GetSigno(this._txtDataNascimento.Text);
                                this.Session["ULT_NOME"] = dr["NOME_ULTIMO"].ToString();
                            }
                        }
                        finally
                        {
                            //if (firstXPTO is IDisposable)
                            //{
                            //    (firstXPTO as IDisposable).Dispose();
                            //}
                        }
                        //this.ReadyOnlyCamposPf(true);
                        break;

                    case "PJ":
                        IEnumerator secondXPTO;
                        ds = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.CarregaDadosPj(idUnit, Convert.ToBoolean(Interaction.IIf(((Acesso)this.Session["DADOS_ACESSO"]).Usuario.TipoUsuario.ToUpper() == "P", true, false)));
                        try
                        {
                            secondXPTO = ds.Tables[0].Rows.GetEnumerator();
                            while (secondXPTO.MoveNext())
                            {
                                DataRow dr = (DataRow)secondXPTO.Current;
                                this._txtCnpj.Text = dr["CNPJ"].ToString();
                                this._txtRazao.Text = dr["RAZAO"].ToString();
                                this._txtNomeFantasia.Text = dr["NOME_FANTASIA"].ToString();
                                if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DT_ABERTURA"])))
                                {
                                    this._txtDataAbertura.Text = "";
                                }
                                else
                                {
                                    this._txtDataAbertura.Text = DateTime.Parse(Convert.ToString(dr["DT_ABERTURA"])).ToString("dd/MM/yyyy");
                                }
                                this._txtCnae.Text = dr["COD_CNAE"].ToString() + " - " + dr["DESCRICAO_CNAE"].ToString();
                                this._txtSituacao.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DESCR_SITUACAO_CAD"])), string.Empty, dr["DESCR_SITUACAO_CAD"].ToString()));
                                this._txtDtSitCadPJ.Text = Convert.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["DATA_SITUACAO_CADASTRAL"])), string.Empty, dr["DATA_SITUACAO_CADASTRAL"].ToString()));
                                this._txtNaturezaJuridica.Text = dr["NJUR"].ToString() + " - " + dr["NATUREZA"].ToString();
                                this._txtPorte.Text = dr["PORTE"].ToString();
                            }
                        }
                        finally
                        {
                            //if (secondXPTO is IDisposable)
                            //{
                            //    (secondXPTO as IDisposable).Dispose();
                            //}
                        }
                        break;
                }
                this._txtNovoEmail.Text = string.Empty;
                this._txtDDDNovo.Text = string.Empty;
                this._txtTelNovo.Text = string.Empty;
                //this.MostrarDadosPrincipaisJavaScript();
                int i = 0;
                try
                {
                    IEnumerator thirthXPTO;
                    this._dgTelefone.DataSource = ds.Tables[1];
                    this._dgTelefone.DataBind();
                    try
                    {
                        thirthXPTO = ds.Tables[1].Rows.GetEnumerator();
                        while (thirthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)thirthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgTelefone.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (thirthXPTO is IDisposable)
                        //{
                        //    (thirthXPTO as IDisposable).Dispose();
                        //}
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception ex = exception1;
                    ProjectData.ClearProjectError();
                }
                try
                {
                    IEnumerator fouthXPTO;
                    this._dgEndereco.DataSource = ds.Tables[2];
                    this._dgEndereco.DataBind();
                    i = 0;
                    try
                    {
                        fouthXPTO = ds.Tables[2].Rows.GetEnumerator();
                        while (fouthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)fouthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgEndereco.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (fouthXPTO is IDisposable)
                        //{
                        //    (fouthXPTO as IDisposable).Dispose();
                        //}
                    }
                }
                catch (Exception exception2)
                {
                    ProjectData.SetProjectError(exception2);
                    Exception ex = exception2;
                    ProjectData.ClearProjectError();
                }
                try
                {
                    IEnumerator fifthXPTO;
                    this._dgEmail.DataSource = ds.Tables[3];
                    this._dgEmail.DataBind();
                    i = 0;
                    try
                    {
                        fifthXPTO = ds.Tables[3].Rows.GetEnumerator();
                        while (fifthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)fifthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgEmail.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (fifthXPTO is IDisposable)
                        //{
                        //    (fifthXPTO as IDisposable).Dispose();
                        //}
                    }
                }
                catch (Exception exception3)
                {
                    ProjectData.SetProjectError(exception3);
                    Exception ex = exception3;
                    ProjectData.ClearProjectError();
                }
                this._lblParticipacaoEmpresarial.Text = Convert.ToString(Interaction.IIf(this.Session["TIPO_PESSOA"].ToString().ToUpper() == "PF", "Participa\x00e7\x00e3o Empresarial", "S\x00f3cios"));
                try
                {
                    IEnumerator sixthXPTO;
                    this._dgParticipacaoEmpresarial.DataSource = ds.Tables[4];
                    this._dgParticipacaoEmpresarial.DataBind();
                    switch (this.Session["TIPO_PESSOA"].ToString())
                    {
                        case "PF":
                            this._lnkBtnNovoStatusParticipacaoEmpresarialSocios.ToolTip = "Adicionar novo CNPJ Participa\x00e7\x00e3o Empresarial";
                            this._lblDocumentoPeSo.Text = "Novo CNPJ: ";
                            this._lblDocumentoPeSo.ToolTip = "Novo CNPJ Participa\x00e7\x00e3o Empresarial: ";
                            break;

                        case "PJ":
                            this._lnkBtnNovoStatusParticipacaoEmpresarialSocios.ToolTip = "Adicionar novo CPF S\x00f3cio";
                            this._lblDocumentoPeSo.Text = "Novo CPF: ";
                            this._lblDocumentoPeSo.ToolTip = "Novo CPF S\x00f3cio: ";
                            break;
                    }
                    i = 0;
                    try
                    {
                        sixthXPTO = ds.Tables[4].Rows.GetEnumerator();
                        while (sixthXPTO.MoveNext())
                        {
                            DataRow dr = (DataRow)sixthXPTO.Current;
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) <= 0)
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_00.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 1) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 4))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_01.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 4) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 6))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_02.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 6) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 8))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_03.png";
                            }
                            if ((Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 8) & (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) < 10))
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_04.png";
                            }
                            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr["RANKING"])) >= 10)
                            {
                                ((Image)this._dgParticipacaoEmpresarial.Items[i].Cells[0].FindControl("imgRanking")).ImageUrl = "img/ic_stars_05.png";
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        //if (sixthXPTO is IDisposable)
                        //{
                        //    (sixthXPTO as IDisposable).Dispose();
                        //}
                    }
                }
                catch (Exception exception4)
                {
                    ProjectData.SetProjectError(exception4);
                    Exception ex = exception4;
                    ProjectData.ClearProjectError();
                }
                try
                {
                    this._dgClienteAcessoRegistro.DataSource = ds.Tables[5];
                    this._dgClienteAcessoRegistro.DataBind();
                }
                catch (Exception exception5)
                {
                    ProjectData.SetProjectError(exception5);
                    Exception ex = exception5;
                    ProjectData.ClearProjectError();
                }
                ds.Dispose();
            }
            catch (Exception exception6)
            {
                ProjectData.SetProjectError(exception6);
                Exception ex = exception6;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "CarregarDadosPessoa", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void CarregarEmpresasLigadas()
        {
            try
            {
                using (DataTable dt = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.CarregaEmpresasLigadas(this.Session["ID_PESSOA"].ToString(), (Usuario)this.Session["USUARIO"], Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.Session["ID_HISTORICO_LOGIN"]))))
                {
                    if (dt == null)
                    {
                        this.Session["ctrl"] = null;
                        this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                        this.AbrirDialog("Busca falhou", "N\x00e3o Existem Pessoas/Empresas Ligadas!");
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                        this.AbrirDialog("Busca falhou", "N\x00e3o Existem Pessoas/Empresas Ligadas!");
                    }
                    else
                    {
                        dt.Columns.Add("NOMEABREVIADO");
                        DataGrid dgDadosExtra = this._dgDadosExtra;
                        dgDadosExtra.DataSource = dt;
                        dgDadosExtra.DataBind();
                        dgDadosExtra.Columns[3].Visible = false;
                        this.Session["crtl"] = this._dgDadosExtra;
                        dgDadosExtra.CssClass = "visualizar";
                        dgDadosExtra = null;
                        DataGrid dgVizinhos = this._dgVizinhos;
                        dgVizinhos.DataSource = null;
                        dgVizinhos.DataBind();
                        dgVizinhos.CssClass = "naoVisualizar";
                        dgVizinhos = null;
                        DataGrid dgDadosComerciais = this._dgDadosComerciais;
                        dgDadosComerciais.DataSource = null;
                        dgDadosComerciais.DataBind();
                        dgDadosComerciais.CssClass = "naoVisualizar";
                        dgDadosComerciais = null;
                        DataGrid dgDadosDireto = this._dgDadosDireto;
                        dgDadosDireto.DataSource = null;
                        dgDadosDireto.DataBind();
                        dgDadosDireto.CssClass = "naoVisualizar";
                        dgDadosDireto = null;
                        this._lblItemMenuEsquerda.Text = Convert.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(("<h1><strong>" + this._lnkPessoasLigadas.Text + ": </strong>") + this._lnkPessoasLigadas.ToolTip + "</h1><strong>Nome: </strong>", Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), this._txtNome.Text, this._txtRazao.Text)), "<br><strong>CPF/CNPJ: </strong>"), this.Session["DOCUMENTO"].ToString()));
                        this._mpeResultadoMenuEsquerda.Show();
                        //this.MostrarDadosPrincipaisJavaScript();
                        //this.PrintPopup(this._dgDadosExtra);
                    }
                }
                this._mpeAguarde.Hide();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "CarregarPessoasLigadas", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void CarregarPessoasLigadas()
        {
            try
            {
                using (DataTable dtPessoasLigadas = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.CarregarPessoasLigadas(Convert.ToString(this.Session["ID_PESSOA"] == null ? "0" : this.Session["ID_PESSOA"]), this.Session["ULT_NOME"].ToString(), (Usuario)this.Session["USUARIO"], Convert.ToInt32(this.Session["ID_HISTORICO_LOGIN"].ToString())))
                {
                    if (dtPessoasLigadas == null)
                    {
                        this.Session["ctrl"] = null;
                        this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                        this.AbrirDialog("Busca falhou", "N\x00e3o Existem Pessoas Ligadas!");
                    }
                    else
                    {
                        dtPessoasLigadas.Columns.Add("NOMEABREVIADO");
                        DataGrid dgDadosExtra = this._dgDadosExtra;
                        dgDadosExtra.DataSource = dtPessoasLigadas;
                        dgDadosExtra.DataBind();
                        dgDadosExtra.Columns[3].Visible = true;
                        dgDadosExtra.CssClass = "visualizar";
                        dgDadosExtra = null;
                        DataGrid dgVizinhos = this._dgVizinhos;
                        dgVizinhos.DataSource = null;
                        dgVizinhos.DataBind();
                        dgVizinhos.CssClass = "naoVisualizar";
                        dgVizinhos = null;
                        DataGrid dgDadosComerciais = this._dgDadosComerciais;
                        dgDadosComerciais.DataSource = null;
                        dgDadosComerciais.DataBind();
                        dgDadosComerciais.CssClass = "naoVisualizar";
                        dgDadosComerciais = null;
                        DataGrid dgDadosDireto = this._dgDadosDireto;
                        dgDadosDireto.DataSource = null;
                        dgDadosDireto.DataBind();
                        dgDadosDireto.CssClass = "naoVisualizar";
                        dgDadosDireto = null;
                        this._lblItemMenuEsquerda.Text = Convert.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(("<h1><strong>" + this._lnkPessoasLigadas.Text + ": </strong>") + this._lnkPessoasLigadas.ToolTip + "</h1><strong>Nome: </strong>", Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), this._txtNome.Text, this._txtRazao.Text)), "<br><strong>CPF/CNPJ: </strong>"), this.Session["DOCUMENTO"].ToString()));
                        this._mpeResultadoMenuEsquerda.Show();
                        //this.MostrarDadosPrincipaisJavaScript();
                        //this.PrintPopup(this._dgDadosExtra);
                    }
                }
                this._mpeAguarde.Hide();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                this.AbrirDialog("Busca falhou", "N\x00e3o Existem Pessoas Ligadas!");
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "CarregarPessoasLigadas", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void ClearTextSPC()
        {
            IEnumerator firstXPTO;
            try
            {
                firstXPTO = this._pnlSPC.Controls[1].Controls[0].Controls.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    object item = RuntimeHelpers.GetObjectValue(firstXPTO.Current);
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                    }
                }
            }
            finally
            {
                //if (firstXPTO is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
        }

        protected void CriarLinkDadosPesquisados(string idPessoa, string documento, string detalhes, ref DataSet ds)
        {
            try
            {
                if (ds == null)
                    ds = new DataSet();

                IEnumerator firstXPTO;
                bool linkExistente = false;
                this.Session["ID_PESSOA"] = idPessoa;
                this.Session["DOCUMENTO"] = documento;
                if (this.Session["DADOS_PESQUISADOS"] == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("idPessoa");
                    dt.Columns.Add("documento");
                    dt.Columns.Add("detalhes");
                    this.Session["DADOS_PESQUISADOS"] = dt;
                    dt.Dispose();
                }
                try
                {
                    firstXPTO = ((DataTable)this.Session["DADOS_PESQUISADOS"]).Rows.GetEnumerator();
                    while (firstXPTO.MoveNext())
                    {
                        DataRow dr = (DataRow)firstXPTO.Current;
                        if (dr["idPessoa"].ToString() == idPessoa)
                        {
                            linkExistente = true;
                            //goto Label_011E;
                        }
                    }
                }
                finally
                {
                    //if (firstXPTO is IDisposable)
                    //{
                    //    (firstXPTO as IDisposable).Dispose();
                    //}
                }
                if (!linkExistente)
                {
                    DataRow dr = ((DataTable)this.Session["DADOS_PESQUISADOS"]).NewRow();
                    dr["idPessoa"] = RuntimeHelpers.GetObjectValue(this.Session["ID_PESSOA"]);
                    dr["documento"] = RuntimeHelpers.GetObjectValue(this.Session["DOCUMENTO"]);
                    dr["detalhes"] = detalhes.ToUpper();
                    ((DataTable)this.Session["DADOS_PESQUISADOS"]).Rows.Add(dr);
                    this._dgPesquisasRecentes.Visible = true;
                    this._dgPesquisasRecentes.DataSource = RuntimeHelpers.GetObjectValue(this.Session["DADOS_PESQUISADOS"]);
                    this._dgPesquisasRecentes.DataBind();
                    int numXPTO = 0;
                    //if (((IBIIntouch)this.Session["BUSINESS"]).Consulta.AutorizadoParaConsultar(((Usuario)this.Session["USUARIO"]).DsLogin.ToString(), this.Context.Request.UserHostAddress.ToString(), ((Usuario)this.Session["USUARIO"]).DsSenha.ToString(), ((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToString(), EnumProduto.Intouch, ref numXPTO))
                    //{
                    //    ((IBIIntouch)this.Session["BUSINESS"]).Consulta.CobrarConsulta((Usuario)this.Session["USUARIO"], Convert.ToString(this.Session["ID_PESSOA"]), Conversions.ToInteger(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), 1, 4)), Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.Session["ID_HISTORICO_LOGIN"])));
                    //}
                    //else
                    //{
                        this.Response.Redirect("Redirect.aspx", false);
                        return;
                    //}
                }
                if (ds == null)
                {
                    this.CarregarDadosPessoa(Conversions.ToString(this.Session["ID_PESSOA"]));
                }
                else
                {
                    this.CarregarDadosDiretoPessoa(ds);
                }
                this._mpeAguarde.Hide();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "CriarLinkDadosPesquisados", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void DadosPopupEsquerda(string acao)
        {
            IEnumerator firstXPTO;
            int i = 0;
            try
            {
                firstXPTO = this._dgDadosDireto.Items.GetEnumerator();
                while (firstXPTO.MoveNext())
                {
                    DataGridItem dgItem = (DataGridItem)firstXPTO.Current;
                    while (i < dgItem.Cells.Count)
                    {
                        if (acao.ToUpper() == "EDITAR")
                        {
                            dgItem.Cells[i].Text = "<input type=text style='width:auto;' class='CamposPq' value='" + dgItem.Cells[i].Text.TrimEnd(new char[0]).TrimStart(new char[0]) + "'>";
                        }
                        else
                        {
                            dgItem.Cells[i].Text = dgItem.Cells[i].Text.TrimEnd(new char[0]).TrimStart(new char[0]).Replace("<input type=text style='width:auto;' class='CamposPq' value='", "").Replace("'>", "");
                        }
                        i++;
                    }
                    i = 0;
                }
            }
            finally
            {
                //if (firstXPTO0 is IDisposable)
                //{
                //    (firstXPTO as IDisposable).Dispose();
                //}
            }
            this._mpeResultadoMenuEsquerda.Show();
        }

        protected void dgConsulta_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "EXIBIRCONSULTA")
                {
                    this._hdnFldOpcoesAvancadas.Value = "1";
                    this._AccordionOpcoesAvancadas.SelectedIndex = Conversions.ToInteger(this._hdnFldOpcoesAvancadas.Value);
                    this._divLateralPerfil.Visible = true;
                    this.ExibirResultado(e.Item.Cells[6].Text, e.Item.Cells[2].Text, ((LinkButton)e.Item.FindControl("lnkBtnNome")).Text);
                    this._mpeAguarde.Hide();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgConsulta_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgConsulta_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            try
            {
                this._dgConsulta.CurrentPageIndex = e.NewPageIndex;
                this._dgConsulta.DataSource = RuntimeHelpers.GetObjectValue(this.Session["DT_CONSULTA"]);
                this.Session["DT_CONSULTA"] = RuntimeHelpers.GetObjectValue(this.Session["DT_CONSULTA"]);
                this._dgConsulta.DataBind();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgConsulta_PageIndexChanged", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgConsulta_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            try
            {
                DataView dv = new DataView((DataTable)this.Session["DT_CONSULTA"])
                {
                    Sort = e.SortExpression
                };
                this._dgConsulta.DataSource = dv;
                this._dgConsulta.DataBind();
                dv.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgConsulta_SortCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgDadosComerciais_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "EXIBIRDADOSCOMERCIAIS")
                {
                    this._hdnFieldPesquisa.Value = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), "POR_CNPJ", "POR_CPF"));
                    this._hdnFieldTipoPessoa.Value = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), "PJ", "PF"));
                    this.Session["TIPO_PESSOA"] = this._hdnFieldTipoPessoa.Value;
                    Usuario usuario = (Usuario)this.Session["USUARIO"];
                    DataSet dtXPTO = null;
                    this.CriarLinkDadosPesquisados(e.Item.Cells[1].Text, e.Item.Cells[2].Text, ((LinkButton)e.Item.FindControl("lnkBtnDadosComerciais")).Text, ref dtXPTO);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgDadosComerciais_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgDadosExtra_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                this.Session["TIPO_PESSOA"] = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.GetTipoDocumento(e.Item.Cells[2].Text);
                if (e.CommandName.ToUpper() == "EXIBIRDADOSEXTRA")
                {
                    object objXPTO = this.Session["TIPO_PESSOA"];
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(objXPTO, "PF", false))
                    {
                        this._hdnFieldPesquisa.Value = "POR_CPF";
                        this._hdnFieldTipoPessoa.Value = "PF";
                    }
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(objXPTO, "PJ", false))
                    {
                        this._hdnFieldPesquisa.Value = "POR_CNPJ";
                        this._hdnFieldTipoPessoa.Value = "PJ";
                    }
                    Usuario usuario = (Usuario)this.Session["USUARIO"];
                    DataSet dtXPTO = null;
                    this.CriarLinkDadosPesquisados(e.Item.Cells[1].Text, e.Item.Cells[2].Text, ((LinkButton)e.Item.FindControl("lnkBtnDadosExtra")).ToolTip, ref dtXPTO);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgDadosExtra_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgDadosExtra_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            try
            {
                if ((e.Item.ItemType == ListItemType.Item) | (e.Item.ItemType == ListItemType.AlternatingItem))
                {
                    ((LinkButton)e.Item.FindControl("lnkBtnDadosExtra")).Text = ((LinkButton)e.Item.FindControl("lnkBtnDadosExtra")).Text;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgDadosExtra_ItemDataBound", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgEmail_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "LIMPARSELECAO")
                {
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEmail")).Items[0].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEmail")).Items[1].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEmail")).Items[2].Selected = false;
                }
                //this.MostrarDadosPrincipaisJavaScript();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgEmail_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgEndereco_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "LIMPARSELECAO")
                {
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEndereco")).Items[0].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEndereco")).Items[1].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusEndereco")).Items[2].Selected = false;
                    //this.MostrarDadosPrincipaisJavaScript();
                }
                else if (e.CommandName.ToUpper() == "CARREGARINFORMACOES")
                {
                    //this._lnkPesqEndereco_Click(null, null);
                    this._txtPesqLogradouro.Text = e.Item.Cells[11].Text;
                    this._txtPesqNumero.Text = e.Item.Cells[3].Text;
                    this._txtPesqBairro2.Text = e.Item.Cells[7].Text;
                    this._txtPesqCidade2.Text = e.Item.Cells[6].Text;
                    this._txtPesqUf2.Text = e.Item.Cells[8].Text;
                    this._radioBtnTipoPesquisa.SelectedValue = this.Session["TIPO_PESSOA"].ToString();
                    this.btnNovaConsulta_Click(null, null);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgEndereco_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgIpsLoginDia_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "DENUNCIARIP")
            {
                new BlackList(e.Item.Cells[0].Text, ((Acesso)this.Session["DADOS_ACESSO"]).Cliente, ((Acesso)this.Session["DADOS_ACESSO"]).Login).DenunciarIp();
                this.AbrirDialog("Denuncia de IP", "O IP " + e.Item.Cells[0].Text + " foi denunciado e j\x00e1 est\x00e1 cadastrado em nossa black list.");
            }
        }

        private void dgParticipacaoEmpresarial_CancelCommand(object source, DataGridCommandEventArgs e)
        {
        }

        protected void dgParticipacaoEmpresarial_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "EXIBIRDADOSPARTICIPACAOEMPRESARIAL")
                {
                    this._txtPesqCpfCnpj.Text = e.Item.Cells[4].Text;
                    this._AccordionOpcoesAvancadas.SelectedIndex = Conversions.ToInteger(Interaction.IIf(this._AccordionOpcoesAvancadas.SelectedIndex == 1, 0, 1));
                    //this.LocalizarPessoa();
                    this._mpeAguarde.Hide();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgParticipacaoEmpresarial_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgPesquisasRecentes_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "EXIBIRDADOSPESQUISADOS")
                {
                    this.Session["ID_PESSOA"] = e.Item.Cells[0].Text;
                    this.Session["DOCUMENTO"] = e.Item.Cells[1].Text;
                    this.Session["TIPO_PESSOA"] = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.GetTipoDocumento(Conversions.ToString(this.Session["DOCUMENTO"]));
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false))
                    {
                        this._hdnFieldPesquisa.Value = "POR_CPF";
                        this._hdnFieldTipoPessoa.Value = "PF";
                    }
                    else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PJ", false))
                    {
                        this._hdnFieldPesquisa.Value = "POR_CNPJ";
                        this._hdnFieldTipoPessoa.Value = "PJ";
                    }
                    this._dgConsulta.Dispose();
                    this._dgTelefone.Dispose();
                    this._dgEmail.Dispose();
                    this._dgEndereco.Dispose();
                    this._dgDadosComerciais.Dispose();
                    this._dgDadosExtra.Dispose();
                    this._dgConsulta.DataBind();
                    this._dgTelefone.DataBind();
                    this._dgEmail.DataBind();
                    this._dgEndereco.DataBind();
                    this._dgDadosComerciais.DataBind();
                    this._dgDadosExtra.DataBind();
                    this.CarregarDadosPessoa(Conversions.ToString(this.Session["ID_PESSOA"]));
                    //this.MostrarDadosPrincipaisJavaScript();
                    this._mpeAguarde.Hide();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgPesquisasRecentes_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgPesquisasRecentes_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            try
            {
                if ((e.Item.ItemType == ListItemType.Item) | (e.Item.ItemType == ListItemType.AlternatingItem))
                {
                    ((LinkButton)e.Item.FindControl("lnkBtnDadosExtra")).Text = ((LinkButton)e.Item.FindControl("lnkBtnDadosExtra")).Text;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgPesquisasRecentes_ItemDataBound", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgTelefone_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "LIMPARSELECAO")
                {
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusTel")).Items[0].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusTel")).Items[1].Selected = false;
                    ((RadioButtonList)e.Item.FindControl("radioBtnStatusTel")).Items[2].Selected = false;
                }
                else if (e.CommandName.ToUpper() == "CARREGARINFORMACOES")
                {
                    string[] opcoesAvancadas = new string[] { this.Session["TIPO_PESSOA"].ToString(), "POR_TELEFONE", e.Item.Cells[2].Text.Substring(1, 2), e.Item.Cells[2].Text.Replace("-", "").Substring(4, 8) };
                    using (DataTable dt = ((IBIIntouch)this.Session["BUSINESS"]).Consulta.LocalizarPessoaMarcondes(opcoesAvancadas, Conversions.ToBoolean(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Acesso)this.Session["DADOS_ACESSO"]).Usuario.TipoUsuario.ToUpper(), "P" , false) == 0, true, false))).Tables[0])
                    {
                        if (dt.Rows.Count == 0)
                        {
                            this.AbrirDialog("Localiza\x00e7\x00e3o Falhou", "Nenhum registro foi localizado!");
                        }
                        else if (dt.Rows.Count == 1)
                        {
                            this._divLateralPerfil.Visible = true;
                            this._dgConsulta.DataSource = dt;
                            this._dgConsulta.DataBind();
                            this._dgTelefone.DataSource = null;
                            this._dgEmail.DataSource = null;
                            this._dgEndereco.DataSource = null;
                            this._dgDadosComerciais.DataSource = null;
                            this._dgDadosExtra.DataSource = null;
                            this._dgTelefone.DataBind();
                            this._dgEmail.DataBind();
                            this._dgEndereco.DataBind();
                            this._dgDadosComerciais.DataBind();
                            this._dgDadosExtra.DataBind();
                            this.ExibirResultado(this._dgConsulta.Items[0].Cells[6].Text, this._dgConsulta.Items[0].Cells[1].Text, this._dgConsulta.Items[0].Cells[2].Text);
                        }
                        else
                        {
                            this._mpeAguarde.Hide();
                            this._dgConsulta.AllowSorting = true;
                            this._dgConsulta.DataSource = dt;
                            this.Session["DT_CONSULTA"] = dt;
                            this._dgConsulta.CurrentPageIndex = 0;
                            this._dgConsulta.DataBind();
                            this._dgTelefone.DataSource = null;
                            this._dgEmail.DataSource = null;
                            this._dgEndereco.DataSource = null;
                            this._dgDadosComerciais.DataSource = null;
                            this._dgDadosExtra.DataSource = null;
                            this._dgTelefone.DataBind();
                            this._dgEmail.DataBind();
                            this._dgEndereco.DataBind();
                            this._dgDadosComerciais.DataBind();
                            this._dgDadosExtra.DataBind();
                            this._dgConsulta.Visible = true;
                            this._pnlResultados.Visible = false;
                            this._divConsulta.Visible = false;
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgTelefone_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void dgVizinhos_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper() == "EXIBIRCONSULTA")
                {
                    this._divLateralPerfil.Visible = true;
                    this.ExibirResultado(e.Item.Cells[6].Text, e.Item.Cells[1].Text, ((LinkButton)e.Item.FindControl("lnkBtnNome")).Text);
                    this._mpeAguarde.Hide();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "dgConsulta_ItemCommand", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        private void EsconderControlesViaJavaScript(List<string> controles)
        {
            string strScript = "<script language='javascript'>";
            foreach (string item in controles)
            {
                strScript = strScript + "" + item + "').style.display='none';";
            }
            strScript = strScript + "</script>";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Esconder", strScript, false);
        }

        protected void ExibirResultado(DataSet ds)
        {
            this.CriarLinkDadosPesquisados(ds.Tables[0].Rows[0]["ID_UNIT"].ToString(), ds.Tables[0].Rows[0]["DOCUMENTO"].ToString(), ds.Tables[0].Rows[0]["NOME"].ToString(), ref ds);
            this._pnlResultados.Visible = true;
            this._dgConsulta.Visible = false;
        }

        protected void ExibirResultado(string idPessoa, string documento, string detalhes)
        {
            DataSet dtXPTO = null;
            this.CriarLinkDadosPesquisados(idPessoa, documento, detalhes.TrimStart(new char[0]).TrimEnd(new char[0]), ref dtXPTO);
            this._pnlResultados.Visible = true;
            this._dgConsulta.Visible = false;
        }

        private void FormataTipoPesquisa(string tipo)
        {
            try
            {
                if (tipo.ToUpper() == "CPF")
                {
                    this._hdnFieldTipoPessoa.Value = "PF";
                    this._hdnFieldPesquisa.Value = "POR_CPF";
                    this.Session["TIPO_PESSOA"] = this._hdnFieldTipoPessoa.Value;
                }
                else
                {
                    this._hdnFieldTipoPessoa.Value = "PJ";
                    this._hdnFieldPesquisa.Value = "POR_CNPJ";
                    this.Session["TIPO_PESSOA"] = this._hdnFieldTipoPessoa.Value;
                }
                this._AccordionOpcoesAvancadas.SelectedIndex = 1;
                this._hdnFldOpcoesAvancadas.Value = Conversions.ToString(this._AccordionOpcoesAvancadas.SelectedIndex);
                this._pnlResultados.Visible = false;
                //this.MostrarCamposPesquisa(string.Empty);
                this._txtPesqCpfCnpj.Text = string.Empty;
                this._txtPesqCpfCnpj.Focus();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw new Exception(GlobalPage.MsgErro(((Usuario)this.Session["USUARIO"]).Cliente.Nome.ToUpper(), ((Usuario)this.Session["USUARIO"]).DsLogin.ToUpper(), "intouch", "BuscaClean.aspx", "FormataTipoPesquisa", ex.Message, ex.StackTrace, this.Form.Controls));
            }
        }

        protected void GetConsignado()
        {
            //HisconServicesSoapClient wsConsignado = new HisconServicesSoapClient();
            DataSet ds = new DataSet();
            string codigo = string.Empty;
            Credito unitShop = new Credito();
            double valorConsulta = Conversions.ToDouble(ConfigurationManager.AppSettings["VALOR_CONSULTA_PREPAGO"]);
            try
            {
                if (unitShop.Obter_ClientePossuiSaldoSuficiente((long)((Acesso)this.Session["DADOS_ACESSO"]).Cliente, true, valorConsulta))
                {
                    int contador = 0;
                    //codigo = wsConsignado.ConsultaProvider_IncluiConsulta(ConfigurationManager.AppSettings["WSCONSIGNADO.LOGIN"], ConfigurationManager.AppSettings["WSCONSIGNADO.SENHA"], this.Session["DOCUMENTO"].ToString(), string.Empty).Tables[0].Rows[0]["codigo"].ToString();
                    while (ds.Tables.Count < 3)
                    {
                        //ds = wsConsignado.ConsultaProvider_SelecionaConsulta(ConfigurationManager.AppSettings["WSCONSIGNADO.LOGIN"], ConfigurationManager.AppSettings["WSCONSIGNADO.SENHA"], codigo);
                        if (ds.Tables[0].Columns.Contains("codigo") && ((ds.Tables[0].Rows[0]["codigo"].ToString() != "1") & (ds.Tables[0].Rows[0]["codigo"].ToString() != "2")))
                        {
                            this.AbrirDialog("N\x00e3o foram encontrados dados para o CPF informado.", "N\x00e3o foram encontrados dados para o CPF informado.");
                            return;
                        }
                        if (contador == 30)
                        {
                            this.AbrirDialog("Consulta INSS Indisponivel no momento. Tente novamento mais tarde.", "Consulta INSS Indisponivel no momento. Tente novamento mais tarde.");
                            return;
                        }
                        Thread.Sleep(0x3e8);
                        contador++;
                    }
                    this._dgDataPrevGuia1.DataSource = ds.Tables[0];
                    this._dgDataPrevGuia1.DataBind();
                    this._dgDataPrevGuia1Resumo.DataSource = ds.Tables[0];
                    this._dgDataPrevGuia1Resumo.DataBind();
                    this._dgDataPrevGuia2Credito.DataSource = ds.Tables[1];
                    this._dgDataPrevGuia2Credito.DataBind();
                    this._dgDataPrevGuia2Debito.DataSource = ds.Tables[2];
                    this._dgDataPrevGuia2Debito.DataBind();
                    //this._lblInformacaoCabecalho.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(("<h1><strong>" + this._lnkBtnDataPrev.Text + ": </strong>") + this._lnkBtnDataPrev.ToolTip + "</h1><strong>Nome: </strong>", Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.Session["TIPO_PESSOA"], "PF", false), this._txtNome.Text, this._txtRazao)))));
                }
            }
            catch { }
        }
    }
}