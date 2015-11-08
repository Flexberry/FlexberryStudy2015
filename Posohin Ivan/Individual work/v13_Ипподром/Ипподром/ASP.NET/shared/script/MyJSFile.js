(function hideContent() {
    if (window.location.pathname == "/Default.aspx" || window.location.pathname == "/") {
        $("#pageContent").css("display", "block");
    }
})();

$('.icons').easyAudioEffects({
    ogg: "http://localhost:6500/Sound/igogo.ogg",
    mp3: "http://localhost:6500/Sound/igogo.ogg",
   eventType : "hover",
   playType : "oneShotMonophonic"
});