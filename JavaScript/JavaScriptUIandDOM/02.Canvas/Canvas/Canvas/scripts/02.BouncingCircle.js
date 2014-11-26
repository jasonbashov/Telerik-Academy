(function () {
    var theCanvas = document.getElementById('the-canvas');
    var ctx = theCanvas.getContext('2d');
    var circleCoordinates = {
        x: 106,
        y: 106
    };
    var movements = {
        x: 1,
        y: 1
    };
    var radius = 4.8;
    ctx.fillStyle = '975b5b';
    var particles = [];

    var frameRate = 50.0;
    var frameDelay = 1000.0 / frameRate;

    function drowBall(x, y, r, from, to, clock) {
        ctx.beginPath();
        ctx.arc(x, y, r, from, to, clock);
        ctx.stroke();
    }
    //ctx.beginPath();
    //ctx.strokeRect(100, 100, 400, 350);
    //ctx.arc(circleCoordinates.x, circleCoordinates.y, radius, 0, 2 * Math.PI);
    //ctx.fill();
    //ctx.closePath();
    function play_single_sound() {
        document.getElementById('audiotag1').play();
    }

    function randomFloat(min, max) {
        return min + Math.random() * (max - min);
    }

    function Particle() {
        this.scale = 1.0;
        this.x = 0;
        this.y = 0;
        this.radius = 20;
        this.color = "#000";
        this.velocityX = 0;
        this.velocityY = 0;
        this.scaleSpeed = 0.5;

        this.update = function (ms) {
            // shrinking
            this.scale -= this.scaleSpeed * ms / 1000.0;
            if (this.scale <= 0) {
                this.scale = 0;
            }

            // moving away from explosion center
            this.x += this.velocityX * ms / 1000.0;
            this.y += this.velocityY * ms / 1000.0;
        };

        this.draw = function (ctx) {
            // translating the 2D context to the particle coordinates
            ctx.save();
            ctx.translate(this.x, this.y);
            ctx.scale(this.scale, this.scale);

            // drawing a filled circle in the particle's local space
            ctx.beginPath();
            ctx.arc(0, 0, this.radius, 0, Math.PI * 2, true);
            ctx.closePath();

            ctx.fillStyle = this.color;
            ctx.fill();

            ctx.restore();
        };
    }
    function createExplosion(x, y, color) {
        var minSize = 10;
        var maxSize = 30;
        var count = 10;
        var minSpeed = 60.0;
        var maxSpeed = 200.0;
        var minScaleSpeed = 1.0;
        var maxScaleSpeed = 4.0;


        for (var angle = 0; angle < 360; angle += Math.round(360 / count)) {
            var particle = new Particle();

            particle.x = x;
            particle.y = y;

            particle.radius = randomFloat(minSize, maxSize);

            particle.color = color;

            particle.scaleSpeed = randomFloat(minScaleSpeed, maxScaleSpeed);

            var speed = randomFloat(minSpeed, maxSpeed);

            particle.velocityX = speed * Math.cos(angle * Math.PI / 180.0);
            particle.velocityY = speed * Math.sin(angle * Math.PI / 180.0);

            particles.push(particle);
        }
    }

    var up = function (frDelay) {
        ctx.fillStyle = "#FFF";
        ctx.fillRect(0, 0, ctx.canvas.width, ctx.canvas.height);

        // update and draw particles
        for (var i = 0; i < particles.length; i++) {
            var particle = particles[i];

            particle.update(frDelay);
            particle.draw(ctx);
        }
    }
    function update() {
        // draw a white background to clear canvas
        ctx.fillStyle = "#FFF";
        ctx.fillRect(0, 0, ctx.canvas.width, ctx.canvas.height);

        // update and draw particles
        for (var i = 0; i < particles.length; i++) {
            var particle = particles[i];

            particle.update(frameDelay);
            particle.draw(ctx);
        }
    }

	function createBasicExplosion(x, y) {
            // creating 4 particles that scatter at 0, 90, 180 and 270 degrees
            for (var angle = 0; angle < 360; angle += 90) {
                var particle = new Particle();

                // particle will start at explosion center
                particle.x = x;
                particle.y = y;

                particle.color = "#FF0000";

                var speed = 50.0;

                // velocity is rotated by "angle"
                particle.velocityX = speed * Math.cos(angle * Math.PI / 180.0);
                particle.velocityY = speed * Math.sin(angle * Math.PI / 180.0);

                // adding the newly created particle to the "particles" array
                particles.push(particle);
            }
        }
		
    function explode() {
        var x = circleCoordinates.x;
        var y = circleCoordinates.y;

        createExplosion(x, y, "#525252");

        createExplosion(x, y, "#FFA318");
		//createBasicExplosion(x, y);
        //requestAnimationFrame(up(frameDelay));
        //setInterval(function () {
        //   update(frameDelay);
        //   console.log(frameDelay);
        //}, frameDelay);
        //setTimeout(up(frameDelay), 1000)
    }

    function animate() {
        if (circleCoordinates.x <= 0) {
            movements.x = 1;
            explode();
            play_single_sound();
        }
        if (circleCoordinates.y <= 0) {
            movements.y = 1;
            explode();
            play_single_sound();
        }
        if (circleCoordinates.x >= (ctx.canvas.width/2)) {
            movements.x = -1;
            explode();
            play_single_sound();
        }
        if (circleCoordinates.y >= ctx.canvas.height) {
            movements.y = -1;
            explode();
            play_single_sound();
        }
        //delete the old ball
        ctx.beginPath();
        ctx.fillStyle = 'ffffff';
        ctx.arc(circleCoordinates.x, circleCoordinates.y, radius + 1, 0, 2 * Math.PI);
        ctx.fill();
        ctx.closePath();

        //get the new coordinates of the ball
        circleCoordinates.x += movements.x;
        circleCoordinates.y += movements.y;
        ctx.fillStyle = '975b5b';

        //draw the new ball
        ctx.beginPath();
        ctx.arc(circleCoordinates.x, circleCoordinates.y, radius, 0, 2 * Math.PI);
        ctx.fill();
        ctx.closePath();


        requestAnimationFrame(function () {
            update(frameDelay);
            animate();
        });
    }
    requestAnimationFrame(animate);


})();