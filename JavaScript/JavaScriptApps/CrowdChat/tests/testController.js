define(['chai', '../CrowdChat2.0/javascript/controller'], function (chai, Controller) {
    var assert = chai.assert;
    var expect = chai.expect;
    describe('Controller', function () {
        describe('when initializing', function () {
            it('with valid url, expect ok', function () {
                var controller = new Controller('http://crowd-chat.herokuapp.com/posts');
                expect(controller.resourceUrl).to.equal('http://crowd-chat.herokuapp.com/posts');
            })
        });
		describe('setUsername & getUsername', function () {
            it('with valid username, expect ok', function () {
                var controller = new Controller('http://crowd-chat.herokuapp.com/posts');
				controller.setUsername('gosho');
                expect(controller.getUsername()).to.equal('gosho');
            })
        });
		describe('setUsername & destroyUsername', function () {
            it('with valid username, expect ok', function () {
                var controller = new Controller('http://crowd-chat.herokuapp.com/posts');
				controller.setUsername('pesho');
				controller.destroyUsername();
                expect(controller.getUsername()).to.equal(null);
            })
        });
		
    });
});