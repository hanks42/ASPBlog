$(document).ready(function () {
    $('#blogposts').load('/blog/getblogposts');
});

// Reload the blog posts ever second
setInterval("$('#blogposts').load('/blog/getblogposts')", 1000);