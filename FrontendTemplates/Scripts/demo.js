$(function () {
    var headHtml = $("head").html();

    var headHtml = headHtml
        .replace(/^[\s\S]*?<\/title>[\s\S]*?</i, "<") // remove first part of head html content
        .replace(/</g, "&lt;") // escape html tags
        .replace(/>/g, "&gt;")
        .replace(/\n{2,}/g, "\n")
        .replace(/\n/g, "<br/>"); // add line-breaks

    $("blockquote").html(headHtml);
});