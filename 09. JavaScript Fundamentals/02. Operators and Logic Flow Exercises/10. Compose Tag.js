function printComposeTag(array){

    let src = array[0]
    let text = array[1]

    console.log(`<img src=\"${src}\" alt=\"${text}\">`)
}

printComposeTag(['smiley.gif', 'Smiley Face'])