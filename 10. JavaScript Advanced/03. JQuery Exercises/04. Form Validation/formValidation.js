function validate() {
    let usernameValidation = /[a-zA-Z0-9]{3,20}/g
    let passwordValidation = /[a-zA-Z0-9_]{5,15}/g
    let emailValidation = /.+@[^.]*\.{1,}.*/g
    let username = $('#username')
    let password= $('#password')
    let confirmPassword = $('#confirm-password')
    let email = $('#email')
    let isValid = false

    $('#submit').click(function (event) {

        event.preventDefault()

        if (!usernameValidation.test(username.val())) {
            username.css('border-color', 'red')          
        } else {
            username.removeAttr('style')
            console.log(usernameValidation.test(username.val()) + ' im in else username')
        }
        if (!emailValidation.test(email.val())) {
            email.css('border-color', 'red')
        } else {
            email.removeAttr('style')
            console.log(emailValidation.test(email.val()) + ' im in else email')
        }
        if (!passwordValidation.test(password.val())) {
            password.css('border-color', 'red')
        } else {
            password.removeAttr('style')
        }
        if (!passwordValidation.test(confirmPassword.val())) {
            confirmPassword.css('border-color', 'red')  
        } else {
            confirmPassword.removeAttr('style')
        }
        if (password.val() !== confirmPassword.val()) {
            password.css('border-color', 'red')
            confirmPassword.css('border-color', 'red') 
        } else {
            password.removeAttr('style')
            confirmPassword.removeAttr('style')
        }

        if ($('#company').prop('checked')) {
            if (Number($('#companyNumber').val()) < 1000 || Number($('#companyNumber').val()) > 9999) {
                $('#companyNumber').css('border-color', 'red')
            } else {
                $('#companyNumber').removeAttr('style')
            }
        }

        if (isValid) {
            $('#valid').css('display', 'block')
        } else {
            $('#valid').css('display', 'none')
        }
    })
    
    $('#company').change(function () {
        if ($(this).prop('checked')) {
            $('#companyInfo').removeAttr('style')
        } else {
            $('#companyInfo').css('display', 'none')
            $('#companyNumber').val('')
        }
    })
}
