<%@ Page Language="cs" AutoEventWireup="false" MasterPageFile="~/Estrutura.Master"
    CodeBehind="Relatorios.aspx.cs" Inherits="Intouch.Relatorios" Culture="pt-BR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script language="javascript" type="text/javascript">
    function desabilitarCampos() {
    document.getElementById(<%="'" & ddlOpcoesUsuario.ClientID & "'" %>).disabled = 1;
    document.getElementById(<%="'" & ddlTipo.ClientID & "'" %>).disabled = 1;
    }
    function abrirModalAguarde()
    {
      $find("ctl00_ContentPlaceHolder1_mpeAguarde").show();
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ConteudoGeral">
        <h5>
            Relatórios</h5>
        <div class="Coluna1" style="float: left;">
            <cc1:ToolkitScriptManager ID="smRelClean" runat="server" />
            <div class="LinhaForm">
                <div class="Txt2">
                    <asp:Label ID="Label1" runat="server" Text="Data de Início"></asp:Label></div>
                <div class="Left">
                    <asp:TextBox ID="txtDataInicio" runat="server" CssClass="CamposMd Pequeno2"></asp:TextBox></div>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDataInicio"
                    Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy" PopupButtonID="Button2">
                </cc1:CalendarExtender>
                <div class="Right">
                    <asp:Button ID="Button2" runat="server" CssClass="BtnMedio Pequeno26-2" /></div>
            </div>
            <div class="LinhaForm">
                <div class="Txt2">
                    <asp:Label ID="Label2" runat="server" Text="Data do Fim"></asp:Label></div>
                <div class="Left">
                    <asp:TextBox ID="txtDataFim" runat="server" CssClass="CamposMd Pequeno2"></asp:TextBox></div>
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDataFim"
                    Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy" PopupButtonID="Button1">
                </cc1:CalendarExtender>
                <div class="Right">
                    <asp:Button ID="Button1" runat="server" CssClass="BtnMedio Pequeno26-2" /></div>
            </div>
            <div class="LinhaForm" id="itemGerarExcel" runat="server">
                Relatório em Excel
                <asp:CheckBox ID="chkBoxGerarExcel" runat="server" Checked="true" TextAlign="Left"
                    ToolTip="Ao processar o relatório geral, será processado também um relatório detalhado" />
            </div>
        </div>
        <div class="Coluna2">
            <div class="LinhaForm">
                <div class="Left">
                    <div class="Txt2">
                        <asp:Label ID="Label5" runat="server" Text="Cliente"></asp:Label></div>
                    <asp:DropDownList ID="ddlCliente" runat="server" AutoPostBack="True" CssClass="CamposMd Medio200">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="LinhaForm" id="itemUsuario" runat="server">
                <div class="Left">
                    <div class="Txt2">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuário"></asp:Label></div>
                    <asp:DropDownList ID="ddlUsuario" runat="server" AutoPostBack="false" CssClass="CamposMd Medio200">
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="Coluna3">
            <div class="LinhaForm">
                <div class="Left">
                    <div class="Txt3">
                        <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label></div>
                    <div class="Left">
                        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="CamposMd Medio200">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="LinhaForm">
                <div class="Left">
                    <div class="Txt3">
                        <asp:Label ID="lblOrdenar" runat="server" Text="Opções de Usuário"></asp:Label></div>
                    <div class="Left">
                        <asp:DropDownList ID="ddlOpcoesUsuario" runat="server" CssClass="CamposMd Medio200">
                            <asp:ListItem Value="1">Mostrar Usuarios Ativos</asp:ListItem>
                            <asp:ListItem Value="2">Mostrar Usuarios Inativos</asp:ListItem>
                            <asp:ListItem Value="0">Mostrar Usuarios (Ativos / Inativos)</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
        <div class="Clear Central">
            <asp:ImageButton ID="btnConsultar" runat="server" ImageUrl="~/img/BtnAgendarRelatorio.png"
                OnClientClick="abrirModalAguarde();" ToolTip="Agendar Relatório" />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/bt_limpar.jpg"
                Visible="false" Style="display: none;" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Name="tahoma" ForeColor="#666666"></asp:Label>
        </div>
        <div class="TotalConsultas">
            <asp:ImageButton ID="imgBtnExportaExcel" runat="server" ImageUrl="~/img/bt_exportarRelatorio.jpg"
                CssClass="Left" />
            <div class="Right">
                <p>
                    <asp:Label ID="lblQtdTotalConsultada" runat="server"></asp:Label></p>
                <p>
                    <asp:LinkButton ID="lnkBtnTotalCliente" runat="server" Text="» Total Geral de Pesquisas Feitas por Cliente"
                        Visible="false"></asp:LinkButton>
                </p>
            </div>
        </div>
        <div class="Clear Central">
        </div>
        <h5 class="Junto">
            Relatórios Agendados</h5>
        <asp:ImageButton ID="ImageButton2" Height="25px" runat="server" ImageUrl="~/img/relatorio.png"
            ToolTip="Clique para verificar se o relatório já está disponivel" Visible="false" />
        <asp:Panel ID="pnlAgendados" runat="server">
            <table class="style1">
                <tr>
                    <td>
                        <asp:DataGrid ID="dgRelatorioAgendado" runat="server" AutoGenerateColumns="False"
                            CellPadding="4" GridLines="Horizontal" AllowPaging="True" PageSize="5" CssClass="Table960 TableTxt10">
                            <FooterStyle />
                            <SelectedItemStyle />
                            <PagerStyle NextPageText="Próximo »" PrevPageText="« Anterior" CssClass="Footer" />
                            <AlternatingItemStyle CssClass="Listra" />
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgBtnRelatorio" runat="server" CommandName="VisualizarRelatorio" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn DataField="dt_Inicio" HeaderText="Data Inicial"></asp:BoundColumn>
                                <asp:BoundColumn DataField="dt_Fim" HeaderText="Data Final"></asp:BoundColumn>
                                <asp:BoundColumn DataField="nomeCliente" HeaderText="Cliente"></asp:BoundColumn>
                                <asp:BoundColumn DataField="nomeUsuario" HeaderText="Usuário"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Tipo" HeaderText="Tipo"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Opcoes_Usuario" HeaderText="Opções de Usuário"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Dt_Solicitacao" HeaderText="Data Agendamento"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Fg_Ok" HeaderText="FgOk" Visible="false"></asp:BoundColumn>
                                <asp:BoundColumn DataField="RELATORIO" HeaderText="RELATORIO" Visible="false"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ID" HeaderText="ID" Visible="false"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FG_RELATORIO_DETALHADO" HeaderText="Relatório Detalhado"
                                    Visible="true"></asp:BoundColumn>
                            </Columns>
                            <HeaderStyle CssClass="Header" />
                        </asp:DataGrid>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <center>
            <asp:Label ID="lblMsg" runat="server" BackColor="Yellow" Font-Bold="True" Font-Names="Arial"
                Font-Size="Small" ForeColor="Red"></asp:Label>
        </center>
        <asp:DataGrid ID="dgRelatorio" runat="server" AutoGenerateColumns="False" CellPadding="4"
            GridLines="None" CssClass="TableCinza TableTxt10">
            <FooterStyle />
            <EditItemStyle />
            <SelectedItemStyle />
            <PagerStyle />
            <AlternatingItemStyle CssClass="Listra" />
            <ItemStyle />
            <Columns>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:ImageButton ID="imgBtnExpandir" runat="server" CommandName="Expandir" ImageUrl="~/img/maximizar.gif" />
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="IdUsuario" HeaderText="IdUsuario" SortExpression="IdUsuario">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Usuario" HeaderText="Usuário" SortExpression="Usuario">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Consulta" HeaderText="Consulta" SortExpression="Consulta">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Qtd. Consulta" HeaderText="Qtd. Consulta" SortExpression="Qtd. Consulta">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Válido" HeaderText="Válido" SortExpression="Consulta">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Inválido" HeaderText="Inválido" SortExpression="Inválido">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Outros" HeaderText="Outros" SortExpression="Outros">
                </asp:BoundColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:Panel runat="server" ID="pnlTotalRankingUsuario" Visible="False">
                            </td></tr>
                            <tr bgcolor="#b5d6f6">
                                <td>
                                </td>
                                <td colspan="5">
                                    <b><font color="#333333" face="Arial">Avaliação dos Rankings ---------------------------------------------------</b></font>
                                    <font color="green">(&nbsp;Válido:
                                        <%#DataBinder.Eval(Container.DataItem, "VÁLIDO")%>&nbsp;)</font>&nbsp; <font color="red">
                                            (&nbsp;Inválido:
                                            <%#DataBinder.Eval(Container.DataItem, "INVÁLIDO")%>&nbsp;)</font>&nbsp;
                                    <font color="black">(&nbsp;Outros:
                                        <%#DataBinder.Eval(Container.DataItem, "OUTROS")%>&nbsp;)</font>&nbsp;
                                </td>
                            </tr>
                        </asp:Panel>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <HeaderStyle CssClass="Header" />
        </asp:DataGrid>
        <!--Fecha div Faixa-->
        <!--Final Tabela-->
        <asp:Panel ID="pnlTotalCliente" runat="server" Style="display: none; background: #CCCCCC !important;
            border: 2px solid #001E46" CssClass="ModalLayout">
            <h1>
                <asp:Label ID="lblTotal" runat="server" Text="Total Pesquisado por Cliente"></asp:Label></h1>
            <center>
                <asp:DataGrid ID="dgTotalConsultaCliente" runat="server" CellPadding="4" GridLines="Horizontal"
                    AutoGenerateColumns="False" CssClass="visualizar">
                    <FooterStyle />
                    <SelectedItemStyle />
                    <HeaderStyle CssClass="Header" />
                    <Columns>
                        <asp:BoundColumn DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="Qtd. Total de Consultas" HeaderText="Qtd. Total de Consultas"
                            SortExpression="Qtd. Total de Consultas"></asp:BoundColumn>
                    </Columns>
                </asp:DataGrid>
                <br />
                <img alt="Clique para fechar" src="img/Bt_Sair.png" onclick="$find('ctl00_ContentPlaceHolder1_mpeTotalCliente').hide();" />
            </center>
        </asp:Panel>
        <cc1:ModalPopupExtender ID="mpeTotalCliente" runat="server" TargetControlID="btnOk"
            PopupControlID="pnlTotalCliente" BackgroundCssClass="modalBackground" OkControlID="btnOk"
            CancelControlID="btnOk" />
        <asp:Button ID="btnOk" runat="server" Text="Button" Style="display: none" />
        <center>
            <asp:UpdateProgress ID="uptProgressRelClean" runat="server">
                <ProgressTemplate>
                    <br />
                    <img src="img/aguarde2.gif" alt="" style="display: none" />
                </ProgressTemplate>
            </asp:UpdateProgress>
        </center>
    </div>
    <asp:Panel ID="pnlAguarde" runat="server">
        <center>
            <br />
        </center>
    </asp:Panel>
    <cc1:ModalPopupExtender ID="mpeAguarde" runat="server" TargetControlID="btnMpeAguarde"
        PopupControlID="pnlAguarde" BackgroundCssClass="modalBackground" OkControlID="btnMpeAguarde"
        CancelControlID="btnMpeAguarde" />
    <asp:Button ID="btnMpeAguarde" runat="server" Text="Button" Style="display: none" />
</asp:Content>
