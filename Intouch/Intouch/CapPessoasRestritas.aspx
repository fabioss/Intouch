<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="CapPessoasRestritas.aspx.cs"
    Inherits="Intouch.CapPessoasRestritas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1"  TagName="ToolkitScriptManager" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HeadCapPessoasRestritas" runat="server">

    <script src="JavaScript/Mascara.js" type="text/javascript"></script>

    <link href="css/CSSintouch.css" rel="stylesheet" type="text/css" />
    <link href="css/estiloAjax.css" rel="stylesheet" type="text/css" />
    <title>Cadastro Cliente</title>

    <script language="JavaScript" type="text/javascript">
        function abrirModalAguarde() {
            $find("mpeAguarde").show();
        }
        function Mensagem() {
            alert('teste');
        }
    
    </script>

</head>
<body>
    <form id="formPessoasRestritas" runat="server">
    <cc1:ToolkitScriptManager ID="smCapPessoasRestritas" runat="server" />
    <asp:UpdatePanel ID="upCapPessoasRestritas" runat="server">
        <ContentTemplate>
            <div id="cadPessoasRestritas">
                <div class="linha_titulo">
                    <div class="ic_tema">
                        <img src="img/ic_pessoas_restritas.png" alt="" /></div>
                    <span class="titulo_popup">Cadastrar Pessoas Restritas</span>
                </div>
                <div class="boxPessoasRestritas">
                    <div class="linha1_PessoasRestritas">
                        <div class="name_campo_PessoasRestritas">
                            <asp:Label ID="Label2" runat="server" Text="Nome Artístico"></asp:Label></div>
                        <div class="campo_PessoasRestritas_1">
                            <asp:TextBox ID="txtNomeArtistico" runat="server" BorderWidth="0px" CssClass="imput"
                                Width="189px"></asp:TextBox></div>
                    </div>
                    <div class="linha2_PessoasRestritas">
                        <div class="name_campo_PessoasRestritas">
                            <asp:Label ID="Label21" runat="server" Text="Nome Original"></asp:Label></div>
                        <div class="campo_PessoasRestritas_1">
                            <asp:TextBox ID="txtNome" runat="server" BorderWidth="0px" CssClass="imput" Width="189px"></asp:TextBox></div>
                    </div>
                    <div class="linha2_PessoasRestritas">
                        <div class="name_campo_PessoasRestritas">
                            <asp:Label ID="Label3" runat="server" Text="CPF"></asp:Label></div>
                        <div class="campo_PessoasRestritas_2">
                            <asp:TextBox ID="txtCpf" runat="server" BorderWidth="0px" CssClass="imput" Width="123px"
                                MaxLength="14"></asp:TextBox></div>
                    </div>
                    <div class="linha2_PessoasRestritas">
                        <div class="name_campo_PessoasRestritas">
                            <asp:Label ID="Label4" runat="server" Text="Data Nascimento"></asp:Label></div>
                        <div class="campo_PessoasRestritas_2">
                            <asp:TextBox ID="txtDataNascimento" runat="server" BorderWidth="0px" CssClass="imput"
                                Width="123px" MaxLength="10"></asp:TextBox></div>
                        <span class="txt_descricao">(dd/mm/aa)</span>
                        <div class="name_campo_PessoasRestritas2">
                            <asp:Label ID="Label23" runat="server" Text="Idade"></asp:Label></div>
                        <div class="campo_PessoasRestritas_3">
                            <asp:TextBox ID="txtIdade" runat="server" BorderWidth="0px" CssClass="imput" Width="36px"
                                MaxLength="3"></asp:TextBox></div>
                    </div>
                    <div class="linha2_PessoasRestritas">
                        <div class="name_campo_PessoasRestritas">
                            <asp:Label ID="Label7" runat="server" Text="Cidade"></asp:Label></div>
                        <div class="campo_PessoasRestritas_1">
                            <asp:TextBox ID="txtCidade" runat="server" BorderWidth="0px" CssClass="imput" Width="189px"></asp:TextBox></div>
                        <div class="name_campo_PessoasRestritas3">
                            <asp:Label ID="lblUF" runat="server" Text="UF"></asp:Label></div>
                        <div class="campo_PessoasRestritas_3">
                            <asp:TextBox ID="txtEstado" runat="server" BorderWidth="0px" CssClass="imput" Width="30px"
                                MaxLength="2"></asp:TextBox></div>
                    </div>
                </div>
                <!--Fecha div boxPessoasRestritas-->
                <div class="linha3_PessoasRestritas">
                    <center>
                        <asp:ImageButton ID="btnInserirPessoaRestrita" runat="server" ImageUrl="~/img/bt_Inserir.jpg" /></center>
                </div>
                <asp:HiddenField ID="btnhldMsgValidCadPessRestritas" runat="server" />
                <cc1:ModalPopupExtender ID="mpeMsgValidCadPessRestritas" runat="server" OkControlID="btnhldMsgValidCadPessRestritas"
                    CancelControlID="btnhldMsgValidCadPessRestritas" TargetControlID="btnhldMsgValidCadPessRestritas"
                    PopupControlID="pnlCadPessRestritas" BackgroundCssClass="modalBackground" />
                <asp:Panel ID="pnlCadPessRestritas" runat="server" Style="display: none;">
                    <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="3000" OnTick="Timer1_Tick" />
                    <asp:Label ID="lblMsgValidacao" runat="server" Font-Names="Verdana" Font-Size="Small"
                        Text="" Width="400px" Height="100px" />
                </asp:Panel>
                <center>
                    <asp:UpdateProgress ID="uptProgressCadPessRestritas" runat="server">
                        <ProgressTemplate>
                            <br />
                            <img src="img/aguarde2.gif" alt="" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </center>
        </ContentTemplate>
    </asp:UpdatePanel>
    </div><!--Fecha div cadPessoasRestritas-->
    </form>
</body>
</html>
