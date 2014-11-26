var gameEngine = (function () {
    var gameCanvas = document.getElementById('the-canvas');
    var context = gameCanvas.getContext('2d');
    var BLOCK_SIZE = 10;
    var NUMBER_OF_APPLES = 10;
    var gameWidth = gameCanvas.clientWidth;
    var gameHeigth = gameCanvas.clientHeight;
    var gameLoopControl;
    var gameScore;
    var playerName;

    function getPlayerName(){
        var currentName = prompt('Please enter your name:');
        if (currentName === '') {
            currentName = 'Anonymous';
        }
        else if (currentName === null) {
            currentName = 'Anonymous';
        }
        return currentName;
    }
        
    var startGame = function(){
        context.clearRect(0, 0, gameWidth, gameHeigth);
        playerName = getPlayerName();
        var playerWorm = new Worm(6, 40, 20);
        var wormBody = playerWorm.getWormBody();
        console.log(wormBody);
        keyboardControlWorm(playerWorm);
        gameScore = 0;
        var gameElements = [];
        gameElements['worm'] = playerWorm;
        gameElements['apples'] = [];
        for (var i = 0; i < NUMBER_OF_APPLES; i++) {
            gameElements['apples'].push(generateApple());
        }
        clearInterval(gameLoopControl);
        gameLoopControl = setInterval(function () {
            clearBoard();
            drawElements([playerWorm.head], 'pink');
            drawElements(wormBody, 'purple');
            drawElements(gameElements['apples'], 'green');
            playerWorm.move();
            detectCollision(gameElements);
            localStorage.setItem(gameScore, playerName);
        }, 100);
    }

    var Worm = function (startLength, startX, startY) {
        this.head = new gameBlock(startX, startY);
        wormBody = new Array(startLength - 1);
        for (var i = 0; i < startLength - 1; i++) {
            wormBody[i] = new gameBlock(startX - BLOCK_SIZE * (i + 1), startY);
        }

        this.getWormBody = function () {
            return wormBody;
        }

        this.direction = {
            x: 1,
            y: 0
        }

        this.move = function () {
            wormBody.splice(wormBody.length - 1, 1);
            wormBody.unshift(new gameBlock(this.head.xPosition, this.head.yPosition));
            this.head.xPosition += this.direction.x * BLOCK_SIZE;
            this.head.yPosition += this.direction.y * BLOCK_SIZE;
        }
    }

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
                wormBody.push(new gameBlock(newTailX, newTailY));
                apples.splice(i, 1);
                apples.push(generateApple());
                gameScore += 100;
            }
        }
    }

    var generateApple = function () {
        var appleXPosition = Math.round((Math.random() * gameWidth - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        var appleYPosition = Math.round((Math.random() * gameWidth - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        return new gameBlock(appleXPosition, appleYPosition);
    }

    var clearBoard = function () {
        context.clearRect(0, 0, gameWidth, gameHeigth);
    }

    var drawElements = function (elements, color) {
        context.fillStyle = color;
        for (var i = 0; i < elements.length; i++) {
            context.fillRect(elements[i].xPosition, elements[i].yPosition, BLOCK_SIZE, BLOCK_SIZE);
        }
    }

    var gameBlock = function (xPosition, yPosition) {
        if (xPosition % BLOCK_SIZE !== 0 || yPosition % BLOCK_SIZE !== 0) {
            throw new Error("The block coordinates must be within the canvas grid!");
        }

        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

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
        }
    }

    var endGame = function () {
        clearInterval(gameLoopControl);
        alert('Game over, ' + playerName + '! Your highscore is:' + gameScore.toString());
        updateScore(gameScore);
    }

    var updateScore = function(score){
        var tableRef = document.getElementById('highScoreTable').getElementsByTagName('tbody')[0];

        // Insert a row in the table at the last row
        var newRow = tableRef.insertRow(tableRef.rows.length);

        // Insert a cell in the row at index 0
        var newCell = newRow.insertCell(0);
        var otherNewCell = newRow.insertCell(1);
        // Append a text node to the cell
        var newText = document.createTextNode(localStorage[score]);
        newCell.appendChild(newText);
        newText = document.createTextNode(score);
        otherNewCell.appendChild(newText);
    }

    return {
        startGame: startGame
    };
})();