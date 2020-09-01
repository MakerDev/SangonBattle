window.initializeCarousel = function (carouselId) {
    $('.carousel').carousel({ interval: 2500 })
    $(`#${carouselId}-prev`).click(
        () => $(`#${carouselId}`).carousel('prev'));
    $(`#${carouselId}-next`).click(
        () => $(`#${carouselId}`).carousel('next'));
}