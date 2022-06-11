$(function () {
    $("h4").mouseover(function() {
        $(this).addClass("text-end");
        
    }).mouseout(function() {
        $(this).removeClass("text-end");
    });
});
