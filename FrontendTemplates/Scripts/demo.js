;$(function () {
    var headHtml = $("head").html();

    var headHtml = headHtml
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/\n/g, "<br/>");

    $("blockquote").html(headHtml);
});

