function getUsernames(array) {
    
    let usernames = []
    
    for (const email of array) {

        let [alias, domain] = email.split('@')
        let username = alias + '.'
        let domainTokens = domain.split('.')
        domainTokens.forEach(p => username += p[0]);
        usernames.push(username)
    }

    console.log(usernames.join(', '))
}

getUsernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com'])