$(document).ready(function () {
    //$(".dropdown").hover(
    //    function () {
    //        $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true, true).slideDown("400");
    //        $(this).toggleClass('open');
    //    },
    //    function () {
    //        $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true, true).slideUp("400");
    //        $(this).toggleClass('open');
    //    }
    //);

    $('ul.nav li.dropdown').hover(function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeIn(500);
    }, function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(200).fadeOut(500);
    });
});