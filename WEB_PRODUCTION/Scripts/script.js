
	$('#doctor').on('click', function(e){
    e.preventDefault();
    var target= $(this).get(0).id == 'doctor' ? $('#find-doctor') : $('#doctor');
    $('html, body').stop().animate({
       scrollTop: target.offset().top
    }, 1000);
});
	$('#doctorbtn').on('click', function(e){
    e.preventDefault();
    var target= $(this).get(0).id == 'doctorbtn' ? $('#find-doctor') : $('#doctorbtn');
    $('html, body').stop().animate({
       scrollTop: target.offset().top
    }, 1000);
});
	$(document).ready(function() {
		   	var stickyNavTop = $('.nav').offset().top;
		   	var stickyNav = function(){
			    var scrollTop = $(window).scrollTop();
			    if (scrollTop > stickyNavTop) { 
			        $('.nav').addClass('sticky');
			        $('.nav').addClass('sticky ul li a');
			        $('.nav').addClass('sticky ul li a:hover');
			    } else {
			        $('.nav').removeClass('sticky'); 
			    }
			};

			stickyNav();
			$(window).scroll(function() {
				stickyNav();
			});
		});