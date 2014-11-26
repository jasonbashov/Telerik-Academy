var gameEngine = (function () {
    var gameCanvas = document.getElementById('the-canvas');
    var context = gameCanvas.getContext('2d');
    var gameWidth = gameCanvas.clientWidth;
    var gameHeigth = gameCanvas.clientHeight;
    var gameLoopControl;
    var gameScore;

    var startGame = function () {
        context.clearRect(0, 0, gameWidth, gameHeigth);
        var playerWorm = new gameObjects.Worm(6, 40, 20);
        var wormBody = playerWorm.getWormBody();

        

        keyboardControlWorm(playerWorm);
        gameScore = 0;
        var gameElements = [];
        gameElements['worm'] = playerWorm;
        gameElements['apples'] = [];

        for (var i = 0; i < constants.NUMBER_OF_APPLES; i++) {
            gameElements['apples'].push(gameObjects.generateApple(gameWidth, gameHeigth));
        }

        clearInterval(gameLoopControl);
        gameLoopControl = setInterval(function () {

            

            renderer.clearBoard(context, gameWidth, gameHeigth);
            renderer.drawElements(context, [playerWorm.head], 'pink');
            renderer.drawElements(context, wormBody, 'purple');
            renderer.drawApple(context, gameElements['apples']);
            playerWorm.move();
            detectCollision(gameElements);
        }, 100);
    };

    
    //var generateApple = function () {
    //    var appleXPosition = Math.round((Math.random() * gameWidth - constants.BLOCK_SIZE) / constants.BLOCK_SIZE) * constants.BLOCK_SIZE;
    //    var appleYPosition = Math.round((Math.random() * gameWidth - constants.BLOCK_SIZE) / constants.BLOCK_SIZE) * constants.BLOCK_SIZE;
    //    return new gameObjects.GameBlock(appleXPosition, appleYPosition);
    //};
    var detectCollision = function (gameElements) {
        var wormHead = gameElements['worm'].head;
        var wormBody = gameElements['worm'].getWormBody();
        var apples = gameElements['apples'];
        var hitVerticalWall = (wormHead.xPosition < 0 || wormHead.xPosition > gameWidth);
        var hitHorizontalWall = (wormHead.yPosition < 0 || wormHead.yPosition > gameHeigth);
        if (hitVerticalWall || hitHorizontalWall) {
            endGame();
            return;
        }

        for (i = 0; i < wormBody.length; i++) {
            if (wormHead.xPosition === wormBody[i].xPosition && wormHead.yPosition === wormBody[i].yPosition) {
                endGame();
                return;
            }
        }

        for (var i = 0; i < apples.length; i++) {
            //dali qdem
            if (apples[i].xPosition === wormHead.xPosition && apples[i].yPosition === wormHead.yPosition) {
                var newTailX = wormBody[wormBody.length - 1].xPosition * 2 - wormBody[wormBody.length - 2].xPosition;
                var newTailY = wormBody[wormBody.length - 1].yPosition * 2 - wormBody[wormBody.length - 2].yPosition;
                wormBody.push(new gameObjects.GameBlock(newTailX, newTailY));
                apples.splice(i, 1);
                apples.push(gameObjects.generateApple(gameWidth, gameHeigth));
                gameScore += 100;
            }
        }
    };

    var keyboardControlWorm = function (worm) {
        document.onkeydown = function (event) {
            event = event || window.event;
            switch (event.keyCode) {
                // left
                case 37:
                    if (worm.direction.x !== 1 && worm.direction.y !== 0) {
                        worm.direction.x = -1;
                        worm.direction.y = 0;
                    }
                    break;
                    // up
                case 38:
                    if (worm.direction.x !== 0 && worm.direction.y !== 1) {
                        worm.direction.x = 0;
                        worm.direction.y = -1;
                    }
                    break;
                    // right
                case 39:
                    if (worm.direction.x !== -1 && worm.direction.y !== 0) {
                        worm.direction.x = 1;
                        worm.direction.y = 0;
                    }
                    break;
                    // down
                case 40:
                    if (worm.direction.x !== 0 && worm.direction.y !== -1) {
                        worm.direction.x = 0;
                        worm.direction.y = 1;
                    }
                    break;
            }
        };
    };

    var endGame = function () {
        clearInterval(gameLoopControl);
        alert('Game over! Your highscore is:' + gameScore.toString());
    };

    return {
        startGame: startGame
    };
}());