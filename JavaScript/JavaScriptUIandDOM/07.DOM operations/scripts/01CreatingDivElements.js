(function () {
    var generateBoxesBtn,
        listFragment = document.createDocumentFragment('div');

    function onGenerateBoxesButtonClick() {
        var contentDiv = document.getElementById("content"),
			count,
			i,
			div;

        while (contentDiv.firstChild) {
            contentDiv.removeChild(contentDiv.firstChild);
        }

        function getRandomNumber(min,max) {
            var randomNumber = Math.floor(Math.random() * (max - min + 1)) + min;
            return randomNumber;
        }

        function getRandomColor() {
            var rgbColor = '';
            var a = getRandomNumber(0, 255),
                b = getRandomNumber(0, 255),
                c = getRandomNumber(0, 255);
            rgbColor = 'rgb(' + a + ',' + b + ',' + c + ')';

            return rgbColor;
        }

        count = (document.getElementById("tb-box-count").value || 5) | 0;

        for (i = 0; i < count; i++) {
            div = document.createElement("div");
            var boxText = document.createElement('strong'),
                height = getRandomNumber(20, 100),
                width = getRandomNumber(20, 100),
                borderWidth = getRandomNumber(1, 20),
                borderRadius = getRandomNumber(0, 100);
            boxText.innerText = 'div';
            div.appendChild(boxText);
            div.setAttribute('style', 'position:absolute; height:' + height + 'px; width:' +
                             width + 'px; border: ' + borderWidth + 'px solid; border-radius:' +
                             borderRadius + 'px; left:' + getRandomNumber(0, 800) + 'px; top:' +
                             getRandomNumber(0, 800) + 'px; border-color:' + 
                             getRandomColor() + '; color:' + getRandomColor());
            div.style.backgroundColor = getRandomColor();
            listFragment.appendChild(div);
        }
        contentDiv.appendChild(listFragment);
    }

    generateBoxesBtn = document.getElementById("btn-generate-boxes");
    generateBoxesBtn.addEventListener("click", onGenerateBoxesButtonClick);
}());