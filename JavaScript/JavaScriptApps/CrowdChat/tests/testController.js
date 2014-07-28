describe('Controller', function () {
	describe('when initializing', function () {
		it('with valid url, expect ok', function () {
			var controller = new Controller('http://crowd-chat.herokuapp.com/posts');
			expect(controller.resourceUrl).to.equal('http://crowd-chat.herokuapp.com/posts');
		});
	});
});