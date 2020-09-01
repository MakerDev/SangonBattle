window.initializeCarousel = function (carouselId) {
    $('.carousel').carousel({ interval: 2500 })
    $(`#${carouselId}-prev`).click(
        () => $(`#${carouselId}`).carousel('prev'));
    $(`#${carouselId}-next`).click(
        () => $(`#${carouselId}`).carousel('next'));
}

window.PlaySound = function() {
    let audio = document.getElementById('ggang_sound');

    if (audio != null) {
        let audioSource = document.getElementById('ggang_sound_source');

        if (audioSource != null) {
            audio.load();
            audio.play();
        }
    }
}