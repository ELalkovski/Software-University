function attachEvents() {
    const postsUrl = 'https://baas.kinvey.com/appdata/kid_Hybs_7ScM/posts'

    $('#btnLoadPosts').click(loadPosts)
    $('#btnViewPost').click(getPost)

    function loadPosts() {
        $.ajax({
            url: postsUrl,
            headers: {
                'Authorization': 'Basic ' + btoa('peter:p')
            },
            success: populatePostsSelector
        })

        function populatePostsSelector(data) {
            $('#posts').empty()

            for (const entry of data) {
                let currentOption = $('<option>').attr('value', `${entry._id}`).text(`${entry.title}`)
                $('#posts').append(currentOption)
            }
        }
    }

    function getPost() {
        let selectedPost = $('#posts option:selected')
        
        $.ajax({
            url: postsUrl + '/' + selectedPost.attr('value'),
            headers: {
                'Authorization': 'Basic ' + btoa('peter:p')
            },
            success: displayPostInfo 
        })

        $.ajax({
            url: `https://baas.kinvey.com/appdata/kid_Hybs_7ScM/comments/?query={"post_id":"${selectedPost.attr('value')}"}`,
            headers: {
                'Authorization': 'Basic ' + btoa('peter:p')
            },
            success: displayPostComments 
        })

        function displayPostInfo(post) {
            $('#post-title').text(post.title)
            $('#post-body').text(post.body)
        }

        function displayPostComments(comments) {
            $('#post-comments').empty()
            for (const comment of comments) {
                let currentElement = $('<li>').text(comment.text)
                $('#post-comments').append(currentElement)
            }
        }
    }
}