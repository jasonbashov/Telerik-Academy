(function () {
    function onChangeColorBtnClick() {
        var inputColorFont = document.getElementById('fontChange').value,
            inputColorBackground = document.getElementById('bckgroundChange').value,
            txtArea = document.getElementById('txt-area');


        txtArea.setAttribute('style', 'color:' + inputColorFont + '; background-color: ' + inputColorBackground);
        console.log(inputColorFont);
        console.log(inputColorBackground);
    }


    var changeColorBtn = document.getElementById("btn-change-colors");
    changeColorBtn.addEventListener("click", onChangeColorBtnClick);
}());