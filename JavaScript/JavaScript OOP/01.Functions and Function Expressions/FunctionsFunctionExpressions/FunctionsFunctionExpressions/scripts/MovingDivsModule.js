/// <reference path="D:\Telerik\JavaScript\JavaScript OOP\homework\01.Functions and Function Expressions\FunctionsFunctionExpressions\FunctionsFunctionExpressions\libraries/jquery-2.1.1.js" />
var movingShahpesModule = (function () {
    var container = $('#content');
    //var initialX = getRandomNumber(100, 900);
    //var initialY = getRandomNumber(100, 600);
    var ellipseElementsArr = [];
    var rectElementsArr = [];

    var add = function (movementType) {
        var type = movementType || 'ellipse';

        switch (type) {
            case 'ellipse':
                var divElement = createDivElement('ellipse');
                var currElementInitialX = $(divElement).css('left');
                var currElementInitialY = $(divElement).css('top');
                currElementInitialX = parseInt(currElementInitialX.slice(0, currElementInitialX.indexOf('px')));
                currElementInitialY = parseInt(currElementInitialY.slice(0, currElementInitialY.indexOf('px')));
                ellipseElementsArr.push({
                    element: divElement,
                    initailCoordinates: { x: currElementInitialX, y: currElementInitialY }
                });
                container.append(divElement.cloneNode(true));
                break;
            case 'rect':
                divElement = createDivElement('rect');
                currElementInitialX = $(divElement).css('left');
                currElementInitialY = $(divElement).css('top');
                currElementInitialX = parseInt(currElementInitialX.slice(0, currElementInitialX.indexOf('px')));
                currElementInitialY = parseInt(currElementInitialY.slice(0, currElementInitialY.indexOf('px')));
                rectElementsArr.push({
                    element: divElement,
                    initailCoordinates: { x: currElementInitialX, y: currElementInitialY }
                });
                container.append(divElement.cloneNode(true));
                break;
            default:
        }

        animateEllipseElements();
        animateRectElements();
    }

    function animateRectElements() {
        clearInterval();
        var rectElements = $('.rectClass');
        var direction = 0;
        var elementsCenterXCoordinatesArr = [];
        var elementsCenterYCoordinatesArr = [];

        //first we get all original coordinates of the elements so they are not changed during the animation
        for (var i = 0, len = rectElements.length; i < len; i++) {
            elementsCenterXCoordinatesArr.push(rectElementsArr[i].initailCoordinates.x);
            elementsCenterYCoordinatesArr.push(rectElementsArr[i].initailCoordinates.y);
        }

        var functionTimer = setInterval(function moveDivs() {

            for (var i = 0, len = rectElements.length; i < len; i++) {
                var currDiv = rectElements[i];

                if (direction > 3) {
                    direction = 0;
                }

                switch (direction) {
                    case 0: elementsCenterXCoordinatesArr[i] += 5;
                        if (elementsCenterXCoordinatesArr[i] > rectElementsArr[i].initailCoordinates.x + 300) {
                            direction++;
                        }
                        break;
                    case 1: elementsCenterYCoordinatesArr[i] += 5;
                        if (elementsCenterYCoordinatesArr[i] > rectElementsArr[i].initailCoordinates.y + 300) {
                            direction++;
                        }
                        break;
                    case 2: elementsCenterXCoordinatesArr[i] -= 5;
                        if (elementsCenterXCoordinatesArr[i] < rectElementsArr[i].initailCoordinates.x) {
                            direction++;
                        }
                        break;
                    case 3: elementsCenterYCoordinatesArr[i] -= 5;
                        if (elementsCenterYCoordinatesArr[i] < rectElementsArr[i].initailCoordinates.y) {
                            direction++;
                        }
                        break;
                }

                currDiv.style.left = elementsCenterXCoordinatesArr[i] + 'px';
                currDiv.style.top = elementsCenterYCoordinatesArr[i] + 'px';
            }
        }, 10);
    }

    function animateEllipseElements() {
        clearInterval();
        var ellipseElements = $('.ellipseClass');
        var radius = 100;
        var angle = 0;

        var functionTimer = setInterval(function moveDivs() {
            angle++;

            if (angle === 360) {
                angle = 0;
            }

            for (var j = 0, len = ellipseElements.length; j < len; j++) {
                var left = ellipseElementsArr[j].initailCoordinates.x + Math.cos((2 * 3.14 / 180) * (angle)) * radius;
                var right = ellipseElementsArr[j].initailCoordinates.y + Math.sin((2 * 3.14 / 180) * (angle)) * radius;

                var currDiv = ellipseElements[j];
                currDiv.style.left = left + 'px';
                currDiv.style.top = right + 'px';
            }
        }, 10);
    }

    var createDivElement = function (elementType) {
        var div = document.createElement("div"),
        initialElementX = getRandomNumber(100, 800),
        initialElementY = getRandomNumber(100, 400);

        borderColor = getRandomColor();
        div.className = elementType + 'Class';
        div.style.backgroundColor = getRandomColor();
        div.style.width = '75px';
        div.style.height = '75px';
        div.style.borderRadius = '5px';
        div.style.borderStyle = 'solid';
        div.style.borderColor = borderColor;
        div.style.position = 'absolute';
        div.style.top = initialElementX.toString() + 'px';
        div.style.left = initialElementY.toString() + 'px';

        var divToReturn = div.cloneNode(true);
        return divToReturn;
    }

    function getRandomNumber(min, max) {
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
    return {
        add: add
    };
})();