<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="RelatorioClean.aspx.cs"
    Inherits="Intouch.RelatorioClean" Culture="pt-BR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Src="~/menu.ascx" TagName="ucMenu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HeadRelatorioClean" runat="server">
    <title>Intouch - Versão: 2.0.1.4</title>
    <link href="css/CSSintouchClean.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <!--Resolve problemas no IE-->
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE8" />
    <!--Resolve problemas no IE-->
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>

<script language="javascript" type="text/javascript">
function desabilitarCampos() {
document.getElementById('<%= ddlOpcoesUsuario.ClientID %>').disabled = 1;
document.getElementById('<%= ddlTipo.ClientID %>').disabled = 1;
}
function abrirModalAguarde()
    {
      $find("mpeAguarde").show();
    }
    
    function GetIdUsuario(valor)
    {
        if (valor.split('|').length == 2)
        {
            novoArray = valor.split('|');
            document.getElementById('<%= hdnFldIdLogin.ClientID %>').value = novoArray[0]; // retornará "idLogin"
            document.getElementById('<%= txtNomePesq.ClientID %>').value = novoArray[1]; // retornará "DsLogin"
        }
        else
        {
            document.getElementById('<%= hdnFldIdLogin.ClientID %>').value = '0';
            document.getElementById('<%= txtNomePesq.ClientID %>').value = 'Todos';
        }
    }
    
</script>

