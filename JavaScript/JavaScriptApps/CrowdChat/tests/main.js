(function () {
    "use strict";
    require.config({
        paths: {
            jquery: '../CrowdChat2.0/javascript/libs/jquery.min',
            sammy: '../libraries/sammy/lib/sammy-latest.min',
			q: '../CrowdChat2.0/javascript/libs/q.min',
            mocha:'mocha/mocha',
            chai:'chai/chai',
			httpRequester: '../CrowdChat2.0/javascript/httpRequester'
        }
    });
 
    require(['mocha', 'chai'], function () {
        mocha.setup('bdd');
        require(['testController'], function() {
            mocha.run();
        });
    })
}());