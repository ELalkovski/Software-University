function getUniqueUsernames(array) {

    let usernames = new Set()

    array.forEach(username => {
        usernames.add(username)
    });

    let sortedUsernames = Array.from(usernames.keys()).sort((a, b) => {

        let result = a.length - b.length

        if (result === 0) {
            return a.localeCompare(b)
        }

        return result
    })
    
    sortedUsernames.forEach(u => console.log(u))
}

getUniqueUsernames(['Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
    ])