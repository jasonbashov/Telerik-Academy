/*
(function () {
    var canvas = document.getElementById("marioAnimation");
    var marioImage = new Image();

    marioImage.src = "images/mario.png";
    function sprite(options) {

        var that = {},
            frameIndex = 0,
            tickCount = 0,
            ticksPerFrame = ticksPerFrame || 0;
            numberOfFrames = options.numberOfFrames || 1;

        that.context = options.context;
        that.width = options.width;
        that.height = options.height;
        that.image = options.image;
        that.render = function () {

            // Draw the animation
            that.context.drawImage(
               that.image,
               frameIndex * that.width / numberOfFrames,
               0,
               that.width / numberOfFrames,
               that.height,
               0,
               0,
               that.width / numberOfFrames,
               that.height);
        };
        that.loop = options.loop;

        that.update = function () {

            tickCount += 1;

            if (tickCount > ticksPerFrame) {

                tickCount = 0;

                // If the current frame index is in range
                if (frameIndex < numberOfFrames - 1) {
                    // Go to the next frame
                    frameIndex += 1;
                } else if (that.loop) {
                    frameIndex = 0;
                }
            }
        };
        return that;
    }



    var mario = sprite({
        width: 45,
        height: 16,
        image: marioImage,
        numberOfFrames: 3,
        ticksPerFrame: 4
    });
    function gameLoop() {

        window.requestAnimationFrame(gameLoop, 1000);

        mario.update();
        mario.render();
    }
    gameLoop();
    // Start the game loop as soon as the sprite sheet is loaded
    //marioImage.addEventListener("load", gameLoop);
})();*/
(function () {
    function animateSprite(spriteSource, canvasId, canvasX, canvasY) {
        var mario,
            marioImage,
            canvas;

        function gameLoop() {

            window.requestAnimationFrame(gameLoop);

            mario.update();
            mario.render();
        }

        function sprite(options) {

            var that = {},
                frameIndex = 0,
                tickCount = 0,
                ticksPerFrame = options.ticksPerFrame || 0,
                numberOfFrames = options.numberOfFrames || 1;

            that.context = options.context;
            that.width = options.width;
            that.height = options.height;
            that.image = options.image;

            that.update = function () {

                tickCount += 1;

                if (tickCount > ticksPerFrame) {

                    tickCount = 0;

                    // If the current frame index is in range
                    if (frameIndex < numberOfFrames - 1) {
                        // Go to the next frame
                        frameIndex += 1;
                    } else {
                        frameIndex = 0;
                    }
                }
            };

            that.render = function () {

                // Clear the canvas
                that.context.clearRect(0, 0, that.width, that.height);

                // Draw the animation
                that.context.drawImage(
                  that.image,
                  frameIndex * that.width / numberOfFrames,
                  0,
                  that.width / numberOfFrames,
                  that.height,
                  canvasX,
                  canvasY,
                  that.width / numberOfFrames,
                  that.height);
            };

            return that;
        }

        // Get canvas
        canvas = document.getElementById(canvasId);
        canvas.width = 500;
        canvas.height = 100;

        // Create sprite sheet
        marioImage = new Image();

        // Create sprite
        mario = sprite({
            context: canvas.getContext("2d"),
            width: 192,
            height: 64,
            image: marioImage,
            numberOfFrames: 3,
            ticksPerFrame: 8
        });

        // Load sprite sheet
        marioImage.addEventListener("load", gameLoop);
        marioImage.src = spriteSource;
    }

    animateSprite("images/mario.png","marioAnimation", 0, 0);
    animateSprite("images/mario3.png","marioAnimation2", 70, 0);
}());