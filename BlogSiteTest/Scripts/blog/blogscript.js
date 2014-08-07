$(document).ready(function () {
    $('#blogposts').load('/blog/getblogposts');

});

var authorname = "";
var loadblogs = function () {
    $('#blogposts').load('/blog/getblogposts?author=' + authorname);
}

$('#author-filter').on('input', function () {
    authorname = $('#author-filter').val();

    $('#blogposts').load('/blog/getblogposts?author=' + authorname);

});

// Reload the blog posts every few seconds
setInterval(loadblogs, 2500);