<body>
    <form id="formRelatorioClean" runat="server">
    <uc1:ucMenu ID="ucMenuCabecalhoRelatorio" runat="server" />
    <asp:HiddenField ID="hdnFldIdLogin" runat="server" />
    <div class="faixa">
        <div class="topfaixa">
            <div class="topimg">
                <a href="BuscaClean.aspx" title="Ir para a página principal">
                    <img src="img/house.png" alt="" border="0" /></a>
            </div>
            <!--Final Topimg-->
            <div class="relatorio">
                Relatórios
            </div>
            <!--Final Relatorio-->
        </div>
        <!--Final Topfaixa-->
    </div>
    <!--Fecha div Faixa-->
    <div class="total">
        <cc1:ToolkitScriptManager ID="smRelClean" runat="server" />
        <div class="box1_relatorio">
            <div class="relatorioLine_1">
                <div class="relatorio_Item01">
                    <asp:Label ID="Label1" runat="server" Text="Data de Início"></asp:Label></div>
                <div class="relatorio_Item02" style="width: 180px;">
                    <asp:TextBox ID="txtDataInicio" runat="server" />
                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDataInicio"
                        Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy">
                    </cc1:CalendarExtender>
                </div>
            </div>
            <div class="relatorioLine_2">
                <div class="relatorio_Item01">
                    <asp:Label ID="Label2" runat="server" Text="Data do Fim"></asp:Label></div>
                <div class="relatorio_Item02" style="width: 180px;">
                    <asp:TextBox ID="txtDataFim" runat="server" />
                    <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDataFim"
                        Format="dd/MM/yyyy" TodaysDateFormat="d MMMM , yyyy">
                    </cc1:CalendarExtender>
                </div>
            </div>
            <div class="relatorioLine_2">
                <div class="relatorio_Item01" id="lblRelExcel" runat="server">
                    Relatório em Excel</div>
                <div class="relatorio_Item02_1">
                    <asp:CheckBox ID="chkBoxGerarExcel" runat="server" Checked="true" TextAlign="Left"
                        ToolTip="Ao processar o relatório geral, será processado também um relatório detalhado" /></div>
            </div>
        </div>
        </br>
        <div class="box22_relatorio">
            <div class="relatorioLine_4">
                <div class="relatorio_Item03">
                    <asp:Label ID="Label5" runat="server" Text="Cliente"></asp:Label></div>
                <div>
                    <asp:DropDownList ID="ddlCliente" runat="server" Width="205px" BorderWidth="1" BorderColor="#c3c3c3"
                        Font-Names="Arial, Verdana" Font-Size="10px" ForeColor="#5a5a5a" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="relatorioLine_4" id="itemUsuario" runat="server">
                <div class="relatorio_Item03">
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuário"></asp:Label></div>
                <div class="relatorio_Item02">
                    <asp:TextBox ID="txtNomePesq" runat="server" runat="server" Width="205px" BorderWidth="1"
                        BorderColor="#c3c3c3" Font-Names="Arial, Verdana" Font-Size="10px" ForeColor="#5a5a5a" autocomplete="off"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtNomePesq"
                        ServiceMethod="GetUsuarioList" ServicePath="wsIntouch.asmx" UseContextKey="true"
                        MinimumPrefixLength="2" EnableCaching="true" CompletionSetCount="12" CompletionInterval="1000"
                        BehaviorID="autoCompleteBehavior1" CompletionListCssClass="autocomplete_completionListElement"
                        CompletionListItemCssClass="autocomplete_listItem" CompletionListHighlightedItemCssClass="autocomplete_highlightedList" />
                </div>
            </div>
            <div class="relatorioLine_3">
                <div class="relatorio_Item03">
                    <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label></div>
                <div class="relatorio_Item02">
                    <asp:DropDownList ID="ddlTipo" runat="server" Width="205px" BorderWidth="1" BorderColor="#c3c3c3"
                        Font-Names="Arial, Verdana" Font-Size="10px" ForeColor="#5a5a5a">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="relatorioLine_4">
                <div class="relatorio_Item03">
                    <asp:Label ID="lblOrdenar" runat="server" Text="Opções de Usuário"></asp:Label></div>
                <div class="relatorio_Item02">
                    <asp:DropDownList ID="ddlOpcoesUsuario" runat="server" Width="205px" BorderWidth="1"
                        BorderColor="#c3c3c3" Font-Names="Arial, Verdana" Font-Size="10px" ForeColor="#5a5a5a">
                        <asp:ListItem Value="1">Mostrar Usuarios Ativos</asp:ListItem>
                        <asp:ListItem Value="2">Mostrar Usuarios Inativos</asp:ListItem>
                        <asp:ListItem Value="0">Mostrar Usuarios (Ativos / Inativos)</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
    </div>
    <!--final total-->
    <table align="left">
        <tr>
            <td width="200">
                <div class="box3_relatorio">
                    <div class="relogio">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/bt_limpar.jpg"
                            Visible="false" Style="display: none;" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="btnConsultar" runat="server" ImageUrl="~/img/relogio1.png" OnClientClick="abrirModalAguarde();"
                            ToolTip="Agendar Relatório" />
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Name="tahoma" ForeColor="#666666"></asp:Label>
                    </div>
                    <!--Fecha Relogio-->
                    <div class="agendar">
                        Agendar Relatório
                    </div>
                    <!--fecha agendar-->
                </div>
                <!--box3_relatorio-->
            </td>
            <td>
                <div class="box4_relatorio">
                    <asp:ImageButton ID="imgBtnExportaExcel" runat="server" ImageUrl="~/img/bt_exportarRelatorio.jpg" />
                </div>
            </td>
            <td>
                <div class="box5_relatorio">
                    <div class="relatorio_Item04">
                        <asp:Label ID="lblQtdTotalConsultada" runat="server"></asp:Label>
                    </div>
                    <!--Final Box5_relatorio-->
                    <br />
                    <div class="relatorio_Item04">
                        <asp:LinkButton ID="lnkBtnTotalCliente" runat="server" Text="Total Geral de Pesquisas Feitas por Cliente"
                            Visible="false"></asp:LinkButton></div>
                </div>
            </td>
        </tr>
    </table>
    <div id="relatorios">
        <div class="faixa">
            <div class="topfaixa">
                <div class="topimg">
                    <asp:ImageButton ID="ImageButton2" Height="25px" runat="server" ImageUrl="~/img/relatorio.png"
                        ToolTip="Clique para verificar se o relatório já está disponivel" />
                </div>
                <!--Final topimg-->
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial"></asp:Label>
                <div class="relatorio">
                    Relatórios Agendados
                </div>
                <!-- Final relatorio-->
            </div>
            <!-- Final topfaixa-->
        </div>
        <!--Fecha div Faixa-->
        <div class="tabela">
            &nbsp;<table id="table" bgcolor="White" cellpadding="0" cellspacing="0">
                </br>
                <tr>
                    <td width="auto" height="530px" valign="top">
                        <div class="relatorio_DataGrid">
                            <asp:Panel ID="pnlAgendados" runat="server" BorderStyle="Double" BorderWidth="1px"
                                BorderColor="#f0f0f0" BackColor="#f0f0f0">
                                <table class="style1">
                                    <tr>
                                        <td>
                                            <asp:DataGrid ID="dgRelatorioAgendado" runat="server" AutoGenerateColumns="False"
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                CellPadding="4" Font-Names="Arial" Font-Size="X-Small" ForeColor="Black" GridLines="Horizontal"
                                                Width="795px" AllowPaging="True" PageSize="5">
                                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedItemStyle BackColor="White" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle NextPageText="Próximo" PrevPageText="Anterior" />
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
                                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                            </asp:DataGrid>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            </center>
                            <br />
                            <center>
                                <asp:Label ID="lblMsg" runat="server" BackColor="Yellow" Font-Bold="True" Font-Names="Arial"
                                    Font-Size="Small" ForeColor="Red"></asp:Label>
                            </center>
                            <asp:DataGrid ID="dgRelatorio" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                Font-Names="Arial" Font-Size="11px" Font-Bold="True" ForeColor="#333333" GridLines="None"
                                Width="100%">
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditItemStyle BackColor="#999999" />
                                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <AlternatingItemStyle BackColor="White" ForeColor="#333333" />
                                <ItemStyle BackColor="#efefef" ForeColor="#333333" />
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
                                <HeaderStyle BackColor="#3c5989" Font-Bold="True" ForeColor="White" Font-Size="11px" />
                            </asp:DataGrid>
                        </div>
        </div>
        <!-- Fecha div relatorios -->
        </td> </tr> </table>
    </div>
    <!--Final Tabela-->
    <asp:Panel ID="pnlTotalCliente" runat="server" BorderStyle="Solid" BorderWidth="2px"
        BackColor="#3c5989" Width="500px" Height="200px" ScrollBars="Vertical" Style="display: none;">
        <center>
            <asp:Label ID="lblTotal" runat="server" Text="Total Pesquisado por Cliente" ForeColor="White"
                Font-Bold="True" Font-Names="Arial"></asp:Label>
            <br />
            <br />
            <asp:DataGrid ID="dgTotalConsultaCliente" runat="server" Font-Names="Arial" Font-Size="X-Small"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="400px" AutoGenerateColumns="False">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
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
            <img alt="Clique para fechar" src="img/bt_sair_off.jpg" onclick="$find('mpeTotalCliente').hide();" />
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
    </form>
</body>
</html>
