
    function record() {
        var recognition = new webkitSpeechRecognition();
        recognition.lang = "tr-TR";
        recognition.onresult = function (event) {
            console.log(event);
            document.getElementById('speechToText').value = event.results[0][0].transcript;
        }
        recognition.start();
    }
 