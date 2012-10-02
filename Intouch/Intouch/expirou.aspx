<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="expirou.aspx.cs" Inherits="Intouch.expirou" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" TagName="ToolkitScriptManager" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HeadExpirou" runat="server">
    <title>Sessão Expirada</title>
    <link href="css/CSSintouchClean.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="formExpirou" runat="server">
    <cc1:ToolkitScriptManager ID="smBuscaCleanExpirou" runat="server" />
    <asp:UpdatePanel ID="upExpirouBC" runat="server">
        <ContentTemplate>
            <asp:Timer ID="tmrExpirou" runat="server">
            </asp:Timer>
            <center>
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="lblTitulo" runat="server" Font-Names="Arial" Font-Size="60px"
                    Text="Sessão Expirada"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="lblMsgExpirou" runat="server" Font-Names="Arial" 
                    Font-Size="30px" Font-Italic="True"></asp:Label>
            </center>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
