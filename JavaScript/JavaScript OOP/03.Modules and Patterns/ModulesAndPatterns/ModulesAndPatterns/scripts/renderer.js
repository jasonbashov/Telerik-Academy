var renderer = (function myfunction() {
    var clearBoard = function (context, gameWidth, gameHeigth) {
        context.clearRect(0, 0, gameWidth, gameHeigth);
    };

    var drawElements = function (context, elements, color) {
        context.fillStyle = color;
        for (var i = 0; i < elements.length; i++) {
            context.fillRect(elements[i].xPosition, elements[i].yPosition, constants.BLOCK_SIZE, constants.BLOCK_SIZE);
        }
    };

    var drawApple = function (context, elements, imgSrc) {
        var img = document.getElementById("apple");
        //var img = new Image();
        //img.src = imgSrc;

        for (var i = 0; i < elements.length; i++) {
            context.drawImage(img, elements[i].xPosition, elements[i].yPosition, constants.BLOCK_SIZE, constants.BLOCK_SIZE);
        }
    }

    return {
        clearBoard: clearBoard,
        drawElements: drawElements,
        drawApple: drawApple
    };
}());