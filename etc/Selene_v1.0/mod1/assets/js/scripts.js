/** ********************************************** **
	@Author			Dorin Grigoras
	@Website		www.stepofweb.com
	@Last Update	Wednesday, November 19, 2014

	NOTE! 	Do not change anything here if you want to
			be able to update in the future! Please use
			your custom script (eg. custom.js).

	TABLE CONTENTS
		Core
		Preloader
		Menu
		Cycle
		LightBox
		Mobile Detect
*************************************************** **/

	/* Init */
	jQuery(window).ready(function () {
		Init();
	});


/** Core
 **************************************************************** **/
	function Init() {

		_menu();
		_cycle();
		_lightbox();

		/** Bootstrap Tooltip **/ 
		jQuery("[data-toggle=tooltip]").tooltip();
	}


/** Preloader
 **************************************************************** **/
	jQuery(window).load(function() {
		
		jQuery('#preloader').fadeOut(1000, function() {
			jQuery('#preloader').remove();
		});

		setTimeout(function() {

			jQuery('#preloader').addClass('animated fadeOut').fadeOut(2000);	

			setTimeout(function() {

				// Logo, Slider, Info, Countdown
				jQuery('#home img.logo , #slider .cycle-slider').show();

				setTimeout(function() {

					// Menu & Social
					jQuery('#home ul, #home p, #countdown').show();


				}, 500); 

			}, 0);

		}, 1000); 
	  
	});


/** Menu
 **************************************************************** **/
	function _menu() {

		// Menu Click
		jQuery("ul.nav>li>a").bind("click", function(e) {
			
				var _href = jQuery(this).attr('href');
				if(_href != '#noclick') {
					jQuery("ul.nav>li").removeClass('active');
					jQuery(this).parent().addClass('active');
				}

		});

		// Hash Change Monitor
		jQuery(window).on('hashchange', function() {
			if(window.location.hash != '#noclick')  {
				_switchPage(window.location.hash);
			}
		});

		// On load
		if(window.location.hash != '' && window.location.hash != '#home' && window.location.hash != '#noclick') {
			jQuery('#slider').fadeIn(0);
			jQuery("ul.nav>li").removeClass('active');
			
			jQuery("ul.nav>li").each(function() {
				var _href = jQuery("a", this).attr('href');
				if(_href == window.location.hash) {
					jQuery(this).addClass('active');
				}
			});

			_switchPage(window.location.hash);
		}

	}

	function _switchPage(_hash) {

		if(_hash == '#home') {

			jQuery('.page, .page-overlay').fadeOut(300);
			jQuery('#slider').fadeIn(500);

		} else {

			if(!jQuery('.page-overlay').is(":visible")) {
				jQuery('.page-overlay').fadeIn(300);
				jQuery('#slider').fadeOut(500)
			}

			jQuery('.page').fadeOut(400);
			jQuery(_hash).fadeIn(500);

		}

	}


/** Cycle
 **************************************************************** **/
	function _cycle() {

		jQuery('div.cycle-slider').cycle({
			fx : 		'fade',
			timeout: 	parseInt(jQuery('div.cycle-slider').attr('data-timeout')) 	|| 7000,
			delay: 		parseInt(jQuery('div.cycle-slider').attr('data-delay')) 	|| 1000,
			speed: 		parseInt(jQuery('div.cycle-slider').attr('data-speed')) 	|| 500,
			slides: 	'.slide'
		});
	}


/** LightBox
 **************************************************************** **/
function _lightbox() {

	if(typeof(jQuery.magnificPopup) == "undefined") {
		return false;
	}

	jQuery.extend(true, jQuery.magnificPopup.defaults, {
		tClose: 		'Close',
		tLoading: 		'Loading...',

		gallery: {
			tPrev: 		'Previous',
			tNext: 		'Next',
			tCounter: 	'%curr% / %total%'
		},

		image: 	{ 
			tError: 	'Image not loaded!' 
		},

		ajax: 	{ 
			tError: 	'Content not loaded!' 
		}
	});

	jQuery(".lightbox").each(function() {

		var _t 			= jQuery(this),
			options 	= _t.attr('data-plugin-options'),
			config		= {},
			defaults 	= {
				type: 				'image',
				fixedContentPos: 	false,
				fixedBgPos: 		false,
				mainClass: 			'mfp-no-margins mfp-with-zoom',
				image: {
					verticalFit: 	true
				},

				zoom: {
					enabled: 		false,
					duration: 		300
				},

				gallery: {
					enabled: false,
					navigateByImgClick: true,
					preload: 			[0,1],
					arrowMarkup: 		'<button title="%title%" type="button" class="mfp-arrow mfp-arrow-%dir%"></button>',
					tPrev: 				'Previou',
					tNext: 				'Next',
					tCounter: 			'<span class="mfp-counter">%curr% / %total%</span>'
				},
			};

		if(_t.data("plugin-options")) {
			config = jQuery.extend({}, defaults, options, _t.data("plugin-options"));
		}

		jQuery(this).magnificPopup(config);

	});
}


/** Mobile Detect
 **************************************************************** **/
(function(a){(jQuery.browser=jQuery.browser||{}).mobile=/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|android|ipad|playbook|silk|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino/i.test(a)||/1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0,4))})(navigator.userAgent||navigator.vendor||window.opera);