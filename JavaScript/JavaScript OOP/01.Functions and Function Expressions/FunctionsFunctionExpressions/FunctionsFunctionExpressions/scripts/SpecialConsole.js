var specialConsole = (function () {

    var writeLine = function writeL(msg) {
        if (msg) {
            if (arguments.length <= 1) {
                console.log(msg);
            }
            else {
                var formattedMsg = formatArguments(arguments);
                console.log(formattedMsg);
            }

        }
        else {
            console.log('\n');
        }
    }

    function formatArguments() {
        var allPassedMessagesArr = arguments[0];
        var mainMsg = allPassedMessagesArr[0];

        while (true) {
            var index = mainMsg.indexOf('{');

            if (index === -1) {
                break;
            }

            var placeholderNumber = mainMsg[index + 1];

            mainMsg = mainMsg.replace(('{' + placeholderNumber + '}'), allPassedMessagesArr[parseInt(placeholderNumber) + 1]);
        }

        return mainMsg;
    }


    return {
        writeLine: writeLine,
        writeError: writeLine,
        writeWarning: writeLine
    }
})();