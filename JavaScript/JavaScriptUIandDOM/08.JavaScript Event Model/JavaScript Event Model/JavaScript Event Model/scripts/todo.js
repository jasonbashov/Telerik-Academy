(function () {
    var contentDiv = document.getElementById("tasks-content"),
        addNewItemButton = document.getElementById('btn-add-item'),
		closeButtonsList = document.getElementsByClassName("btn-close"),
        toggleShowHideBtn = document.getElementById('btn-show-hide');

    addNewItemButton.addEventListener('click', addNewTodo);
    toggleShowHideBtn.addEventListener('click', function (ev) {
        if (this.nextSibling.className === 'hidden') {
            this.nextSibling.className = 'shown';
        } else {
            this.nextSibling.className = 'hidden';
        }
    });

    function getBoxTemplate(content) {
        return ("<div class='colored'>" + "<span class='innerText'>" + content + "</span>" +
            "<a href='#' class='btn-close'>X</a>" +
            "</div>");
    }

    function onRemoveBoxButtonClick() {
        this.parentNode.parentNode.removeChild(this.parentNode);
    }

    function addNewTodo() {
        var i,
            toDoTaskString = document.getElementById('inputArea').value,
            box = getBoxTemplate(toDoTaskString),
            closeButton;

        contentDiv.innerHTML += box;

        for (i = 0, len = closeButtonsList.length; i < len; i += 1) {
            closeButton = closeButtonsList[i];
            closeButton.addEventListener("click", onRemoveBoxButtonClick, false);
        }
    }
}());