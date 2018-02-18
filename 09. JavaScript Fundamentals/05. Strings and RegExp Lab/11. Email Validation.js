function isEmailValid(email) {
    
    let pattern = /^[a-zA-Z0-9]+@[a-z]{2,}.[a-z]{2,}$/g
    
    if (pattern.test(email)) {
        console.log('Valid')
    } else {
        console.log('Invalid')
    }
}

isEmailValid('valid@email.bg')