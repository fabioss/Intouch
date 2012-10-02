function nova_jan(newwindow)
{
   var desktop = window.open(newwindow,'new_window','toolbar=yes,location=yes,directories=yes,status=yes,scrollbars=yes,menubar=yes,resizable=yes');
}
   
function AbrePesquisa()
{ 
   window.open('/aplicacoes/atbhe/poll/default.asp?Cod=0&FS=14px','_blank','height=350,width=310,status=no,toolbar=no,menubar=no,location=no,scrollbars=yes');
}

function AbreJanela(URL,Target)
{
	window.open(URL,Target);
}

var ImagemAtual = new Image();
function MudaImagem(MyImg, Imagem)
{
   ImagemAtual.src = Imagem;
   MyImg.src = ImagemAtual.src;
}
