// JAVA SCRIPT CAPTCHA
// DESENVOLVIDO PELA ATHBE/ATWEB
// EQUIPE DO PROJETO INTERCEPTA-001

// M�TODOS OBRIGAT�RIOS

// Valida os caracteres de letra e som digitados
// Tamb�m � fornecido o nome do formul�rio principal e a p�gina de destino ap�s valida��o
function validaCaracteresCaptcha(nomeForm, idLetra, idSom, paginaDestino) {
	var form = document.getElementById(nomeForm);
	if (document.getElementById(idLetra).value == "" && document.getElementById(idSom).value == "")
	{
		 AlertaCaptcha("Favor preencher algum dos campos de valida��o");
		 form.action= "";
		 return false;
	}
	
	if (document.getElementById(idLetra).value != "" && document.getElementById(idSom).value != "")
	{
		 AlertaCaptcha("Favor preencher apenas um dos campos de valida��o");
		 form.action="";
		 return false;
	}
	
	form.action=paginaDestino;
	return true;
}

// Fun��o que inclui no c�digo a chamada ao Flash e exibe o spanSom para que o usu�rio
// digite os n�meros do idSom
function playCaptcha(container, idSom, spanSom) 
{
	str = '';
	str += '<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000"'
	str += ' codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0"'
	str += ' width="1"'
	str += ' height="1"'
	str += ' id="sound"'
	str += ' align="middle">'
	str += '<param name="allowScriptAccess" value="sameDomain" />'
	str += '<param name="movie" value="/scripts/srf/intercepta/captcha.swf" />'
	str += '<param name="quality" value="high" />'
	str += '<param name="bgcolor" value="#ffffff" />'
	str += '<embed src="/scripts/srf/intercepta/captcha.swf" quality="high" bgcolor="#ffffff"'
	str += ' width="1"'
	str += ' height="1"'
	str += ' name="sound"'
	str += ' align="middle"'
	str += ' allowScriptAccess="sameDomain" type="application/x-shockwave-flash"'
	str += ' pluginspage="http://www.macromedia.com/go/getflashplayer" />'
	str += '</object>'

	document.getElementById(container).innerHTML=str;
	
	document.getElementById(spanSom).style.visibility="visible";
	document.getElementById(idSom).focus();

	return void(0);
}

// Exibe caixa de alerta com a mensagem passada atrav�s do par�metro
function AlertaCaptcha(strMsg)
{
window.alert(strMsg)
}

// Recupera uma refer�ncia ao objeto com o id especificado
// Funciona primariamente com o DOM, mas tamb�m aceita document.all
function pegaObjCaptcha( id ) {

	if ( typeof(document.getElementById) != 'undefined' )
		return document.getElementById( id );
	else if ( document.all ) {
		return document.all( id );
	}
}

// Fun��o chamada no evento onKeyDown para evitar que caracteres n�o num�ricos
// sejam inseridos no campo indicado.
// Par�metros:
// input: refer�ncia para o objeto <input> que recebeu o evento
// e: o objeto event
function ajustarNumeroCaptcha(input, e) {

	var k;

	// e.which: explorer, e.keyCode: mozilla
	if (e && e.which)
		k = e.which;
	else
		k = e.keyCode;

	// No IE n�o essa fun��o n�o consegue cancelar tabs, BS, DEL, etc, mas no mozilla sim,
	// por isso precisamos deixar passar as teclas de edi��o.
	// Somente aceita os caracteres 0-9, tab, enter, del e BS
	if ( ((k<48)||(k>57)) && k != 8 && k != 9 && k != 127 && k != 13 && !((k>34)&&(k<41)) && k != 46 ) {
		e.returnValue = false;
		return false;
	}

	return true;
}

// Fun��o chamada no keyup
// Se a tecla pressionada for num�rica e o n�mero m�ximo de caracteres foi alcan�ado,
// muda para o pr�ximo campo
// Par�metros:
// input: refer�ncia para o objeto <input> que recebeu o evento
// e: o objeto event
function pularCampoCaptcha(input, e) {

	var k = -1;

	// e.which: explorer, e.keyCode: mozilla
	if (e && e.which)
		k = e.which;
	else
		k = e.keyCode;

	// Somente mudamos de campo se a tecla levantada pode ter gerado uma entrada ('0'-'9')
	// Aqui est�o dois grupos, pois os 2 teclados num�ricos enviam c�digos diferentes!
	if ( (k >= 48 && k<= 57) || (k >= 96 && k<= 105) || k==13 )
		// Verificamos se este campo tem limite de tamanho e movemos para o pr�ximo se j� o alcan�amos
		if ( typeof( inputList[input.id] ) != 'undefined' ) {
			// Foi pressionada uma tecla que escreve algo e o tamanho j� est� completo?
			if ( input.value.length == inputList[input.id]['tamanho'] )
				pegaObjCaptcha( inputList[input.id]['proximo'] ).focus();
		}
}

// Fun��o espec�fica do IE, que busca as informa��es do evento
// e repassa para as rotina em si "ajustarNumeroCaptcha" e "pularCampoCaptcha"
function ajustarNumeroCaptchaIE() {

	e = window.event;
	input = pegaObjCaptcha( e.srcElement.id );

	return ajustarNumeroCaptcha( input, e );
	
}

function pularCampoCaptchaIE() {

	e = window.event;
	input = pegaObjCaptcha( e.srcElement.id );

	return pularCampoCaptcha( input, e );
	
}

// Fun��o que registra os inputs que precisam ser num�ricos e que t�m
// um tamanho fixo que, quando alcan�ado, muda para o pr�ximo campo.
// Par�metros:
// id: id do <input> que deve capturar os eventos de tecla
// tamanhoMaximo: o n�mero de d�gitos m�ximo para este campo
// proximoId: id do pr�ximo campo no formul�rio para o qual pularemos quando
//            o n�mero m�ximo de d�gitos for alcan�ado.
var inputList = new Array();
function registraInputCaptcha( id, tamanhoMaximo, proximoId ) {

	inputList[id] = new Array();
	inputList[id]['tamanho'] = tamanhoMaximo;
	inputList[id]['proximo'] = proximoId;

	// No IE n�o funciona setar o atributo via DOM, e o evento n�o vem como par�metro
	// portanto precisamos setar uma fun��o diferente para ele
	pegaObjCaptcha(id).onkeyup = pularCampoCaptchaIE;
	pegaObjCaptcha(id).onkeypress = ajustarNumeroCaptchaIE;
	
	// O mozilla tamb�m aceita a linha anterior, mas aqui n�s passamos por cima e
	// chamamos a fun��o diretamente
	pegaObjCaptcha(id).setAttribute( 'onKeyUp', 'pularCampoCaptcha(this, event)');
	pegaObjCaptcha(id).setAttribute( 'onKeyPress', 'return ajustarNumeroCaptcha(this,event)');
}

