	// @CONTACT FORM - TRANSLATE OR EDIT
	_email_name				= 'Name is Required!',
	_email_required			= 'Email is Required!',
	_email_message			= 'Message is Required!',
	_email_all				= 'Please complete all fields!',
	_email_invalid			= 'Invalid Email!',
	_email_sent				= 'Thank You!';


/**	CONTACT FORM
*************************************************** **/
	jQuery("#contact_submit").bind("click", function(e) {
		e.preventDefault();

		var contact_name 	= jQuery("#contact_name").val(),			// required
			contact_email 	= jQuery("#contact_email").val(),			// required
			contact_message = jQuery("#contact_message").val(),			// required
			_action			= jQuery("#contactForm").attr('action'),	// form action URL
			_method			= jQuery("#contactForm").attr('method'),	// form method
			_err			= false;									// status

		// Remove error tooltips
		jQuery("#contactForm span.tooltip_error").remove();


		// Name Check
		if(contact_name == '') {
			jQuery("#tooltip_contact_name").append('<span class="tooltip_error tooltip-right">'+_email_name+'</span>');
			return false;
		}

		// Email Check
		if(contact_email == '') {
			jQuery("#tooltip_email").append('<span class="tooltip_error tooltip-right">'+_email_required+'</span>');
			return false;
		}

		// Comment Check
		if(contact_message == '') {
			jQuery("#tooltip_message").append('<span class="tooltip_error tooltip-right">'+_email_message+'</span>');
			return false;
		}


		// SEND MAIL VIA AJAX
		$.ajax({
			url: 	_action,
			data: 	{ajax:"true", action:'email_send', contact_name:contact_name, contact_email:contact_email, contact_message:contact_message},
			type: 	_method,
			error: 	function(XMLHttpRequest, textStatus, errorThrown) {

				alert('Server Internal Error'); // usualy on headers 404

			},

			success: function(data) {
				data = data.trim(); // remove output spaces


				// PHP RETURN: Mandatory Fields
				if(data == '_required_') {
					jQuery("#tooltip_email").append('<span class="tooltip_error tooltip-right">'+_email_all+'</span>');
				} else

				// PHP RETURN: INVALID EMAIL
				if(data == '_invalid_email_') {
					jQuery("#tooltip_email").append('<span class="tooltip_error tooltip-right">'+_email_invalid+'</span>');
				} else

				// VALID EMAIL
				if(data == '_sent_ok_') {

					// append message and show ok alert
					jQuery("#tooltip_message").append('<span class="tooltip_ok tooltip-right">'+_email_sent+'</span>');

					// reset form
					jQuery("#contact_name, #contact_email, #contact_message").val('');

				} else {

					// PHPMAILER ERROR
					alert(data); 

				}
			}
		});

	});
