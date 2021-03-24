export function PlayAudio(audioId, audioSourceId, src) {
    var audio = document.getElementById(audioId);
    if (audio != null) {
        var audioSource = document.getElementById(audioSourceId);
        if (audioSource != null) {
            audioSource.src = src;
            audio.load();
            audio.play();
        }
    }
}

export function StopAudio(audioId) {
    var audio = document.getElementById(audioId);
    if (audio != null) {
        audio.pause();
        audio.currentTime = 0;
    }
}

export function GetWindowInnerWidth() {
    return window.innerWidth;
}

export function GetWindowInnerHeight() {
    return window.innerHeight;
}

export function SetCanvasDimension(id, x, y) {
    var cvs = document.getElementById(id);
    cvs.width = x;
    cvs.height = y;
}

let dotNet;
export function StartGame(DotNetInstance) {
    dotNet = DotNetInstance;
    Animate();
}

let animationId;
function Animate() {
    animationId = requestAnimationFrame(Animate);
    dotNet.invokeMethodAsync("GameLoop", animationId);
}

export function StopAnimation(animationId){
    cancelAnimationFrame(animationId);
}

