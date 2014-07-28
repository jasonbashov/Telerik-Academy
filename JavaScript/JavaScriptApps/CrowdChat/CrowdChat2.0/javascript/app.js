/// <reference path="controller.js" />
/// <reference path="libs/jquery-2.1.1.min.js" />
(function () {
    'use strict';
    require(['controller'], function (Controller) {
        var sourceUrl = 'http://crowd-chat.herokuapp.com/posts';
        var controller = new Controller(sourceUrl);

        var app = Sammy("#main-content", function () {

            this.get("#/login", function () {
                if (controller.isLoggedIn()) {
                    window.location = '#/chat';
                    controller.destroyCurrentSession();
                    return;
                }
                controller.loadLoginPage("#main-content").then(function () {
                    $('#main-content').on('click', '#login-btn', function () {
                        controller.setUsername($('#login-username-input').val());
                        window.location = '#/chat';
                    });
                });
            });

            this.get("#/chat", function () {
                if (!controller.isLoggedIn()) {
                    window.location = '#/login';
                    return;
                }

                controller.loadChatPage()
                    .then(function () {
                        controller.startChattingSession();
                        $('#main-content').on('click', '#log-out-btn', function () {
                            controller.destroyUsername();
                            controller.destroyCurrentSession();
                            window.location = '#/login';
                        });
                    });

            });

        });
        app.run("#/login");
    });
}());