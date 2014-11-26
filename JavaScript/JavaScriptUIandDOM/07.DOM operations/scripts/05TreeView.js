(function () {
    var mainListItemsBtns = document.getElementsByClassName("mainTree");
    for (var i = 0, len = mainListItemsBtns.length; i < len; i++) {
        mainListItemsBtns[i].addEventListener("click", function (ev) {
            //var children = this.childNodes;
            //console.log(this.nextSibling);
			console.log(ev.target);
            if (this.nextSibling.className === 'selected') {
                this.nextSibling.className = '1stLevel';
            } else {
                this.nextSibling.className = 'selected';
            }
        });
    }
}());