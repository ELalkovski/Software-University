function attachAllEvents() {
    // Bind the navigation menu links
    $('#linkHome').click(showHomeView)
    $('#linkLogin').click(showLoginView)
    $('#linkRegister').click(showRegisterView)
    $('#linkLogout').click(logoutUser)
    $('#linkListAds').click(showListAddsView)
    $('#linkCreateAd').click(showCreateAdvertiseView)

    // Bind the form submit buttons
    $('#buttonRegisterUser').click(registerUser)
    $('#buttonLoginUser').click(loginUser)
    $('#buttonCreateAd').click(createAdvertisement)
    $('#buttonEditAd').click(editAdvert)
    // Bind the info / error boxes

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function() { $("#loadingBox").show() },
        ajaxStop: function() { $("#loadingBox").hide() }
    })
}