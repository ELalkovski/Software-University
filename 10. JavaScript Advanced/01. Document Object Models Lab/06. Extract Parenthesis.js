function extract(elementId) {

    let text = document.getElementById(elementId).textContent
    let pattern = /\(.+\)/gm
    let matches = text.match(pattern)
    let result = Array.from(matches)
    return result.join('; ')
}