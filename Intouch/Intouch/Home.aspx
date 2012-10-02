<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Estrutura.Master"
    CodeBehind="Home.aspx.cs" Inherits="Intouch.Home" EnableEventValidation="false"
    ValidateRequest="false" Culture="pt-BR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headEstrutura" runat="server">
    <style type="text/css">
        .LateralPerfil, .Busca
        {
            display: block !important;
        }
        .Meio
        {
            background: url(img/Bg_Meio.jpg) repeat-x top;
            float: left;
        }
    </style>
    <%--<link href="intouch/css/CSSintouchClean.css" rel="stylesheet"
        type="text/css" />

    <script src="intouch/JavaScript/Mascara.js" type="text/javascript"></script>--%>
   
    <link href="css/CSSintouchClean.css" rel="stylesheet" type="text/css" />        
    <link href="css/Estilo.css" rel="stylesheet" type="text/css" />
    <link href="css/layout.css" rel="stylesheet" type="text/css" />
    <link href="css/layoutClean.css" rel="stylesheet" type="text/css" />
    <link href="css/Reset.css" rel="stylesheet" type="text/css" />
    
    
   <%-- <link href="css/CSSintouchClean.css" rel="stylesheet" type="text/css" />--%>

    <script src="JavaScript/Mascara.js" type="text/javascript"></script>

    <script language="JavaScript" type="text/javascript">

        function abrirModalAguarde() {
            $find("ctl00_CContentPlaceHolderEstrutura_mpeAguarde").show();
        }
        function abrirModalAguardeConsultaINSS() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeAguardeConsultaINSS").show();
        }
        function fecharModalMsg() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeMsg").hide();
        }

        function fecharModalBuscaApresentacao() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeBuscaApresentacao").hide();
        }

        function fecharModalNovoEnd() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeTratarDados").hide();
        }

        function fecharModalResultadoMenuEsquerda() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeResultadoMenuEsquerda").hide();
        }
        function fecharModalSPC() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeSPC").hide();
        }
        function fecharModalDataPrev() {
            $find("ctl00_ContentPlaceHolderEstrutura_mpeDataPrev").hide();
        }

        function CobrarAba() {
            alert('olaaa');
        }
        function VisualizarControlesCampanha(valor) {
            if (valor == 0) {
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_lblCpfCampanha').style.visibility = 'hidden';
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_txtCpfCampanha').style.visibility = 'hidden';
            }
            if (valor == 1) {
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_lblCpfCampanha').style.visibility = 'visible';
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_txtCpfCampanha').style.visibility = 'visible';
            }
        }


        function Numero(e) {
            navegador = /msie/i.test(navigator.userAgent);
            if (navegador)
                var tecla = event.keyCode;
            else
                var tecla = e.which;

            if (tecla > 47 && tecla < 58) // numeros de 0 a 9
                return true;
            else {
                if (tecla != 8) // backspace
                    return false;
                else
                    return true;
            }
        }

        function GetIdUsuario(valor) {
            if (valor.split('|').length == 2) {
                novoArray = valor.split('|');
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_txtPesqCpfCnpj').value = novoArray[0]; // retornará "DsLogin"
                document.getElementById('ctl00_ContentPlaceHolderEstrutura_btnNovaConsulta').click();
            }
        }
              
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderEstrutura" runat="server">
    <cc1:ToolkitScriptManager ID="smBuscaClean" runat="server" />
    <!--logotipo intouch e pesquisa cpf/cnpj-->
    <asp:LinkButton ID="lnkBtnSalvarConteudoPagina" runat="server" Style="display: none;"
        Text="salvar" />
    <asp:LinkButton ID="lnkBtnImprimirConteudoPagina" runat="server" Style="display: none;"
        Text="salvar" />
    <div class="LateralPerfil" id="divLateralPerfil" runat="server">
        <div>
            <h1>
                Consulta Paga</h1>
            <ul>
                <div class="boxAtualize">
                    <div class="topo-box">
                    </div>
                    <p style="margin: 5px 0 0 10px;">
                    <% if (Session["INFORMACOES_PARTICIPANTE"] != null) {%>
                        <%=Session["INFORMACOES_PARTICIPANTE"].ToString()%>                        
                    <%} %></p>
                    <p style="margin: 5px 0 10px 10px;">
                        <%--<asp:Label ID="lblQtdCuponsParticipanteCampanha" runat="server" Text=""></asp:Label>--%></p>
                    <a href="http://www.onebuscas.com.br">
                        <div class="bottom-box">
                        </div>
                    </a>
                </div>
                <li class="Atual">
                    <asp:LinkButton ID="lnkBtnBasico" runat="server" Text="Básico" ToolTip="Informações Cadastrais Inicial"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnPerfilPessoa" runat="server" Text="Perfil" OnClientClick="abrirModalAguarde();"
                        ToolTip="Perfil"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnPerfilConsumo" runat="server" Text="Perfil de Consumo"
                        OnClientClick="abrirModalAguarde();" ToolTip="Perfil de Consumo"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnMaisTelefone" runat="server" Text="Mais Telefones" OnClientClick="abrirModalAguarde();"
                        ToolTip="Mais Telefones"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnVeiculos" runat="server" Text="Veículos" OnClientClick="abrirModalAguarde();"
                        ToolTip="Veículos"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnCcf" runat="server" Text="CCF (Consulta Cheque)" OnClientClick="abrirModalAguarde();"
                        ToolTip="Consulta de Pendência de Cheque"></asp:LinkButton></li>
                <li class="Separador">
                    <hr />
                </li>
                <li>
                    <asp:LinkButton ID="lnkPessoasLigadas" runat="server" Text="Pessoas/Empresas ligadas"
                        OnClientClick="abrirModalAguarde();" ToolTip="Cálculo de Parentes e Vínculo Comercial"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnVizinhos" runat="server" Text="Vizinhos" OnClientClick="abrirModalAguarde();"
                        ToolTip="Vizinhos mais próximos"></asp:LinkButton></li>
            </ul>
        </div>
        <div>
            <h1>
                Consultas Pré-Pagas</h1>
            <ul>
                <li style="display:none;">
                    <asp:LinkButton ID="lnkConsSPC" runat="server" Text="Inadimplência" OnClientClick="abrirModalAguarde();"
                        Visible="false" ToolTip="Consulta SPC - Pendência Financeira"></asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lnkBtnDataPrev" runat="server" Text="Consulta INSS" OnClientClick="abrirModalAguardeConsultaINSS();"
                        Visible="true" ToolTip="Consulta INSS"></asp:LinkButton></li>
                 <li><a href="#" style="color:Black;"><asp:Label ID="lblSaldoPrePago" runat="server" ToolTip="Saldo Pré-Pago"></asp:Label></a></li>
            </ul>
        </div>
        <div>
            <h1>
                Consultas Recentes</h1>
            <ul>
                <asp:DataGrid ID="dgPesquisasRecentes" runat="server" AutoGenerateColumns="False"
                    GridLines="None" ShowHeader="false">
                    <Columns>
                        <asp:BoundColumn DataField="IDPESSOA" HeaderText="IDPESSOA" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="DOCUMENTO" HeaderText="DOCUMENTO" Visible="False"></asp:BoundColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <li class="Atual2Linhas">
                                    <asp:LinkButton ID="lnkBtnDadosExtra" runat="server" CommandName="EXIBIRDADOSPESQUISADOS"
                                        Text='<%#Eval("DETALHES") %>' ToolTip='<%#Eval("DETALHES") %>'></asp:LinkButton>
                                </li>
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </ul>
        </div>
        <div>
            <h1>
                Qtd. Consultada do Registro<br />
                (Últimos 3 Meses)</h1>
            <ul>
                <asp:DataGrid ID="dgClienteAcessoRegistro" runat="server" AutoGenerateColumns="False"
                    GridLines="None" ShowHeader="false">
                    <Columns>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <span>
                                    <li class="Atual2Linhas">
                                        <asp:Label ID="lblQtdPesqMes" runat="server" Text='<%#Eval("Clientes que pesquisaram esse registro")%>'
                                            Font-Size="15px"></asp:Label>
                                    </li>
                                </span>
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </ul>
        </div>
    </div>
    <div class="Busca">
        <div class="FormBusca">
            <h3>
                CNPJ/CPF:</h3>
            <asp:TextBox ID="txtPesqCpfCnpj" runat="server" autocomplete="off" CssClass="Campos CampoBusca"></asp:TextBox>
            <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtPesqCpfCnpj"
                ServiceMethod="GetDocumentoList" ServicePath="wsIntouch.asmx" UseContextKey="false"
                MinimumPrefixLength="3" EnableCaching="true" CompletionSetCount="12" CompletionInterval="10"
                BehaviorID="autoCompleteBehavior1" CompletionListCssClass="autocomplete_completionListElement2"
                CompletionListItemCssClass="autocomplete_listItem2" CompletionListHighlightedItemCssClass="autocomplete_highlightedList2" />
            <asp:Button ID="btnNovaConsulta" runat="server" Text="Buscar" CssClass="Btn BtnPeq"
                OnClientClick="abrirModalAguarde();" />
        </div>
        <div class="BuscaAvancada">
            <asp:LinkButton ID="lnkOpcoesAvancadas" runat="server" Text="» Opções Avançadas"></asp:LinkButton>
            <table border="0">
                <tr>
                    <td>
                        <asp:HiddenField ID="hdnFieldPesquisa" runat="server" />
                        <asp:HiddenField ID="hdnFieldTipoPessoa" runat="server" />
                        <asp:HiddenField ID="hdnFldOpcoesAvancadas" runat="server" />
                        <cc1:Accordion ID="AccordionOpcoesAvancadas" runat="server" SelectedIndex="0" HeaderCssClass=""
                            ContentCssClass="" FadeTransitions="true" FramesPerSecond="30" TransitionDuration="60"
                            RequireOpenedPane="false" AutoSize="None">
                            <Panes>
                                <cc1:AccordionPane ID="AccordionPaneOpcoesAvancadas" runat="server">
                                    <Header>
                                    </Header>
                                    <Content>
                                        <div class="Avancadas">
                                            <div class="Cabecalho">
                                                <h1>
                                                    Opções Avançadas</h1>
                                                <h2>
                                                    Escolha o Tipo de Pesquisa:</h2>
                                                <asp:RadioButtonList ID="radioBtnTipoPesquisa" runat="server" RepeatDirection="Horizontal"
                                                    AutoPostBack="true" CssClass="Radio" ToolTip="Tipo de Pesquisa">
                                                    <asp:ListItem Selected="True" Value="PF">Pessoa Física</asp:ListItem>
                                                    <asp:ListItem Value="PJ">Pessoa Jurídica</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </div>
                                            <div class="Filtros">
                                                <ul>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqNome" runat="server" Text="Por nome"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqTelefone" runat="server" Text="Por telefone"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqCep" runat="server" Text="Por CEP"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqEndereco" runat="server" Text="Por Endereço"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqPlacaVeiculo" runat="server" Text="Por Veículo"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkPesqBuscaApresentacao" runat="server" Text="Todos"></asp:LinkButton>
                                                    </li>
                                                    <li>
                                                        <asp:LinkButton ID="lnkLimparCampos" runat="server" Text="Limpar campos" Style="display: none;"></asp:LinkButton>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="CamposFiltros">
                                                <asp:Panel ID="pnlPesqPorNome" runat="server">
                                                    <div id="DIV_POR_NOME">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por Nome</strong></h3>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Nome:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqNome" runat="server" CssClass="CamposMd" Width="270px"></asp:TextBox>
                                                            * obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Bairro:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqBairro" runat="server" CssClass="CamposMd" Width="155px"></asp:TextBox>
                                                            opcional
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Cidade:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqCidade" runat="server" CssClass="CamposMd" Width="155px"></asp:TextBox>
                                                            opcional
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                UF:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqUf" runat="server" CssClass="CamposMd" MaxLength="2" Width="20px"></asp:TextBox>
                                                            opcional
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="pnlPesqTel" runat="server">
                                                    <div id="DIV_POR_TELEFONE">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por Telefone</strong></h3>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                DDD:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqDdd" runat="server" MaxLength="2" Width="20px" CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:FilteredTextBoxExtender ID="filteredTxtPesqDdd" runat="server" TargetControlID="txtPesqDdd" FilterType="Numbers"></cc1:FilteredTextBoxExtender>
                                                            obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Telefone:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqTelefone" runat="server" Width="87px" MaxLength="9" CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:FilteredTextBoxExtender ID="FilteredTxtPesqTelefone" runat="server" TargetControlID="txtPesqTelefone" FilterType="Numbers"></cc1:FilteredTextBoxExtender>
                                                            obrigatório
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="pnlPesqCep" runat="server">
                                                    <div id="DIV_POR_CEP">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por CEP</strong></h3>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                CEP</div>
                                                            <asp:TextBox ID="txtPesqCep" runat="server" Width="87px" MaxLength="9" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="pnlPesqEndereco" runat="server">
                                                    <div id="DIV_POR_ENDERECO">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por Endereço</strong></h3>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Logradouro:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqLogradouro" runat="server" Width="334px" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Nº:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqNumero" runat="server" Width="40px" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Bairro:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqBairro2" runat="server" Width="158px" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Cidade:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqCidade2" runat="server" Width="158px" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                UF:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqUf2" runat="server" MaxLength="2" Width="20px" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="pnlPesqPlacaVeiculo" runat="server">
                                                    <div id="DIV_PLACA_VEICULO">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por Placa do Veículo</strong></h3>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Placa Veículo:
                                                            </div>
                                                            <asp:TextBox ID="txtPesqPlacaVeiculo" runat="server" Width="87px" MaxLength="9" CssClass="CamposMd"></asp:TextBox>
                                                            obrigatório
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="pnlBuscaApresentacao" runat="server">
                                                    <div id="DIV1">
                                                        <h3>
                                                            Pesquisa Avançada: <strong>Por Todos</strong></h3>
                                                        <asp:LinkButton ID="lnkBtnLimparFormularioBuscaApresentacao" runat="server" Text="» Limpar Campos"
                                                            CssClass="LimparCampos"></asp:LinkButton>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Nome:
                                                            </div>
                                                            <asp:TextBox ID="txtNomeApresentacao" runat="server" Width="409px" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm" id="linhaDataApresentacao" runat="server">
                                                            <div class="Txt">
                                                                Data de Abertura:
                                                            </div>
                                                            <asp:TextBox ID="txtDataInicialApresentacao" runat="server" Width="70px" MaxLength="10"
                                                                CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:CalendarExtender ID="calendarDataInicialApresentacao" runat="server" TargetControlID="txtDataInicialApresentacao"
                                                                Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy">
                                                            </cc1:CalendarExtender>
                                                            até
                                                            <asp:TextBox ID="txtDataFinalApresentacao" runat="server" Width="70px" MaxLength="10"
                                                                CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:CalendarExtender ID="calendarDataFinalApresentacao" runat="server" TargetControlID="txtDataFinalApresentacao"
                                                                Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy">
                                                            </cc1:CalendarExtender>
                                                        </div>
                                                        <div class="LinhaForm" id="linhaIdadeApresentacao" runat="server">
                                                            <div class="Txt">
                                                                Idade:
                                                            </div>
                                                            De:<asp:TextBox ID="txtIdadeInicialApresentacao" runat="server" CssClass="CamposMd"
                                                                Width="40px" MaxLength="3"></asp:TextBox>
                                                            à<asp:TextBox ID="txtIdadeFinalApresentacao" runat="server" Width="40px" MaxLength="3"
                                                                CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Endereço:
                                                            </div>
                                                            <asp:TextBox ID="txtEnderecoApresentacao" runat="server" Width="409px" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Número:
                                                            </div>
                                                            <asp:TextBox ID="txtNumeroApresentacao" runat="server" Width="50px" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Complemento:
                                                            </div>
                                                            <asp:TextBox ID="txtComplementoApresentacao" runat="server" Width="100px" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Cidade:
                                                            </div>
                                                            <asp:TextBox ID="txtCidadeApresentacao" runat="server" Width="400px" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                UF :</div>
                                                            <asp:TextBox ID="txtUfApresentacao" runat="server" Width="100px" MaxLength="2" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                CEP:</div>
                                                            <asp:TextBox ID="txtCepApresentacao" runat="server" Width="100px" MaxLength="9" CssClass="CamposMd"></asp:TextBox>
                                                        </div>
                                                        <div class="LinhaForm">
                                                            <div class="Txt">
                                                                Telefone:</div>
                                                            <asp:TextBox ID="txtDddApresentacao" runat="server" Width="30px" MaxLength="2" CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:FilteredTextBoxExtender ID="FilteredTxtDddApresentacao" runat="server" TargetControlID="txtDddApresentacao" FilterType="Numbers"></cc1:FilteredTextBoxExtender>
                                                            <asp:TextBox ID="txtTelApresentacao" runat="server" Width="80px" MaxLength="9" CssClass="CamposMd"></asp:TextBox>
                                                            <cc1:FilteredTextBoxExtender ID="FilteredTxtTelApresentacao" runat="server" TargetControlID="txtTelApresentacao" FilterType="Numbers"></cc1:FilteredTextBoxExtender>
                                                        </div>
                                                    </div>
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </Content>
                                </cc1:AccordionPane>
                            </Panes>
                        </cc1:Accordion>
                        <div class="resultado">
                            <asp:DataGrid ID="dgConsulta" runat="server" CellPadding="4" Width="100%" AutoGenerateColumns="False"
                                GridLines="None" AllowPaging="True" PageSize="15" CssClass="Table700">
                                <SelectedItemStyle />
                                <AlternatingItemStyle CssClass="Listra" />
                                <PagerStyle NextPageText="Proximo" PrevPageText="Anterior" Mode="NumericPages" PageButtonCount="5"
                                    CssClass="Header" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="Nome">
                                        <ItemTemplate>
                                            <div>
                                                <asp:LinkButton ID="lnkBtnNome" runat="server" Text='<%#Eval("NOME") %>' CommandName="EXIBIRCONSULTA"></asp:LinkButton></div>
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:BoundColumn DataField="IDADE" HeaderText="Idade" SortExpression="IDADE" Visible="True">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="DOCUMENTO" HeaderText="Documento" SortExpression="DOCUMENTO"
                                        Visible="true"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="BAIRRO" HeaderText="Bairro" SortExpression="BAIRRO" Visible="true">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="CIDADE" HeaderText="Cidade" SortExpression="CIDADE" Visible="true">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ESTADO" HeaderText="UF" SortExpression="ESTADO" Visible="true">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ID_UNIT" HeaderText="ID_UNIT" Visible="False" SortExpression="ID_UNIT">
                                    </asp:BoundColumn>
                                </Columns>
                                <HeaderStyle CssClass="Header" />
                                <FooterStyle />
                            </asp:DataGrid>
                            <asp:Panel ID="pnlAguarde" runat="server">
                                <center>
                                    <br />
                                    <img src="img/aguarde2.gif" alt="" style="display: none" />
                                </center>
                            </asp:Panel>
                            <cc1:ModalPopupExtender ID="mpeAguarde" runat="server" TargetControlID="btnMpeAguarde"
                                PopupControlID="pnlAguarde" BackgroundCssClass="modalBackground" OkControlID="btnMpeAguarde"
                                CancelControlID="btnMpeAguarde" />
                            <asp:Button ID="btnMpeAguarde" runat="server" Text="Button" Style="display: none" />
                            <asp:Panel ID="pnlAguardeConsultaINSS" runat="server" ForeColor="White" Style="display: none;">
                                <center class="ModalLayout">
                                    <img src="img/close.png" style="cursor: pointer;" alt="" onclick="fecharModalResultadoMenuEsquerda();"
                                        class="Right" />
                                    <h2 style="color: #1a1a1a;">
                                        Nome do Beneficiário: <u>
                                            <%= txtNome.Text %></u></h2>
                                    <br />
                                    <br />
                                    <h2 style="color: #1a1a1a; margin-top: 30px;">
                                        CPF: <u>
                                            <%=txtCpf.Text%></u></h2>
                                    <br />
                                    <br />
                                    <h2 style="color: #1a1a1a; margin-top: 30px;">
                                        Data de Nascimento: <u>
                                            <%=txtDataNascimento.Text%></u></h2>
                                    <br />
                                    <br />
                                    <h1 style="color: #1a1a1a; font: 16px;">
                                        Aguardando Processamento Consulta INSS...</h1>
                                </center>
                            </asp:Panel>
                            <cc1:ModalPopupExtender ID="mpeAguardeConsultaINSS" runat="server" TargetControlID="btnAguardeConsultaINSS"
                                PopupControlID="pnlAguardeConsultaINSS" BackgroundCssClass="modalBackground"
                                OkControlID="btnAguardeConsultaINSS" CancelControlID="btnAguardeConsultaINSS" />
                            <asp:Button ID="btnAguardeConsultaINSS" runat="server" Text="Button" Style="display: none" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    
    <div class="BannersHome" id="divBannersHome" runat="server">
        <div class="opcional" id="divOpcional" runat="server">
            <h2>
                Gostaria de Participar da Campanha "<strong>Atualize sua Sorte</strong>"?</h2>
            <asp:RadioButtonList ID="rdBtnOpcoesCampanha" runat="server" RepeatDirection="Horizontal"
                AutoPostBack="false" Width="400px" CssClass="opcionalformata">
                <asp:ListItem Value="0" onclick="javascript:VisualizarControlesCampanha(this.value);">Sim, Quero participar!</asp:ListItem>
                <asp:ListItem Value="1" Selected="True" onclick="javascript:VisualizarControlesCampanha(this.value);">Já sou Participante!</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblCpfCampanha" runat="server" Text="CPF:" CssClass="opcionalformataCpf"></asp:Label>
            <asp:TextBox ID="txtCpfCampanha" runat="server" MaxLength="11" CssClass="opcionalformata1"
                Width="150" Height="20"></asp:TextBox>
            <asp:ImageButton ID="lnkBtnContinuar" runat="server" CssClass="btn-continuar" ImageUrl="~/img/btn-continuar.png" />
        </div>
        <div class="BannerDefault">
            <a href="http://www.onebuscas.com.br" target="_blank">
            <img src="img/BannerHome_Default.jpg" /></a></div>
        <div class="BannerCampanha" id="divBannerCampanha" runat="server">
            <a href="http://www.onebuscas.com.br" target="_blank">
                <img src="img/BannerHome_Campanha.jpg" id="imgBannerHomeCampanha" runat="server" style="margin-top: -65px;" />
            </a>
            
           <!-- Box de Extrato: para aparecer tem que tirar o 'display:none'--> 
           <div class="boxAtualize BoxAtualizeHome" id="divBoxAtualize" runat="server">
                <div class="topo-box"></div>
                <div class="MeioBoxAtualize">
                    <p style="margin: 5px 0 0 10px;">
                    <% if (Session["INFORMACOES_PARTICIPANTE"] != null){%>
                        <%= Session["INFORMACOES_PARTICIPANTE"].ToString()%>
                    <%} %></p>
                    <p style="margin: 5px 0 10px 10px;"></p>
                    <a href="http://www.onebuscas.com.br">
                </div>
                    <div class="bottom-box">
                    </div>
                </a>
            </div>
            <!-- Fim do Box de Extrato--> 
            
        </div>
    </div>
    <div class="Consulta" id="divConsulta" runat="server">
        <div class="DIV_RESULTADOS">
            <asp:Panel ID="pnlResultados" runat="server">
                <div class="dadoscadastrais">
                    <div class="ic_funcoes_dadoscadastrais Left">
                        <div class="ic_funcao1">
                            <asp:ImageButton ID="imgBtnSalvar" runat="server" ImageUrl="~/img/ic_inserir_novo.png"
                                ToolTip="Atualizar" OnClientClick="abrirModalAguarde();" /></div>
                        <div class="ic_funcao2">
                            <asp:ImageButton ID="imgBtnEditar" runat="server" ImageUrl="~/img/ic_editar.png"
                                ToolTip="Editar Dados Cadastrais" /></div>
                        <div class="ic_funcao3">
                            <asp:ImageButton ID="imgBtnCancelar" runat="server" ImageUrl="~/img/ic_cancelar.png"
                                ToolTip="Cancelar" /></div>
                    </div>
                    <div id="DIV_INFORMACOES_CPF">
                        <asp:Panel ID="pnlInformacoesCpf" runat="server">
                            <h5>
                                Dados Cadastrais</h5>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            CPF:</label></div>
                                    <asp:TextBox ID="txtCpf" runat="server" CssClass="CamposMd Pequeno4"></asp:TextBox>
                                    <label>
                                        Status:</label>
                                    <asp:TextBox ID="txtSitCadPf" runat="server" CssClass="CamposMd Pequeno3"></asp:TextBox>
                                    <label>
                                        Atualizado:</label>
                                    <asp:TextBox ID="txtDtSitCad" runat="server" CssClass="CamposMd Pequeno3"></asp:TextBox>
                                </div>
                                <div class="Right">
                                    <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" CssClass="BtnMedio Pequeno2"
                                        NavigateUrl="http://www.receita.fazenda.gov.br/aplicacoes/atcta/cpf/consultapublica.asp"
                                        Text="Situação Cadastral"> </asp:HyperLink>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Nome:</label></div>
                                    <asp:TextBox ID="txtNome" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Sexo:</label></div>
                                    <asp:RadioButtonList ID="radionBtnSexo" runat="server" RepeatDirection="Horizontal"
                                        BorderWidth="0" RepeatLayout="Flow" CssClass="RadioSpan">
                                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                                        <asp:ListItem Value="I">Indefinido</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Data de Nascimento:</label></div>
                                    <div class="Left">
                                        <asp:TextBox ID="txtDataNascimento" runat="server" CssClass="CamposMd Pequeno2"></asp:TextBox>
                                        <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDataNascimento"
                                            TodaysDateFormat="d MMMM , yyyy">
                                        </cc1:CalendarExtender>
                                    </div>
                                    <%--                            <div class="Left">
                                <a href="javascript:void(0)" onclick="if(self.gfPop)gfPop.fPopCalendar(document.getElementById(<%="'" & txtDataNascimento.ClientID & "'" %>));return false;"
                                                            hidefocus class="BtnMedio Pequeno26"></a>
                            </div>--%>
                                    <label>
                                        Idade:</label>
                                    <asp:TextBox ID="txtIdade" runat="server" CssClass="CamposMd Pequeno"></asp:TextBox>
                                    <label>
                                        Signo:</label>
                                    <asp:TextBox ID="lblSigno" runat="server" CssClass="CamposMd Pequeno2"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Nome da Mãe:</label></div>
                                    <asp:TextBox ID="txtNomeMae" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                    <asp:ImageButton ID="imgBtnCarregaDadosMae" runat="server" OnClientClick="abrirModalAguarde();"
                                        ImageUrl="~/img/IconBuscarGeral.png" />
                                </div>
                            </div>
                        </asp:Panel>
                    </div>
                    <div id="DIV_INFORMACOES_CNPJ">
                        <asp:Panel ID="pnlInformacoesCnpj" runat="server">
                            <h5>
                                Dados Cadastrais</h5>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            CNPJ:</label></div>
                                    <asp:TextBox ID="txtCnpj" runat="server" CssClass="CamposMd Pequeno4"></asp:TextBox>
                                    <label>
                                        Situação:</label>
                                    <asp:TextBox ID="txtSituacao" runat="server" CssClass="CamposMd Pequeno5"></asp:TextBox>
                                    <label>
                                        Atualização:</label>
                                    <asp:TextBox ID="txtDtSitCadPJ" runat="server" CssClass="CamposMd Pequeno3"></asp:TextBox>
                                </div>
                                <div class="Right">
                                    <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" CssClass="BtnMedio Pequeno2"
                                        NavigateUrl="http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/cnpjreva_solicitacao.asp"
                                        Text="Situação Cadastral"> </asp:HyperLink>
                                </div>
                                <div class="dados_cnpj5" style="display: none;">
                                    Porte</div>
                                <div class="dados_cnpj6" style="display: none;">
                                    <asp:TextBox runat="server" ID="txtPorte" BorderWidth="0" CssClass="imput" Width="41px"
                                        Height="15px" Font-Size="13px"></asp:TextBox></div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Razão Social:</label></div>
                                    <asp:TextBox ID="txtRazao" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Nome Fantasia:</label></div>
                                    <asp:TextBox ID="txtNomeFantasia" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            CNAE:</label></div>
                                    <asp:TextBox ID="txtCnae" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Natureza Jurídica:</label></div>
                                    <asp:TextBox ID="txtNaturezaJuridica" runat="server" CssClass="CamposMd Grande460"></asp:TextBox>
                                </div>
                            </div>
                            <div class="LinhaForm">
                                <div class="Left">
                                    <div class="Txt">
                                        <label>
                                            Data de Abertura:</label></div>
                                    <asp:TextBox ID="txtDataAbertura" runat="server" CssClass="CamposMd Pequeno150"></asp:TextBox>
                                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDataAbertura"
                                        TodaysDateFormat="d MMMM , yyyy">
                                    </cc1:CalendarExtender>
                                </div>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </asp:Panel>
            <div class="Clear">
            </div>
            <h5 class="Junto">
                Telefones</h5>
            <asp:DataGrid ID="dgTelefone" runat="server" AutoGenerateColumns="False" CellPadding="4"
                GridLines="Horizontal" Width="100%" CssClass="Resultado" HeaderStyle-Height="0"
                ShowHeader="false">
                <PagerStyle HorizontalAlign="Right" />
                <Columns>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div class="Estrelas">
                                <asp:Image ID="imgRanking" runat="server" />
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle Width="96px"></ItemStyle>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div>
                                <div class="Validacao">
                                    <asp:RadioButtonList ID="radioBtnStatusTel" runat="server" RepeatDirection="Horizontal"
                                        Width="180px">
                                        <asp:ListItem Value="0"><font color="green">Válido</font></asp:ListItem>
                                        <asp:ListItem Value="2"><font color="red">Inválido</font></asp:ListItem>
                                        <asp:ListItem Value="1"><font color="black">Outros</font></asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <%--                    <div class="Left">
                        <asp:ImageButton ID="imgBtnLimparSelecao" runat="server" CommandName="LimparSelecao"
                            ImageUrl="~/img/ic_limpar.png" ToolTip="Limpar status" />
                    </div>--%>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="TELEFONE">
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="340px" VerticalAlign="Middle" />
                    </asp:BoundColumn>
                    <asp:TemplateColumn ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Button ID="imgBtnCarregaTel" runat="server" CommandName="CARREGARINFORMACOES"
                                CssClass="BtnMedio BtnBuscar" ToolTip="Buscar Pessoas com esse mesmo Telefone" />
                            <%--               <asp:ImageButton ID="imgBtnCarregaTel" runat="server" ImageUrl="~/img/bt_sourceCEP.jpg"
                    ToolTip="Buscar Informações" CommandName="CARREGARINFORMACOES" />--%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="50px" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <div class="Clear">
            </div>
            <div class="NovoItem">
                <div class="Left">
                    <div class="Left">
                        <asp:Button ID="btnAtualizaStatusTel" runat="server" Text="Atualizar Status" CssClass="BtnMedio AtualizarStatus"
                            OnClientClick="abrirModalAguarde();" />
                    </div>
                    <div class="Left">
                        <label>
                            Novo telefone:</label>
                        <asp:TextBox ID="txtDDDNovo" runat="server" MaxLength="2" CssClass="CamposMd Pequeno40"></asp:TextBox>
                        <cc1:FilteredTextBoxExtender ID="FilteredTxtDDDNovo" runat="server" FilterType="Numbers" TargetControlID="txtDDDNovo"></cc1:FilteredTextBoxExtender>
                        <asp:TextBox ID="txtTelNovo" runat="server" MaxLength="9" CssClass="CamposMd Pequeno150"></asp:TextBox>
                        <cc1:FilteredTextBoxExtender ID="FilteredTxtTelNovo" runat="server" FilterType="Numbers" TargetControlID="txtTelNovo"></cc1:FilteredTextBoxExtender>
                    </div>
                </div>
                <div class="Right">
                    <asp:LinkButton ID="lnkBtnSalvarNovoTel" runat="server" CssClass="BtnMedio BtnNovoItem"
                        ToolTip="Adicionar novo telefone na lista" OnClientClick="abrirModalAguarde();"></asp:LinkButton>
                </div>
            </div>
            <h5 class="Junto">
                Endereços</h5>
            <asp:DataGrid ID="dgEndereco" runat="server" AutoGenerateColumns="False" CellPadding="4"
                GridLines="Horizontal" Width="100%" CssClass="Resultado" HeaderStyle-Height="0"
                ShowHeader="false">
                <PagerStyle HorizontalAlign="Right" />
                <Columns>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div class="Estrelas">
                                <asp:Image ID="imgRanking" runat="server" />
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle Width="96px"></ItemStyle>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn Visible="true">
                        <ItemTemplate>
                            <div>
                                <div class="Validacao">
                                    <asp:RadioButtonList ID="radioBtnStatusEndereco" runat="server" RepeatDirection="Horizontal"
                                        Width="180px">
                                        <asp:ListItem Value="0"><font color="green">Válido</font></asp:ListItem>
                                        <asp:ListItem Value="2"><font color="red">Inválido</font></asp:ListItem>
                                        <asp:ListItem Value="1"><font color="black">Outros</font></asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="LOGRADOURO">
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="340px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="NUMERO" HeaderText="Nº" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="COMPLEMENTO" HeaderText="Complemento" Visible="False">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="CEP" HeaderText="Cep" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="CIDADE" HeaderText="Cidade" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="BAIRRO" HeaderText="Bairro" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Uf" HeaderText="UF" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="H_END_ID" HeaderText="H_END_ID" Visible="false"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ORIGEM" HeaderText="ORIGEM" Visible="false"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ENDERECO" HeaderText="ENDERECO" Visible="false"></asp:BoundColumn>
                    <asp:TemplateColumn Visible="true">
                        <ItemTemplate>
                            <asp:Button ID="imgBtnCarregaEnd" runat="server" CommandName="CARREGARINFORMACOES"
                                CssClass="BtnMedio BtnBuscar" ToolTip="Buscar Pessoas com esse mesmo Endereço" />
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="50px" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <div class="NovoItem">
                <div class="Left">
                    <div class="Left">
                        <asp:Button ID="imgBtnAtualizaEndereco" runat="server" Text="Atualizar Status" OnClientClick="abrirModalAguarde();"
                            CssClass="BtnMedio AtualizarStatus" />
                        <%--<asp:ImageButton ID="imgBtnImprimir" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png" />--%>
                    </div>
                    <div class="Left">
                        <label>
                            Novo endereço:</label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="CamposMd Grande380"></asp:TextBox>
                    </div>
                </div>
                <div class="Right">
                    <asp:LinkButton ID="lnkBtnNovoEndereco" runat="server" CssClass="BtnMedio BtnNovoItem"
                        OnClientClick="abrirModalAguarde();" ToolTip="Adicionar novo endereço na lista"></asp:LinkButton>
                    <asp:Panel ID="pnlTratarDados" runat="server" Style="display: none;" Height="230"
                        ScrollBars="none" CssClass="ModalLayout">
                        <img src="img/close.png" style="cursor: pointer; float: right" alt="" onclick="fecharModalNovoEnd();" />
                        <h1>
                            <strong>Novo Endereço</strong></h1>
                        <!--Final Novo Endereco-->
                        <div>
                            <div class="BuscaCEP">
                                CEP:
                                <asp:TextBox ID="txtCEPT" runat="server" CssClass="CamposMd"></asp:TextBox>
                                <asp:ImageButton ID="imgBtnTratar" runat="server" ImageUrl="~/img/IconBuscarGeral.png"
                                    CssClass="BtBuscaCEP" />
                            </div>
                            <div class="LinhaForm">
                                Endereço:
                                <asp:TextBox ID="txtEnderecoT" runat="server" Width="450px" CssClass="CamposMd"></asp:TextBox>
                                Número:
                                <asp:TextBox ID="txtNumeroT" runat="server" Width="50px" CssClass="CamposMd"></asp:TextBox>
                            </div>
                            <div class="LinhaForm">
                                Complemento:
                                <asp:TextBox ID="txtComplT" runat="server" Width="210px" CssClass="CamposMd"></asp:TextBox>
                                Bairro:
                                <asp:TextBox ID="txtBairroT" runat="server" CssClass="CamposMd" Width="277px"></asp:TextBox>
                            </div>
                            <div class="LinhaForm">
                                Cidade:
                                <asp:TextBox ID="txtCidadeT" runat="server" Width="230px" CssClass="CamposMd"></asp:TextBox>
                                UF:
                                <asp:TextBox ID="txtEstadoT" runat="server" Width="50px" CssClass="CamposMd"></asp:TextBox>
                            </div>
                            <div class="botoesnvendereco">
                                <asp:ImageButton ID="imgBtnLimpar" runat="server" ImageUrl="~/img/Bt_ImgLimpar.png" />
                                <asp:ImageButton ID="imgBtnSalvarEnd" runat="server" ImageUrl="~/img/Bt_ImgSalvar.png"
                                    CssClass="BtSalvar" />
                            </div>
                            <!--Final Div Botoesnvendereco-->
                        </div>
                        <!--Final Div Tabela novo endereco-->
                    </asp:Panel>
                    <cc1:ModalPopupExtender ID="mpeTratarDados" runat="server" TargetControlID="btnTrat"
                        PopupControlID="pnlTratarDados" BackgroundCssClass="modalBackground" OkControlID="btnTrat"
                        CancelControlID="btnTrat" />
                    <asp:Button ID="btnTrat" runat="server" Text="Button" Style="display: none" />
                </div>
            </div>
            <h5 class="Junto">
                Emails</h5>
            <asp:DataGrid ID="dgEmail" runat="server" AutoGenerateColumns="False" CellPadding="4"
                GridLines="Horizontal" Width="100%" CssClass="Resultado" HeaderStyle-Height="0"
                ShowHeader="false">
                <PagerStyle HorizontalAlign="Right" />
                <Columns>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div class="Estrelas">
                                <asp:Image ID="imgRanking" runat="server" />
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle Width="96px"></ItemStyle>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div>
                                <div class="Validacao">
                                    <asp:RadioButtonList ID="radioBtnStatusEmail" runat="server" RepeatDirection="Horizontal"
                                        Width="180px">
                                        <asp:ListItem Value="0"><font color="green">Válido</font></asp:ListItem>
                                        <asp:ListItem Value="2"><font color="red">Inválido</font></asp:ListItem>
                                        <asp:ListItem Value="1"><font color="black">Outros</font></asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="EMAIL">
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="340px" />
                    </asp:BoundColumn>
                    <asp:TemplateColumn ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Button ID="imgBtnCarregaEmail" runat="server" CssClass="BtnMedio BtnBuscar" />
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="50px" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <div class="NovoItem">
                <div class="Left">
                    <div class="Left">
                        <asp:Button ID="imgBtnAtualizarEmail" runat="server" Text="Atualizar Status" CssClass="BtnMedio AtualizarStatus"
                            OnClientClick="abrirModalAguarde();" />
                    </div>
                    <div class="Left">
                        <label>
                            Novo email:</label>
                        <asp:TextBox ID="txtNovoEmail" runat="server" CssClass="CamposMd Grande380"></asp:TextBox>
                    </div>
                </div>
                <div class="Right">
                    <asp:LinkButton ID="lnkBtnSalvarNovoEmail" runat="server" CssClass="BtnMedio BtnNovoItem"
                        ToolTip="Adicionar novo telefone na lista" OnClientClick="abrirModalAguarde();"></asp:LinkButton>
                </div>
            </div>
            <h5 class="Junto">
                <asp:Label ID="lblParticipacaoEmpresarial" runat="server" Text="Label"></asp:Label></h5>
            <asp:DataGrid ID="dgParticipacaoEmpresarial" runat="server" AutoGenerateColumns="False"
                CellPadding="4" GridLines="Horizontal" Width="100%" ShowHeader="True" CssClass="Resultado">
                <FooterStyle />
                <SelectedItemStyle />
                <PagerStyle />
                <Columns>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div class="Estrelas">
                                <asp:Image ID="imgRanking" runat="server" ImageUrl="~/img/ic_stars_00.png" />
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle Width="96px"></ItemStyle>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <div>
                                <div class="Validacao">
                                    <asp:RadioButtonList ID="radioBtnStatus" runat="server" RepeatDirection="Horizontal"
                                        Width="180px">
                                        <asp:ListItem Value="0"><font color="green">Válido</font></asp:ListItem>
                                        <asp:ListItem Value="2"><font color="red">Inválido</font></asp:ListItem>
                                        <asp:ListItem Value="1"><font color="black">Outros</font></asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" Height="0px" />
                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Nome">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkBtnRazao" runat="server" CommandName="ExibirDadosParticipacaoEmpresarial"
                                Text='<%#Eval("NOME") %>'></asp:LinkButton></ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_UNIT" HeaderText="ID_UNIT" Visible="false">
                        <HeaderStyle />
                        <ItemStyle />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DOCUMENTO" HeaderText="DOCUMENTO" Visible="false">
                        <HeaderStyle />
                        <ItemStyle />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="PCT_PARTICIPACAO" HeaderText="%">
                        <HeaderStyle />
                        <ItemStyle Width="53px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DATA_ENTRADA" HeaderText="Desde">
                        <HeaderStyle />
                        <ItemStyle />
                    </asp:BoundColumn>
                    <asp:TemplateColumn ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Button ID="imgBtnCarregaDados" runat="server" CommandName="EXIBIRDADOSPARTICIPACAOEMPRESARIAL"
                                CssClass="BtnMedio BtnBuscar" />
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="50px" />
                    </asp:TemplateColumn>
                </Columns>
                <HeaderStyle CssClass="Header" />
            </asp:DataGrid>
            <div class="NovoItem">
                <div class="Left">
                    <div class="Left">
                        <asp:Button ID="btnAtualizarStatusParticipacaoEmpresarialSocios" runat="server" Text="Atualizar Status"
                            CssClass="BtnMedio AtualizarStatus" OnClientClick="abrirModalAguarde();" />
                    </div>
                    <div class="Left">
                        <label>
                            <asp:Label ID="lblDocumentoPeSo" runat="server"></asp:Label></label>
                        <asp:TextBox ID="txtDocumentoPeSo" runat="server" CssClass="CamposMd Grande380" Width="120px"
                            MaxLength="14"></asp:TextBox>
                        <label>
                            Pct.:
                            <asp:TextBox ID="txtPctPeSo" runat="server" CssClass="CamposMd Grande380" Width="50px"></asp:TextBox></label>
                        <label>
                            Desde:
                            <asp:TextBox ID="txtDataDesdePeSo" runat="server" CssClass="CamposMd Grande380" Width="80px"></asp:TextBox></label>
                        <cc1:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDataDesdePeSo"
                            TodaysDateFormat="d MMMM , yyyy">
                        </cc1:CalendarExtender>
                    </div>
                </div>
                <div class="Right">
                    <asp:LinkButton ID="lnkBtnNovoStatusParticipacaoEmpresarialSocios" runat="server"
                        CssClass="BtnMedio BtnNovoItem" ToolTip="Adicionar novo telefone na lista" OnClientClick="abrirModalAguarde();"></asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    </div>
    <!--fim logotipo intouch e pesquisa cpf/cnpj-->
    <!--Inicio dados extra, pesquisas recentes, resultados da busca-->
    <table id="tabela2">
        <tr>
            <td>
                <div class="usuarioExitente" style="display: none;">
                    <div class="usuarioExistenteTxt">
                        <img src="img/icone-usuario-existente.png" align="left" />
                        <asp:Label ID="lblQtdLogadoMesmoLogin" runat="server" Font-Names="Arial">Blablabla</asp:Label></div>
                    <div class="usuarioExistenteInterna">
                        <div class="usuarioExistenteReportar">
                            <asp:DataGrid ID="dgIpsLoginDia" runat="server" AutoGenerateColumns="False" Font-Names="Arial"
                                Font-Size="10px" Width="150px" ShowHeader="False">
                                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Arial" Font-Overline="False"
                                    Font-Strikeout="False" Font-Underline="False" />
                                <Columns>
                                    <asp:BoundColumn DataField="IP">
                                        <HeaderStyle Width="200px" />
                                    </asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="DenunciarIp" Text="<u>Denunciar</u>">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" ForeColor="Red" />
                                    </asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                </div>
                <!--final da div usuarioEsitenteNumero-->
            </td>
        </tr>
    </table>
    <!--Fim dados extra, pesquisas recentes, resultados da busca-->
    <asp:Panel ID="pnlResultadoMenuEsquerda" runat="server" Style="display: none;" CssClass="ModalLayout">
        <img src="img/close.png" style="cursor: pointer;" alt="" onclick="fecharModalResultadoMenuEsquerda();"
            class="Right" />
        <ul class="Botoes">
            <div id="divEditarPopup" runat="server">
                <div class="ic_funcao1">
                    <li class="SalvarCancelar">
                        <asp:ImageButton ID="imgBtnAtualizarPopup" runat="server" ImageUrl="~/img/ic_inserir_novo.png"
                            ToolTip="Atualizar" OnClientClick="abrirModalAguarde();" /></div>
                <div class="ic_funcao3">
                    <asp:ImageButton ID="imgBtnCancelarPopup" runat="server" ImageUrl="~/img/ic_cancelar.png"
                        ToolTip="Cancelar" /></div>
            </div>
            </li>
            <li>
                <asp:ImageButton ID="imgBtnEditarPopup" runat="server" ImageUrl="~/img/ic_editar_white.png"
                    ToolTip="Editar" CssClass="Edit" /></li>
            <li><a href="imprimir.aspx?showdialog=s&janelapopup=s" class="Bt Salvar" title="Salvar"
                target="_blank">Salvar</a></li>
            <li><a href="imprimir.aspx?showdialog=n&janelapopup=s" target="_blank" class="Bt Imprimir"
                title="Imprimir" target="_blank">Imprimir</a></li>
        </ul>
        <table>
            <tr>
                <td align="left">
                    <asp:Label ID="lblItemMenuEsquerda" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div class="boxInformacoes" style="overflow: auto; height: 300px; cursor: move; margin-top: 10px;">
            <asp:DataGrid ID="dgDadosExtra" runat="server" AutoGenerateColumns="False" GridLines="None"
                CellPadding="4">
                <FooterStyle />
                <EditItemStyle />
                <SelectedItemStyle />
                <PagerStyle />
                <AlternatingItemStyle CssClass="Listra" />
                <ItemStyle />
                <Columns>
                    <asp:TemplateColumn HeaderText="">
                        <ItemTemplate>
                            <div class="Coluna3">
                                <asp:Label ID="lblParentesco" runat="server" Text='<%# Eval("PARENTESCO") %>'></asp:Label>
                            </div>
                            <div class="Coluna4">
                                <asp:LinkButton ID="lnkBtnDadosExtra" runat="server" CommandName="ExibirDadosExtra"
                                    Text='<%# Eval("NOME") %>' ToolTip='<%#Eval("NOME").ToString().ToUpper() %>'></asp:LinkButton>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle CssClass="Header" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_UNIT" HeaderText="ID_UNIT" Visible="False">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DOCUMENTO" HeaderText="DOCUMENTO" Visible="False">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="IDADE" HeaderText="IDADE" Visible="False">
                        <HeaderStyle Width="0px" />
                    </asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="Header" />
            </asp:DataGrid>
            <asp:DataGrid ID="dgVizinhos" runat="server" CellPadding="4" AutoGenerateColumns="False"
                ForeColor="#333333" GridLines="None" PageSize="15">
                <FooterStyle />
                <EditItemStyle />
                <SelectedItemStyle />
                <PagerStyle NextPageText="Proximo" PrevPageText="Anterior" />
                <AlternatingItemStyle CssClass="Listra" />
                <ItemStyle />
                <Columns>
                    <asp:TemplateColumn HeaderText="Nome">
                        <ItemTemplate>
                            <div>
                                <asp:LinkButton ID="lnkBtnNome" runat="server" Text='<%#Eval("NOME") %>' CommandName="EXIBIRCONSULTA"></asp:LinkButton>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="DOCUMENTO" HeaderText="Documento" SortExpression="DOCUMENTO"
                        Visible="false"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ENDERECO" HeaderText="Endereço" SortExpression="ENDERECO"
                        Visible="True"></asp:BoundColumn>
                    <asp:BoundColumn DataField="BAIRRO" HeaderText="Bairro" SortExpression="BAIRRO" Visible="true">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="CIDADE" HeaderText="Cidade" SortExpression="CIDADE" Visible="true">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ESTADO" HeaderText="UF" SortExpression="ESTADO" Visible="true">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ID_UNIT" HeaderText="ID_UNIT" Visible="False" SortExpression="ID_UNIT">
                    </asp:BoundColumn>
                </Columns>
                <HeaderStyle CssClass="Header" />
            </asp:DataGrid>
            <asp:DataGrid ID="dgDadosComerciais" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" Width="100%" Font-Names="Arial" Font-Size="10px">
                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" Height="39" />
                <EditItemStyle BackColor="#2461BF" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <AlternatingItemStyle BackColor="White" />
                <ItemStyle BackColor="#EFF3FB" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Left" />
                <Columns>
                    <asp:TemplateColumn HeaderText="Nome" ItemStyle-Width="300px">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkBtnDadosComerciais" runat="server" CommandName="ExibirDadosComerciais"
                                Text='<%#Eval("Nome") %>' Font-Names="Arial" Font-Underline="true" Font-Size="10px"
                                ForeColor="Blue" Width="600px"></asp:LinkButton></ItemTemplate>
                        <ItemStyle Width="400px" />
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="ID_UNIT" HeaderText="ID_UNIT" Visible="False"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DOCUMENTO" HeaderText="CPF/CNPJ" Visible="True"></asp:BoundColumn>
                </Columns>
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Font-Size="11px"
                    HorizontalAlign="Left" />
            </asp:DataGrid>
            <asp:DataGrid ID="dgDadosDireto" runat="server" GridLines="None" CellPadding="4">
                <FooterStyle />
                <EditItemStyle />
                <SelectedItemStyle />
                <PagerStyle />
                <AlternatingItemStyle CssClass="Listra" />
                <ItemStyle />
                <HeaderStyle CssClass="Header" />
            </asp:DataGrid>
        </div>
    </asp:Panel>
    <cc1:ModalPopupExtender ID="mpeResultadoMenuEsquerda" runat="server" TargetControlID="Button1"
        PopupControlID="pnlResultadoMenuEsquerda" BackgroundCssClass="modalBackground"
        OkControlID="Button1" CancelControlID="Button1" />
    <!--Inicio mensagem de alerta-->
    <asp:Panel ID="pnlMsg" runat="server" CssClass="modalMsg" onclick="fecharModalMsg();"
        ToolTip="Clique para fechar" Style="display: none; height:auto; width:auto;">
        <div align="right" style="background-color: #324658; padding: 5px;">
            <img src="img/close.png" style="cursor: pointer;" alt="" onclick="fecharModalMsg();" />
        </div>
       <center>
            <asp:Label ID="lblMsgValidacao" runat="server" onclick="fecharModalMsg();" Font-Names="Arial"
                Font-Size="15px" ToolTip="Clique para fechar"></asp:Label>
       </center>
    </asp:Panel>
    <cc1:ModalPopupExtender ID="mpeMsg" runat="server" TargetControlID="Button1" PopupControlID="pnlMsg"
        BackgroundCssClass="modalBackground" OkControlID="Button1" CancelControlID="Button1" />
    <asp:Button ID="Button1" runat="server" Text="Button" Style="display: none" />
    <!--Fim mensagem de alerta-->
    <!--Inicio Modal Data Prev-->
    <asp:Panel ID="pnlDataPrev" runat="server" Style="display: none;" CssClass="ModalLayout">
        <img src="img/close.png" style="cursor: pointer;" alt="" onclick="fecharModalDataPrev();"
            class="Right" />
        <ul class="Botoes">
            <li class="SalvarCancelar">
                <div id="div2" runat="server">
                    <div class="ic_funcao1">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/ic_inserir_novo.png"
                            ToolTip="Atualizar" OnClientClick="abrirModalAguarde();" Style="display: none;" /></div>
                    <div class="ic_funcao3">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/ic_cancelar.png"
                            ToolTip="Cancelar" Style="display: none;" /></div>
                </div>
            </li>
            <li>
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/ic_editar_white.png"
                    ToolTip="Editar" CssClass="Edit" Style="display: none;" /></li>
            <li><a href="imprimir.aspx?showdialog=s&janelapopup=s" class="Bt Salvar" title="Salvar"
                target="_blank" style="display: none;">Salvar</a></li>
            <li><a href="imprimir.aspx?showdialog=n&janelapopup=s" target="_blank" class="Bt Imprimir"
                title="Imprimir" target="_blank" style="display: none;">Imprimir</a></li>
        </ul>
        <table>
            <tr>
                <td align="left">
                    <asp:Label ID="lblInformacaoCabecalho" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div class="boxInformacoes" style="overflow: auto; height: 313px; cursor: move; margin-top: 24px;
            width: 661px;">
            <cc1:TabContainer ID="tabContainerDataPrev" runat="server" AutoPostBack="false">
                <cc1:TabPanel ID="tabPanelDataGuia1" runat="server">
                    <HeaderTemplate>
                        Dados do Beneficiário
                    </HeaderTemplate>
                    <ContentTemplate>
                        <asp:DataGrid ID="dgDataPrevGuia1" runat="server" AutoGenerateColumns="False" Width="100%">
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <table>
                                            <tr>
                                                <td>
                                                    Data de Nascimento:
                                                    <%#String.Format("{0:dd/MM/yyyy}", Eval("Nascimento"))%>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    OML:
                                                    <%#Eval("OML")%>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    Estado (OML):
                                                    <%#Eval("EstadoOML")%>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    Mês/Ano Competência:
                                                    <%#Eval("Competencia")%>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                        <table class="style1" width="100%">
                                            <tr>
                                                <td class="style2" align="left">
                                                    Beneficio:
                                                    <asp:Label ID="lblDataPrevBeneficio" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("Beneficio") %>'></asp:Label>
                                                </td>
                                                <td align="left">
                                                    &nbsp;
                                                </td>
                                                <td align="left">
                                                    Consultado em:
                                                    <asp:Label ID="lblDataPrevDataConsulta" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# String.Format("{0:dd/MM/yyyy HH:MM:ss}", Eval("Inclusao")) %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style2" align="left">
                                                    Tipo:
                                                    <asp:Label ID="lblDataPrevTipoEspecie" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("Tipo") %>'></asp:Label>
                                                </td>
                                                <td align="left">
                                                    &nbsp;
                                                </td>
                                                <td class="style2" align="left">
                                                    Espécie:
                                                    <asp:Label ID="lblDataPrevEspecie" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("Descricao") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Situação:
                                                    <asp:Label ID="lblDataPrevSituacao" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("Situacao") %>'></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                        <u>Dados Bancários</u>
                                        <br />
                                        <br />
                                        <table>
                                            <tr>
                                                <td>
                                                    Meio de Pagamento: <asp:Label ID="Label1" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("MeioPagamento") %>'></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                Nome do Banco: <asp:Label ID="Label2" ForeColor="Black" Font-Bold="true" runat="server"
                                                        Text=' <%# Eval("nomebanco") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <%--<tr>
                                                <td>
                                                    Código do Banco: <b>
                                                        <%#Eval("codigobanco")%></b>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    Nome do Banco: <b>
                                                        <%#Eval("nomebanco")%></b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Código da Agencia: <b>
                                                        <%#Eval("codigoagencia")%></b>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    Agencia: <b>
                                                        <%#Eval("agencia")%></b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Conta Corrente: <b>
                                                        <%#Eval("ContaCorrente")%></b>
                                                </td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    Endereço: <b>
                                                        <%#Eval("endereco")%></b>
                                                </td>
                                            </tr>--%>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                        <hr />
                        <div align="left" class="boxInss">
                            <u>Resumo</u>
                            <br />
                            <br />
                            <asp:DataGrid ID="dgDataPrevGuia1Resumo" runat="server" AutoGenerateColumns="False"
                                Width="60%">
                                <Columns>
                                    <asp:BoundColumn DataField="ValorCreditos" HeaderText="Créditos" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ValorDebitos" HeaderText="Débitos" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ValorConsignado" HeaderText="Consignado" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ValorMargem" HeaderText="Margem" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="tabPanelDataGuia2" runat="server">
                    <HeaderTemplate>
                        Consignações
                    </HeaderTemplate>
                    <ContentTemplate>
                        <div align="left" class="boxInss">
                            <u>Créditos</u>
                            <br />
                            <br />
                            <asp:DataGrid ID="dgDataPrevGuia2Credito" runat="server" AutoGenerateColumns="False"
                                Width="60%">
                                <Columns>
                                    <asp:BoundColumn DataField="Tipo" HeaderText="Tipo"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Valor" HeaderText="Valor" DataFormatString="{0:c}"></asp:BoundColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                        <br />
                        <br />
                        <div align="left" class="boxInss">
                            <u>Débitos</u>
                            <br />
                            <br />
                            <asp:DataGrid ID="dgDataPrevGuia2Debito" runat="server" AutoGenerateColumns="False"
                                Width="100%">
                                <Columns>
                                    <asp:BoundColumn DataField="Tipo" HeaderText="Tipo"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Nome" HeaderText="Banco"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Valor" HeaderText="Parcela" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="ValorContrato" HeaderText="Contrato" DataFormatString="{0:c}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Prazo" HeaderText="Prazo"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Iniciocontrato" HeaderText="Inicio" DataFormatString="{0:dd/MM/yyyy}">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="FimContrato" HeaderText="Fim" DataFormatString="{0:dd/MM/yyyy}">
                                    </asp:BoundColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </ContentTemplate>
                </cc1:TabPanel>
            </cc1:TabContainer>
        </div>
    </asp:Panel>
    <asp:Button ID="btndataprev" runat="server" Style="display: none;" />
    <cc1:ModalPopupExtender ID="mpeDataPrev" runat="server" TargetControlID="btndataprev"
        PopupControlID="pnlDataPrev" BackgroundCssClass="modalBackground" OkControlID="btndataprev"
        CancelControlID="btndataprev" />
    <!--Fim Modal Data Prev-->
    <!--Inicio SPC-->
    <asp:Panel ID="pnlSPC" runat="server" Style="left: 35%; width: 1200px; border: solid 0px black;
        background-color: #e5eaf6; display: none;" ScrollBars="Auto">
        <div align="right" style="background-color: #e5eaf6;">
            <img src="img/close.png" style="cursor: pointer;" alt="" onclick="fecharModalSPC()" /></div>
        <asp:Panel ID="pnlSpcCpf" runat="server">
            <table border="0px" cellpadding="1" cellspacing="0" align="center" style="">
                <tr>
                    <td style="width: 150px" align="right">
                        <asp:Label ID="lblCpfSPC" runat="server" Text="CPF" />
                        :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="dataCPFSPC" runat="server" ReadOnly="true" Width="100%" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 150px" align="right">
                        <asp:Label ID="lblNomeSPC" runat="server" Text="Nome" />
                        :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="dataNomeSPC" runat="server" ReadOnly="true" Width="100%" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 150px" align="right">
                        <asp:Label ID="lblDscSituacaoSPC" runat="server" Text="Status Situação" />
                        :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="dataDscSituacaoSPC" runat="server" ReadOnly="true" Width="100%" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 150px">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
            <cc1:TabContainer ID="tabContainerSpcPf" runat="server" ActiveTabIndex="3">
                <cc1:TabPanel ID="tabPanel1" runat="server">
                    <HeaderTemplate>
                        Resumo das Ocorrências
                        <asp:ImageButton ID="imgBtnPrintTab1" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png"
                            Width="15px" Height="15px" /></HeaderTemplate>
                    <ContentTemplate>
                        <asp:Panel ID="pnlResumoOcorrencia" runat="server" Height="380px" ScrollBars="Vertical">
                            <table class="style1" align="left" style="border: solid 1px black;">
                                <tr>
                                    <td class="style2" align="center">
                                        <b>Ocorrência</b>
                                    </td>
                                    <td class="style2" align="center">
                                        <b>Quantidade</b>
                                    </td>
                                    <td class="style2" align="center">
                                        <b>Última Ocorrência</b>
                                    </td>
                                    <td class="style2" align="center">
                                        <b>Valor</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Confirmação dados telefônicos:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConfDadosTelQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConfDadosTelUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConfDadosTelValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Registro de SPC:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegSpcQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegSpcUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegSpcValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Informações do poder judiciário:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblInfoPoderJudiciarioQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblInfoPoderJudiciarioUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblInfoPoderJudiciarioValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Cheque Sem Fundo - CCF:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequeSemFundoCCFQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequeSemFundoCCFUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequeSemFundoCCFValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Registro de Cheque lojista:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegistroChequeLogistaQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegistroChequeLogistaUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblRegistroChequeLogistaValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Acúmulo de Cheques Sustados pelo Motivo 21:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequesSustadosMotivo21Qtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequesSustadosMotivo21UltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblChequesSustadosMotivo21Valor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Consulta realizada:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConsultaRealizadaQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConsultaRealizadaUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblConsultaRealizadaValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Alerta de documentos:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblAlertaDocumentosQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblAlertaDocumentosUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblAlertaDocumentosValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Crédito concedido:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblCreditoConcedidoQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblCreditoConcedidoUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblCreditoConcedidoValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Contra-ordem:
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblContraOrdemQtd" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblContraOrdemUltimaOcorrencia" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                    <td align="center">
                                        <asp:Label ID="lblContraOrdemValor" runat="server" Font-Names="Arial"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <b>Consultas Realizadas</b>
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4" align="left">
                                        <asp:DataGrid ID="dgConsultasRealizadas" runat="server" Width="100%" Font-Names="Arial"
                                            Font-Size="11px">
                                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                Font-Underline="False" />
                                        </asp:DataGrid>
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                    <td>
                                        &#160;&#160;
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="tabPanel2" runat="server">
                    <HeaderTemplate>
                        Registros de Inadimplência - SPC
                        <asp:ImageButton ID="imgBtnPrintTab2" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png"
                            Width="15px" Height="15px" /></HeaderTemplate>
                    <ContentTemplate>
                        <br />
                        <asp:Panel ID="pnlServicoInadimplenciaSPC" runat="server" Height="380px" ScrollBars="Vertical">
                            <asp:DataGrid ID="dgServicoInadimplenciaSPC" runat="server" Width="100%" Font-Names="Arial"
                                Font-Size="11px">
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" />
                            </asp:DataGrid></asp:Panel>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="tabPanel3" runat="server">
                    <HeaderTemplate>
                        Registros de Inadimplência - Cheque Logista
                        <asp:ImageButton ID="imgBtnPrintTab3" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png"
                            Width="15px" Height="15px" /></HeaderTemplate>
                    <ContentTemplate>
                        <br />
                        <asp:Panel ID="pnlServicoInadimplenciaChequeLogista" runat="server" Height="380px"
                            ScrollBars="Vertical">
                            <asp:DataGrid ID="dgServicoInadimplenciaChequeLogista" runat="server" Width="100%"
                                Font-Names="Arial" Font-Size="11px">
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" />
                            </asp:DataGrid></asp:Panel>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="tabPanel4" runat="server">
                    <HeaderTemplate>
                        CCF - Cadastro de Emitentes de Cheque sem Fundo
                        <asp:ImageButton ID="imgBtnPrintTab4" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png"
                            Width="15px" Height="15px" /></HeaderTemplate>
                    <ContentTemplate>
                        <br />
                        <asp:Panel ID="pnlCadastroEmitentesChequeSemFundo" runat="server" Height="380px"
                            ScrollBars="Vertical">
                            <asp:DataGrid ID="dgCadastroEmitentesChequeSemFundo" runat="server" Width="100%"
                                Font-Names="Arial" Font-Size="11px">
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" />
                            </asp:DataGrid></asp:Panel>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="tabPanel5" runat="server">
                    <HeaderTemplate>
                        Alerta de Documentos
                        <asp:ImageButton ID="imgBtnPrintTab5" runat="server" ToolTip="Imprimir" ImageUrl="~/img/print.png"
                            Width="15px" Height="15px" /></HeaderTemplate>
                    <ContentTemplate>
                        <br />
                        <asp:Panel ID="pnlAlertaDocumentos" runat="server" Height="380px" ScrollBars="Vertical">
                            <asp:DataGrid ID="dgAlertaDocumentos" runat="server" Width="100%" Font-Names="Arial"
                                Font-Size="11px">
                                <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                    Font-Underline="False" />
                            </asp:DataGrid></asp:Panel>
                    </ContentTemplate>
                </cc1:TabPanel>
            </cc1:TabContainer>
        </asp:Panel>
        <asp:Panel ID="pnlSpcCnpj" runat="server">
            <center>
                <table width="850px" border="1px" cellpadding="1" cellspacing="0" border="solid">
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblCnpjSPC" runat="server" Text="CNPJ" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataCnpjSPC" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblSituacaoSPCCNPJ" runat="server" Text="Situação" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataSituacaoSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblRazaoSPC" runat="server" Text="Razão Social" /></div>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="dataRazaoSpc" runat="server" ReadOnly="true" Width="90%" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblRazaoAnterior" runat="server" Text="Razão Social Anterior" /></div>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="dataRazaoAntSpc" runat="server" ReadOnly="true" Width="90%" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblEndSPCCNPJ" runat="server" Text="Endereço" /></div>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="dataEndSPCCNPJ" runat="server" ReadOnly="true" Width="90%" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblCitySPC" runat="server" Text="Cidade" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataCitySPC" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblUfSPCCNPJ" runat="server" Text="UF" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataUfSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblBairroSPCCNPJ" runat="server" Text="Bairro" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataBairroSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblCepSPCCNPJ" runat="server" Text="CEP" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataCEPCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblComplSPCCNPJ" runat="server" Text="Complemento" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataComplSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblNumSPCCNPJ" runat="server" Text="Nº" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataNumSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblInscrEstadualSPC" runat="server" Text="Inscrição Estadual" /></div>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="dataInscrEstadualSPC" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblDDDFaxSPCCNPJ" runat="server" Text="DDD-Fax" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataDDDFaxSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblFax" runat="server" Text="Fax" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataFaxSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblDDDSPCCNPJ" runat="server" Text="DDD" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataDDDSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblFoneSPCCNPJ" runat="server" Text="Telefone" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataFoneSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblNatJurSPCCNPJ" runat="server" Text="Cód. Nat. Jur." /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataNarJurSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblDscNatJurSPCCNPJ" runat="server" Text="Desc. Nat. Jur." /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataDscNarJurSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblNmComercial" runat="server" Text="Nome Comercial" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataNmComercial" runat="server" ReadOnly="true" />
                        </td>
                        <td>
                            <div class="dados_cpf1">
                                <asp:Label ID="lblVlCapitalSPCCNPJ" runat="server" Text="Vl. Capital" /></div>
                        </td>
                        <td>
                            <asp:TextBox ID="dataVlCapitalSPCCNPJ" runat="server" ReadOnly="true" />
                        </td>
                    </tr>
                </table>
            </center>
            <hr />
            <div class="dados_cpf1">
                <asp:Label ID="lblChqCNPJ" runat="server" Text="Cheque" Font-Bold="true" /></div>
            <div style="width: 1200px; overflow: scroll;">
                <asp:DataGrid ID="dgCnpjCheque" runat="server" AutoGenerateColumns="false" Font-Names="Tahoma"
                    Font-Size="11px">
                    <HeaderStyle BackColor="ActiveCaption" HorizontalAlign="Center" />
                    <ItemStyle Width="100%" />
                    <Columns>
                        <asp:BoundColumn DataField="CodAlinea" HeaderText="Cod. Alinea" ItemStyle-Width="90px">
                            <ItemStyle Width="90px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="DscAlinea" HeaderText="Desc. Alinea" ItemStyle-Width="130px">
                            <ItemStyle Width="130px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="Banco" HeaderText="Banco" ItemStyle-Width="50px">
                            <ItemStyle Width="50px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NumAgencia" HeaderText="Nº Agencia" ItemStyle-Width="90px">
                            <ItemStyle Width="90px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NumCC" HeaderText="Nº CC" ItemStyle-Width="100px">
                            <ItemStyle Width="100px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="DtEmissao" HeaderText="Dt. Emissão" ItemStyle-Width="100px">
                            <ItemStyle Width="100px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NumCheque" HeaderText="Nº Cheque" ItemStyle-Width="90px">
                            <ItemStyle Width="90px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="VlCheque" HeaderText="Vl. Cheque" ItemStyle-Width="90px">
                            <ItemStyle Width="90px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NmAssociado" HeaderText="Nome Associado" HeaderStyle-Width="250px"
                            ItemStyle-Width="250px">
                            <HeaderStyle Width="250px" />
                            <ItemStyle Width="250px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="NmEntidade" HeaderText="Nome Entidade" HeaderStyle-Width="250px"
                            ItemStyle-Width="250px">
                            <HeaderStyle Width="250px" />
                            <ItemStyle Width="250px" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="Origem" HeaderText="Origem" ItemStyle-Width="100px">
                            <ItemStyle Width="100px" />
                        </asp:BoundColumn>
                    </Columns>
                </asp:DataGrid>
        </asp:Panel>
        <hr />
        <div class="dados_cpf1">
            <asp:Label ID="lblCnaeinfor" runat="server" Text="Atividade da Empresa" Font-Bold="true" /></div>
        <%--<asp:DataGrid ID="dgCnaeSPCCNPJ" runat="server" AutoGenerateColumns="false" Font-Names="Tahoma"
            Font-Size="10px">
            <HeaderStyle BackColor="ActiveCaption" />
            <Columns>
                <as--%>
    </asp:Panel>
</asp:Content>