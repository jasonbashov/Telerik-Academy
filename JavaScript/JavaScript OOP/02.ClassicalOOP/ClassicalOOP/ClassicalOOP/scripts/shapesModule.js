var Shapes = (function () {
    var Shape = (function () {
        function Shape(canvasCtx, x, y) {
            this._canvasCtx = canvasCtx;
            this._x = x;
            this._y = y;
        }

        return Shape;
    }());


    var Rect = (function () {
        function Rect(canvasCtx, x, y, width, height) {
            Shape.call(this, canvasCtx, x, y);
            this._width = width;
            this._height = height;
        }

        Rect.prototype = new Shape();

        Rect.prototype.draw = function () {
            this._canvasCtx.fillStyle = getRandomColor();
            this._canvasCtx.strokeStyle = getRandomColor();
            this._canvasCtx.lineWidth = 2;
            this._canvasCtx.fillRect(this._x, this._y, this._width, this._height);
            this._canvasCtx.strokeRect(this._x, this._y, this._width, this._height);
        };

        return Rect;
    }());

    var Circle = (function () {
        function Circle(canvasContext, centerX, centerY, radius) {
            Shape.call(this, canvasContext, centerX, centerY);
            this._radius = radius;
        }

        Circle.prototype = new Shape();

        Circle.prototype.draw = function () {
            this._canvasCtx.fillStyle = getRandomColor();
            this._canvasCtx.strokeStyle = getRandomColor();
            this._canvasCtx.beginPath();
            this._canvasCtx.arc(this._x, this._y, this._radius, 0, 2 * Math.PI);
            this._canvasCtx.fill();
            this._canvasCtx.stroke();
        }

        return Circle;
    }());

    var Line = (function () {
        function Line(canvasContext, fromX, fromY, toX, toY) {
            Shape.call(this, canvasContext, fromX, fromY);
            this._toX = toX;
            this._toY = toY;
        }

        Line.prototype = new Shape();
        Line.prototype.draw = function () {
            this._canvasCtx.strokeStyle = getRandomColor();
            this._canvasCtx.beginPath();
            this._canvasCtx.moveTo(this._x, this._y);
            this._canvasCtx.lineTo(this._toX, this._toY);
            this._canvasCtx.stroke();
            this._canvasCtx.closePath();

        }


        return Line;
    }());

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
        Shape: Shape,
        Rect: Rect,
        Circle: Circle,
        Line : Line
    };

}());