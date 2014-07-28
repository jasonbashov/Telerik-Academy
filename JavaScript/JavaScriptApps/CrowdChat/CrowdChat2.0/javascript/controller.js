define(['httpRequester'], function (httpRequest) {
    'use strict';
    var Controller;
    Controller = (function () {
        var refreshInterval;

        function Controller(resourceUrl) {
            this.resourceUrl = resourceUrl;
        }

        Controller.prototype.getUsername = function () {
            return sessionStorage.getItem('username');
        };

        Controller.prototype.setUsername = function (username) {
            sessionStorage.setItem('username', username);
        };

        Controller.prototype.destroyUsername = function () {
            sessionStorage.clear();
        };

        Controller.prototype.destroyCurrentSession = function () {
            clearInterval(refreshInterval);
            $('#main-content').off('click', '#send-msg-button');
        }

        Controller.prototype.isLoggedIn = function () {
            return this.getUsername() != null;
        };
        Controller.prototype.loadLoginPage = function (selector) {
            var deferred = Q.defer();

            deferred.resolve($(selector).load("javascript/views/loginView.html"));

            return deferred.promise;
        }

        Controller.prototype.loadChatPage = function () {
            var defered = Q.defer();

            defered.resolve($('#main-content').load("javascript/views/chatView.html"));

            return defered.promise;
        }

        Controller.prototype.startChattingSession = function () {
            var userMessage;
            var url = this.resourceUrl;
            //$('#send-msg-button').off();

            //$('#chat-container').slideDown();

            function reloadMessages() {
                httpRequest.getJSON(url).then(replaceMessages);
            }

            function generateMessages(data) {
                var i, msg, len, messageList;
                messageList = $('<ul />').addClass('msg-list').attr('id', 'scroll-down');
                for (i = 0, len = data.length; i < len; i += 1) {
                    msg = data[i];
                    $('<li />')
                        .html('<strong>' + msg.by + ' : </strong>' + msg.text)
                        .appendTo(messageList);
                }
                return messageList;
            }


            function replaceMessages(data) {
                $('.msg-list').replaceWith(generateMessages(data));
            }

            function displayMessages(data) {
                var i, msg, len, messageList;
                messageList = $('<ul />').addClass('msg-list').attr('id', 'scroll-down');
                for (i = 0, len = data.length; i < len; i += 1) {
                    msg = data[i];
                    $('<li />')
                        .html('<strong>' + msg.by + ' : </strong>' + msg.text)
                        .appendTo(messageList);
                }
                $("#msg-container").append(messageList);
                var objDiv = document.getElementById("msg-container");
                objDiv.scrollTop = objDiv.scrollHeight;
            }


            $('#main-content').on('click','#send-msg-button', function () {
                userMessage = $('#msg-input').val();
                var msgToPost = {
                    user: sessionStorage.getItem('username'),
                    text: userMessage
                }
                httpRequest.postJSON(url, msgToPost).then(reloadMessages).then(function () {
                    var objDiv = document.getElementById("msg-container");
                    objDiv.scrollTop = objDiv.scrollHeight;
                });
            });
            httpRequest.getJSON(url).then(displayMessages);

            refreshInterval = setInterval(function () {
                reloadMessages();
                console.log((new Date().getSeconds()));
            }, 4000);
        }

        return Controller;
    })();

    return Controller;
});