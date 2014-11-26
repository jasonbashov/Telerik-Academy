(function () {
    var theCanvas = document.getElementById('the-canvas');
    var ctx = theCanvas.getContext('2d');

    ctx.fillStyle = '#975b5b';
    ctx.strokeStyle = '#000000';
    ctx.lineWidth = 2;
ctx.lineJoin = 'round';
    ctx.fillRect(400, 150, 350, 210);
    ctx.strokeRect(400, 150, 350, 210);

    //roof
    ctx.beginPath();
    ctx.moveTo(400, 150);
    ctx.lineTo(575, 20);
    ctx.lineTo(750, 150);
    ctx.closePath();
    ctx.fill();
    ctx.stroke();

    //chimney
    ctx.strokeRect(650, 40, 30, 79);
    ctx.fillRect(650, 40, 30, 80);
    ctx.closePath();

    ctx.save();

    ctx.scale(1, 0.2);
    ctx.beginPath();
    ctx.lineWidth = 3;
    ctx.arc(665, 200, 15, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.fill();
    ctx.restore();

    //the windows
    ctx.fillStyle = '000000';
    ctx.fillRect(435, 170, 50, 30);
    ctx.fillRect(487, 170, 50, 30);
    ctx.fillRect(435, 202, 50, 30);
    ctx.fillRect(487, 202, 50, 30);

    ctx.fillRect(605, 170, 50, 30);
    ctx.fillRect(657, 170, 50, 30);
    ctx.fillRect(605, 202, 50, 30);
    ctx.fillRect(657, 202, 50, 30);

    ctx.fillRect(605, 260, 50, 30);
    ctx.fillRect(657, 260, 50, 30);
    ctx.fillRect(605, 292, 50, 30);
    ctx.fillRect(657, 292, 50, 30);

    //the door
    ctx.beginPath();
    ctx.moveTo(486, 360);
    ctx.lineTo(486, 265);
    ctx.stroke();
    ctx.closePath();
    ctx.beginPath();
    ctx.arc(475, 320, 5, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath();
    ctx.beginPath();
    ctx.arc(495, 320, 5, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath();
    ctx.beginPath();
    ctx.moveTo(525, 360);
    ctx.lineTo(525, 280);
    ctx.stroke();
    ctx.closePath();
    ctx.beginPath();
    ctx.moveTo(447, 360);
    ctx.lineTo(447, 280);
    ctx.quadraticCurveTo(486, 250, 525, 280);
    ctx.stroke();
})();