// JavaScript Document

/*--------------------------------------------------*/
/* Show/Hide Panel*/
/*--------------------------------------------------*/

$(document).ready(function(){
	$(".btn_slide").click(function(){
		$("#theme_bottom_bar").slideToggle("slow");
		$(this).toggleClass("active"); return false;
	});
});

