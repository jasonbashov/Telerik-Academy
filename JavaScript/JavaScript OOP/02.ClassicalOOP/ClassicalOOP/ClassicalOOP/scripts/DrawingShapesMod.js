var drawingShapesModule = (function () {

    var drawRect = function (canvasContext, positionX, positionY, width, height) {
        canvasContext.fillStyle = getRandomColor();
        canvasContext.strokeStyle = getRandomColor();
        canvasContext.lineWidth = 2;
        canvasContext.fillRect(positionX, positionY, width, height);
        canvasContext.strokeRect(positionX, positionY, width, height);
    }

    var drawCircle = function (canvasContext, centerX, centerY, radius) {
        canvasContext.fillStyle = getRandomColor();
        canvasContext.strokeStyle = getRandomColor();

        canvasContext.beginPath();
        canvasContext.arc(centerX, centerY, radius, 0, 2 * Math.PI);
        canvasContext.fill();
        canvasContext.stroke();
    }

    var drawLine = function (canvasContext, fromX, fromY, toX, toY) {
        canvasContext.strokeStyle = getRandomColor();
        canvasContext.beginPath();
        canvasContext.moveTo(fromX, fromY);
        canvasContext.lineTo(toX, toY);
        canvasContext.stroke();
        canvasContext.closePath();
    }

    function getRandomColor() {
        var rgbColor = '';
        var a = getRandomNumber(0, 255),
            b = getRandomNumber(0, 255),
            c = getRandomNumber(0, 255);
        rgbColor = 'rgb(' + a + ',' + b + ',' + c + ')';

        return rgbColor;
    }

    function getRandomNumber(min, max) {
        var randomNumber = Math.floor(Math.random() * (max - min + 1)) + min;
        return randomNumber;
    }
    
    return {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine : drawLine
    }
})();