/** Newsletter
*************************************************** **/
/**
	Change here if you need to translate
**/
var _internal_error 	= 'Server Internal Error!',
	_email_mandatory	= 'Please, type your email address!',
	_email_invalid 		= 'Invalid Email!',
	_email_thanks 		= 'Thank You!';


/** ***************************************************************************************************** **/
jQuery("#newsletter_subscribe button").bind("click", function(e) {
	e.preventDefault();

	// AJAX POST 
	jQuery.ajax({
		url: 	jQuery("#newsletter_subscribe").attr('action'),
		data: 	{ajax:"true", action:'newsletter_subscribe', email:jQuery("#newsletter_email").val()},
		type: 	jQuery("#newsletter_subscribe").attr('method'),
		error: 	function(XMLHttpRequest, textStatus, errorThrown) {

			jQuery("#newsletter_subscribe span.tooltip_error").remove();
			jQuery("#newsletter_subscribe").append('<span class="tooltip_error">'+_internal_error+'</span>');

		},
		success: function(data) {
			data = data.trim();

			// PHP RETURN: Mandatory Fields
			if(data == '_required_') {

				jQuery("#newsletter_subscribe span.tooltip_error").remove();
				jQuery("#newsletter_subscribe").append('<span class="tooltip_error">'+_email_mandatory+'</span>');

			} else

			// PHP RETURN: INVALID EMAIL
			if(data == '_invalid_email_') {

				jQuery("#newsletter_subscribe span.tooltip_error").remove();
				jQuery("#newsletter_subscribe").append('<span class="tooltip_error">'+_email_invalid+'</span>');

			} else

			// PHP RETURN: INVALID EMAIL
			if(data == '_ok_') {

				// hide tooltips
				jQuery("#newsletter_subscribe span.tooltip_error").remove();
				jQuery("#newsletter_subscribe").append('<span class="tooltip_ok">'+_email_thanks+'</span>');

				// reset form
				jQuery("#newsletter_email").val('');

			} else {

				// PHPMAILER ERROR
				jQuery("#newsletter_subscribe span.tooltip_error").remove();
				alert(data);

			}

		}
	});

	return false;
});