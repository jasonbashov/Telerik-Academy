﻿(function () {
    $.fn.listview = function (collection) {
        var $this = $(this),
            templateString = '{{#each collection}}';
            templateString += $this.html();
            templateString += '{{/each}}';

        $this.html('');

        var template = Handlebars.compile(templateString);

        $this.html(template({ collection: collection }));

        return $this;
    }
}(jQuery));