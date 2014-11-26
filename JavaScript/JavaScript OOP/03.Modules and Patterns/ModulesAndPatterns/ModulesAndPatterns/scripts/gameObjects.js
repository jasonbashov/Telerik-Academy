var gameObjects = (function () {
    var GameBlock = (function () {
        var GameBlock = function (xPosition, yPosition) {
            if (xPosition % constants.BLOCK_SIZE !== 0 || yPosition % constants.BLOCK_SIZE !== 0) {
                throw new Error("The block coordinates must be within the canvas grid!");
            }

            this.xPosition = xPosition;
            this.yPosition = yPosition;
        };
        return GameBlock;
    })();

    var Worm = (function () {
        var Worm = function (startLength, startX, startY) {
            this.startLength = startLength;
            this.startX = startX;
            this.startY = startY;
            this.head = new GameBlock(this.startX, this.startY);
            this.wormBody = [];

            for (var i = 0; i < this.startLength - 1; i++) {
                this.wormBody.push(new GameBlock(this.startX - constants.BLOCK_SIZE * (i + 1), this.startY));
            }

            this.direction = {
                x: 1,
                y: 0
            };
        };

        Worm.prototype.getWormBody = function () {
            return this.wormBody;
        };

        Worm.prototype.move = function () {
            this.wormBody.splice(this.wormBody.length - 1, 1);
            this.wormBody.unshift(new GameBlock(this.head.xPosition, this.head.yPosition));
            this.head.xPosition += this.direction.x * constants.BLOCK_SIZE;
            this.head.yPosition += this.direction.y * constants.BLOCK_SIZE;
        };
        return Worm;
    })();

    var generateApple = function (gameWidth, gameHeigth) {
        var appleXPosition = Math.round((Math.random() * gameWidth - constants.BLOCK_SIZE) / constants.BLOCK_SIZE) * constants.BLOCK_SIZE;
        var appleYPosition = Math.round((Math.random() * gameHeigth - constants.BLOCK_SIZE) / constants.BLOCK_SIZE) * constants.BLOCK_SIZE;
        return new GameBlock(appleXPosition, appleYPosition);
    };

    return {
        Worm: Worm,
        GameBlock: GameBlock,
        generateApple: generateApple
    };
}());