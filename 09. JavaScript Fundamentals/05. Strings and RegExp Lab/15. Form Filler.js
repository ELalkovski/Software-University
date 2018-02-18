function replaceTextWithRegex(username, email, phoneNumber, text) {

    let usernamePattern = /<!([a-zA-Z]+)!>/g
    let emailPattern = /<@([a-zA-Z]+)@>/g
    let phoneNumberPattern = /<\+[a-zA-Z]+\+>/g
    let result = []
    let currentLine = ''

    for (let line of text) {
        
        line = line.replace(usernamePattern, username)
        line = line.replace(emailPattern, email)
        line = line.replace(phoneNumberPattern, phoneNumber)
        result.push(line)
    }

    result.forEach(sentence => console.log(sentence))
}

replaceTextWithRegex('Pesho',
'pesho@softuni.bg',
'90-60-90',
['Hello, <!username!>!',
 'Welcome to your Personal profile.',
 'Here you can modify your profile freely.',
 'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
 'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
 'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
)