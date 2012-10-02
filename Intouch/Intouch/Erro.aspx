<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Erro.aspx.cs" Inherits="Intouch.Erro" %>
<%@ Register  Src="~/menu.ascx" TagName="ucMenu" TagPrefix="uc2"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Erro no processamento</title>
    <style type="text/css">
        .style1
        {
            margin: 10px 0 0 0;
            width: 720px;
            height: 25px;
            background-color: #ffffff;
            border: 0px solid red;
            font-weight: bold;
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
        }
        .style2
        {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            margin-top:50px;
        }
    </style>
</head>
<body>
    <form id="formErro" runat="server">
    <div>

        <!--logotipo intouch e pesquisa cpf/cnpj-->
        <table border="0">
            <tr>
                <td valign="top">
                    <div class="marcaIntouch">
                        <a href="#">
                            <img src="img/logoUnit.jpg" alt=""  border="0"/></a></div>
                </td>
                <td valign="top">
                    <div class="style1">
                        Erro durante o processamento
                    </div>
                    <div class="style2">
                        Desculpe-nos, ocorreu um erro durante o processamento dessa página.<br />
                        Nossa equipe foi notificada automaticamente do erro ocorrido  e trabalharemos para <br />
                        corrigi-lo.<br />
                        <br />
                        <br />

                    <p>
                        Obrigado,<br />
                        Equipe Unitfour<br />
                        <a href="JavaScript:history.go(-1);return false;">Voltar</a>
                    </p>
                    </div>
                </td>
            </tr>
        </table>
    <!--fim logotipo intouch e pesquisa cpf/cnpj-->
    </div>
    </form>
</body>
</html>
