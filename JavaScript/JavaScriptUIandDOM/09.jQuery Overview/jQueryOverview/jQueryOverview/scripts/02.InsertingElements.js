/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\09.jQuery Overview\jQueryOverview\jQueryOverview\libraries/jquery-2.1.1.js" />
(function () {
    var $listItems = $('li'),
        $elementToInsert = $(document.createElement('li')),
        $afterBtn = $('#after').on('click', onNxtBtnClick),
        $beforeBtn = $('#before').on('click', onPrevBtnClick),
        insertAfter = false;

    alert('Click on the element on which you want to insert before/after the new element');
    $elementToInsert.html('InsertedElement');
    $listItems.on('click', insertElement);

    function insertElement() {
        if (insertAfter) {
            //$(this).append($elementToInsert);
            $(this).after($elementToInsert);
        }
        else {
            $(this).before($elementToInsert);
        }
    }

    function onPrevBtnClick() {
        insertAfter = false;
    }
    function onNxtBtnClick() {
        insertAfter = true;
    }
}());