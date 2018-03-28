function validateRequest(obj) {

    const availableMethods = ['GET', 'POST', 'DELETE', 'CONNECT']
    const availableVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0']
    let uriPattern = /([A-Za-z0-9.]+\.)(?=[A-Za-z0-9]+[\.]*)/g
    let messagePattern = /^[^<>\\&'"]*$/g
    
    if (!obj.hasOwnProperty('method') || !availableMethods.includes(obj['method'])) {
        throw new Error('Invalid request header: Invalid Method')
    }

    if (!obj.hasOwnProperty('uri') || !uriPattern.test(obj['uri'])) {
        throw new Error('Invalid request header: Invalid URI')
    }

    if (!obj.hasOwnProperty('version') || !availableVersions.includes(obj['version'])) {
        throw new Error('Invalid request header: Invalid Version')
    }

    if (!obj.hasOwnProperty('message') || !messagePattern.test(obj['message'])) {
        throw new Error('Invalid request header: Invalid Message')
    }

    return obj
}

console.log(validateRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: 'asl<pls'
}))