(function () {
    var theCanvas = document.getElementById('the-canvas');
    var ctx = theCanvas.getContext('2d');

    ctx.fillStyle = '#90cad7';
    ctx.strokeStyle = '#225560';

    function drawCircle(x, y, radius, strtAngle, endAngle) {
        ctx.beginPath();
        ctx.arc(x, y, radius, strtAngle, endAngle);
        ctx.stroke();
    }

    drawCircle(200, 500, 50, 0, 2 * Math.PI);
    ctx.fill();
    drawCircle(400, 500, 50, 0, 2 * Math.PI);
    ctx.fill();

    ctx.beginPath();
    ctx.moveTo(400, 500);
    ctx.lineTo(380, 400);
    ctx.lineTo(420, 370);
    ctx.moveTo(380, 400);
    ctx.lineTo(340, 410);
    ctx.moveTo(200, 500);
    ctx.lineTo(260, 440);
    ctx.lineTo(388, 440);
    ctx.lineTo(300, 500);
    ctx.closePath();
    ctx.stroke();

    //ctx.beginPath();
    drawCircle(300, 500, 15, 0.26 * Math.PI, 0.25 * Math.PI);
    ctx.lineTo(320, 520);
    ctx.stroke();
    drawCircle(300, 500, 15, 1.26 * Math.PI, 1.25 * Math.PI);
    ctx.lineTo(280, 480);
    ctx.stroke();
    ctx.beginPath();
    ctx.moveTo(300, 500);
    ctx.lineTo(240, 410);
    ctx.moveTo(220, 410);
    ctx.lineTo(260, 410);
    
    ctx.stroke();

    //ctx.moveTo(300, 500);
})();