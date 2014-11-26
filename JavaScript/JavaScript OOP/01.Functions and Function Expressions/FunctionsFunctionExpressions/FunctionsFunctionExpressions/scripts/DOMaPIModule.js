/// <reference path="D:\Telerik\JavaScript\JavaScript OOP\homework\01.Functions and Function Expressions\FunctionsFunctionExpressions\FunctionsFunctionExpressions\libraries/jquery-2.1.1.js" />
var domModule = function () {
    var buffer;
    var appendChild = function (childElement, parentElementId) {
        var parentElement = $(parentElementId);
        parentElement.append(childElement);
    }

    var removeChild = function (parentElement, elementToDelete) {
        var $parentElement = $(parentElement);
        $parentElement.find(elementToDelete).remove();
    }

    var addHandler = function (elemementToAddEvent, eventType, eventFunction) {
        var elementToAddHandler = $(elemementToAddEvent);
        elementToAddHandler.on(eventType, eventFunction);
    }

    var getElementByCSSSelector = function (selector) {
        return $(selector).get();
    };

    var appendToBuffer = function (selector, element) {
        if (buffer instanceof Buffer) {
            var addNewSelectorToTheBuffer = true;
            for (var j = 0, len = buffer.list.length; j < len; j++) {
                //first we check if the given selector already exists in the buffer
                if (selector === buffer.list[j].selector) {
                    addNewSelectorToTheBuffer = false;
                    //now we check if the given selector elements count is greater than 100
                    if (buffer.list[j].elementsArr.length < 100) {
                        buffer.list[j].elementsArr.push(element);
                    } else {
                        //if the elements count is greater than 100 we append the elements to the dom and clear the buffer from the selector
                        appendElementsToDom(selector, buffer.list[j].elementsArr);
                        buffer.list[j].elementsArr = [];
                        console.log(buffer);
                    }
                }
            }
            if (addNewSelectorToTheBuffer) {
                buffer.list.push({
                    selector: selector,
                    elementsArr: [element]
                });
            }
        } else {
            buffer = new Buffer(selector, element);
        }
    }

    var Buffer = (function () {

        function Buffer(selector, element) {
            this.list = [{
                selector : selector,
                elementsArr: [element]
            }];
        }

        return Buffer;
    }());

    function appendElementsToDom(selector, elements) {
        var fragment = document.createDocumentFragment();
        for (var h = 0, len = elements.length; h < len; h++) {
            fragment.appendChild(elements[h]);
        }
        $(selector).append(fragment);
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        getElementByCSSSelector: getElementByCSSSelector
    }
}