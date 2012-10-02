<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PesqCpfCnpjReceita.aspx.cs"
    Inherits="Intouch.PesqCpfCnpjReceita" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>

<script language="javascript" type="text/javascript">
    function SetValorIFrame() {
        var ifrm = document.getElementById('meuIframe');
        ifrm.domain = "receita.fazenda.gov.br";
    }
</script>

<body onload="SetValorIFrame();">
    <form id="formPesqCpfCnpjReceita" runat="server">
    <div>
        <asp:Literal ID="ltResultado" runat="server"></asp:Literal>
      <iframe name="meuIframe" id="meuIframe" runat="server" src="http://www.receita.fazenda.gov.br/aplicacoes/atcta/cpf/consultapublica.asp"
            style="height: 504px; width: 692px"></iframe>
    </div>
    </form>
</body>
</html>
