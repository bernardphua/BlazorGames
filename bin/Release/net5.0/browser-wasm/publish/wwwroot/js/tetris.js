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