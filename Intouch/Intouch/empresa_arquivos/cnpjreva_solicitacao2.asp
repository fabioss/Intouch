<%@ LANGUAGE="VBSCRIPT" %>
<% cnpj = request("cnpj")%>
<HTML><HEAD><TITLE>Emiss�o de Comprovante de Incri��o e de Situa��o Cadastral</TITLE>
<SCRIPT language=JavaScript>
  function proxima(link)
  {
   location.replace(link);
   return false;
  }
  function carrega(vobjeto) {
     for (var va = 0 ; va < document.forms[0].elements.length; va++) {
        if (document.forms[0].elements[va].name == vobjeto) {
            document.forms[0].elements[va].focus();
        }
     }    
     return false;
  }
  function volta(vvolta) {
     history.go(vvolta*-1);
     return false;
  }
  function SaltaCampo (campo, prox, tammax, teclapres)
{
   var tecla = teclapres.keyCode;
   vr = campo.value;
   tam = vr.length;
   if (tecla != 0 && tecla != 10 && tecla != 24)
      if (tam == tammax)
          prox.focus();
}
</SCRIPT>

<SCRIPT language=javascript>
		
		function FRMOnLoad()
		{
		    if (frmConsulta.idLetra.value != "")
		    {
				location.reload();
		    }
		    frmConsulta.cnpj.value = <%request("cnpj") %>;
		    frmConsulta.cnpj.focus();
		}
	</SCRIPT>

<SCRIPT src="cnpjreva_solicitacao2_arquivos/captcha.js" 
type=text/javascript></SCRIPT>
<LINK href="cnpjreva_solicitacao2_arquivos/captcha.css" type=text/css 
rel=stylesheet>
<META content="MSHTML 6.00.6000.16640" name=GENERATOR></HEAD>
<BODY background="" onload=FRMOnLoad();>
<FORM id=theForm name=frmConsulta 
onsubmit="javascript:return validaCaracteresCaptcha('theForm', 'idLetra', 'idSom', 'valida.asp')" 
action="" method=post>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TBODY>
  <TR>
    <TD><FONT face=Arial color=#000080><B>Emiss�o de Comprovante de Inscri��o 
      e de Situa��o Cadastral</B></FONT> </TD></TR></TBODY></TABLE>
<HR SIZE=1>

<P><FONT face=Arial size=2><B>Contribuinte,</B></P>
<P>Esta p�gina tem como objetivo permitir a emiss�o do Comprovante de Inscri��o 
e de Situa��o Cadastral de Pessoa Jur�dica pela Internet em conson�ncia com a <A 
href="http://www.receita.fazenda.gov.br/Legislacao/Ins/2007/in7482007.htm" 
target=_blank><FONT face=Arial size=2>Instru��o Normativa RFB n� 748, de 28 de 
junho de 2007.</A> 
<P align=left><FONT face=arial size=2>Digite o n�mero de CNPJ da empresa e 
clique em "Consultar".</FONT></P><INPUT type=hidden value=comprovante 
name=origem> 
<TABLE cellSpacing=1 border=0>
  <TBODY>
  <TR>
    <TD vAlign=top colSpan=2><FONT face=Arial size=2><B>CNPJ :</B> <INPUT 
      onkeyup="SaltaCampo(document.frmConsulta.cnpj, document.frmConsulta.chave, 14, event)" 
      tabIndex=1 maxLength=14 size=16 name=cnpj value="<%=cnpj%>"> </FONT></TD></TR>
  <TR>
    <TD vAlign=top width="60%">
      <P><FONT face=Arial size=2>Por favor, repita os caracteres ao lado: 
      </FONT><INPUT id=idLetra tabIndex=2 maxLength=4 size=6 name=idLetra> <A 
      tabIndex=3 href="javascript:playCaptcha('container', 'idSom', 'spanSom')"><!-- Imagem da acessibilidade --><IMG 
      style="BORDER-TOP-WIDTH: 0px; BORDER-LEFT-WIDTH: 0px; BORDER-BOTTOM-WIDTH: 0px; BORDER-RIGHT-WIDTH: 0px" 
      height=16 alt="Ouvir os n�meros" 
      src="http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/images/captcha.gif" width=15></A> <SPAN 
      id=spanSom style="VISIBILITY: hidden"><BR><LABEL for=idSom>Digite os 
      n�meros que ser�o falados em breve</LABEL> <INPUT id=idSom tabIndex=4 
      maxLength=6 size=7 name=idSom> </SPAN></P></TD>
    <TD vAlign=top width="40%"><!-- In�cio AntiRobo--><!-- src da imagem com o path do gerador de imagem--><SPAN><IMG 
      alt="Imagem com os caracteres anti rob�" 
      src="cnpjreva_solicitacao2_arquivos/captcha(1).gif" border=0> <BR><LABEL 
      class=textoInformativo for=lblInformativo>Se os caracteres da imagem 
      estiverem ileg�veis,</LABEL> 
      <A class=linkImagem tabIndex=5 
      href="javascript:window.location.href='http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao2.asp'">gerar 
      outra imagem.</A><BR></SPAN><!-- Fim AntiRobo--></TD></TR>
  <TR>
    <TD align=middle colSpan=2>
      <P><BR><INPUT id=submit1 type=submit value=Consultar name=submit1> <INPUT 
      type=hidden value=cnpj name=search_type> <INPUT type=reset value=Limpar name=opcao> </P></TD></TR></TBODY></TABLE></FORM><!-- Div obrigat�rio. Nele ser� gravado o c�digo necess�rio para funcionamento do flash-->
<DIV id=container></DIV></FONT></FONT></BODY></HTML>
