const videoIframe = document.getElementById('video');
const fullscreenButton = document.getElementById('fullscreenButton');

fullscreenButton.addEventListener('click', () => {
    if (videoIframe.requestFullscreen) {
        videoIframe.requestFullscreen();
    } else if (videoIframe.mozRequestFullScreen) {
        videoIframe.mozRequestFullScreen();
    } else if (videoIframe.webkitRequestFullscreen) {
        videoIframe.webkitRequestFullscreen();
    } else if (videoIframe.msRequestFullscreen) {
        videoIframe.msRequestFullscreen();
    }
});