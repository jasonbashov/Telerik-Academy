(function () {
    var generateBoxesBtn,
        angle = 0,
        radius = 100,
        dd = 3,
        listFragment = document.createDocumentFragment('div'),
        initialX = getRandomNumber(100, 600),
        initialY = getRandomNumber(100, 500);

    function onGenerateBoxesButtonClick() {
        var contentDiv = document.getElementById("content"),
			count = 5,
			i,
			div;

        while (contentDiv.firstChild) {
            contentDiv.removeChild(contentDiv.firstChild);
        }

        function getRandomColor() {
            var rgbColor = '';
            var a = getRandomNumber(0, 255),
                b = getRandomNumber(0, 255),
                c = getRandomNumber(0, 255);
            rgbColor = 'rgb(' + a + ',' + b + ',' + c + ')';

            return rgbColor;
        }

        for (i = 0; i < count; i++) {
            div = document.createElement("div");
            var x = initialX + radius * Math.cos(angle),
                y = initialY + radius * Math.sin(angle);

            // increase the angle of rotation
            angle += Math.acos(1 - Math.pow(dd / radius, 2) / 2);
            div.className = "colored";
            div.setAttribute('style', 'left:' + x + 'px; top:' + y + 'px;');
			//console.log(div);
            div.style.backgroundColor = getRandomColor();
            listFragment.appendChild(div);
        }
        contentDiv.appendChild(listFragment);

        requestAnimationFrame(onGenerateBoxesButtonClick, 100);
    }

    function getRandomNumber(min, max) {
        var randomNumber = Math.floor(Math.random() * (max - min + 1)) + min;
        return randomNumber;
    }

    generateBoxesBtn = document.getElementById("btn-generate-boxes");
    generateBoxesBtn.addEventListener("click", onGenerateBoxesButtonClick);
}());