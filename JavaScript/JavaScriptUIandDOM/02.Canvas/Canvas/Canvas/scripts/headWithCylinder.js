window.onload = function () {
    var theCanvas = document.getElementById('the-canvas');
    var ctx = theCanvas.getContext('2d');

    ctx.fillStyle = '#90cad7';
    ctx.strokeStyle = '#225560';

    //head
    ctx.beginPath();
    ctx.arc(200, 200, 50, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.save();

    //eyes
    ctx.scale(1, 0.75);
    ctx.beginPath();
    ctx.arc(210, 250, 7, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(170, 250, 7, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.restore();

    //eyeballs
    ctx.save();
    ctx.scale(0.5, 1);
    ctx.beginPath();
    ctx.arc(415, 187, 5, 0, 2 * Math.PI);
    ctx.fillStyle = '#225560';
    ctx.fill();
    ctx.beginPath();
    ctx.arc(335, 187, 5, 0, 2 * Math.PI);
    ctx.fill();
    ctx.restore();

    //nose
    ctx.beginPath();
    ctx.moveTo(191, 187);
    ctx.lineTo(181, 210);
    ctx.lineTo(191, 210);
    ctx.stroke();
    ctx.closePath();
    ctx.restore();
    ctx.save();
    
    //mouth
    ctx.rotate(6 * Math.PI / 180);
    ctx.beginPath();
    ctx.scale(1, 0.35);
    ctx.arc(210, 585, 15, 0, 2 * Math.PI);
    ctx.lineWidth = 3;
    ctx.stroke();
    ctx.restore();

    //cylinder 
    ctx.save();
    ctx.strokeStyle = '#111111';
    ctx.fillStyle = '#396693';
    ctx.scale(1, 0.2);
    ctx.beginPath();
    ctx.arc(195, 750, 55, 0, 2 * Math.PI);
    ctx.lineWidth = 5;
    ctx.stroke();
    ctx.fill();
    ctx.restore();

    ctx.save();
    ctx.strokeStyle = '#111111';
    ctx.fillStyle = '#396693';
    ctx.beginPath();
    ctx.moveTo(165, 103);
    ctx.lineTo(165, 141);
    ctx.quadraticCurveTo(190, 160, 225, 141);
    ctx.lineTo(225, 103);
    ctx.fill();
    ctx.lineWidth = 2;
    ctx.stroke();
    //ctx.fill();
    ctx.restore();

    ctx.save();
    ctx.strokeStyle = '#111111';
    ctx.fillStyle = '#396693';
    ctx.scale(1, 0.4);
    ctx.beginPath();
    ctx.arc(195, 250, 30, 0, 2 * Math.PI);
    ctx.lineWidth = 3;
    ctx.stroke();
    ctx.fill();
    ctx.restore();
}