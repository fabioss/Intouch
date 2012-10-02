<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Estrutura.Master"
    CodeBehind="Default.aspx.vb" Inherits="Intouch._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headEstrutura" runat="server">
<link href="css/CSSintouchClean.css" rel="stylesheet" type="text/css" />
<script src="JavaScript/Mascara.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderEstrutura" runat="server">
<cc1:ToolkitScriptManager ID="ToolkitScriptManagerDefault" runat="server" />
    <div class="Produtos">
        <h1>
            OneBuscas</h1>
        <h2>
            Solução para empresas de cobrança e recuperação de crédito.</h2>
        <p>
            A mais completa e eficiente solução de consulta, on line, de dados e localização
            buscando recuperação
            <br />
            de crédito eficaz.</p>
        <div>
  </div>
  <div style="width: auto;"></div>
    </div>
    <div class="BoxLogin">
        <div class="Cabec">
            <h2>
                Login</h2>
            <h1>
                OneBuscas</h1>
        </div>
        <div class="Form">
            <label>
                Usuário:</label>
            <div class="Clear">
            </div>
            <asp:TextBox ID="txtUsuarios" runat="server" CssClass="Campos Medio"></asp:TextBox>
        </div>
        <div class="Form">
            <label>
                Senha:</label>
            <div style="clear: both;">
            </div>
            <asp:TextBox ID="txtSenhas" runat="server" CssClass="Campos Medio" TextMode="Password"></asp:TextBox>
        </div>
        <div class="Form">
            <label>
                Cliente:</label>
            <div style="clear: both;">
            </div>
            <asp:TextBox ID="txtClientes" runat="server" CssClass="Campos Medio"></asp:TextBox>
        </div>
        <div class="Rodape">
            <div class="Txt">
                <h4>
                    <a href="http://www.unitfour.com.br/html/contato.asp" target="_blank">» Fale Conosco</a></h4>
                <h4>
                    Seu IP é
                    <%=Request.ServerVariables("REMOTE_ADDR")%></h4>
                <asp:Label ID="lblMsgs" runat="server"></asp:Label>
            </div>
            <asp:Button ID="btnLogins" runat="server" Text="Entrar" CssClass="Btn BtnPeq" />
        </div>
    </div>
</asp:Content>
