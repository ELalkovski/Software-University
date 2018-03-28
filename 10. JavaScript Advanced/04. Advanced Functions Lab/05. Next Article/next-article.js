function getArticleGenerator(articles) {
    
    let closure = function () {
        let insideArticles = articles
        if (insideArticles.length > 0) {
            $('#content').append($('<article>').text(insideArticles.splice(0, 1)))
        }
    }
    
    return closure
}