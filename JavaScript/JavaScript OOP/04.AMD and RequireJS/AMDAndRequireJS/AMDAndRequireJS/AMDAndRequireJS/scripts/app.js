/// <reference path="libs/jquery-2.1.1.js" />
/// <reference path="libs/require.js" />
(function () {
    require.config({
        paths: {
            "jquery": "libs/jquery-2.1.1",
            "handlebars": "libs/handlebars-v1.3.0",
            "data": "data",
            "combo-box": "comboBox"
        }
    });

    require(["jquery", "data", "combo-box"], function ($, data, controls) {
        var people = data;
        var comboBox = controls.ComboBox(people);
        //you can change the template id and the returned data from data.js to try the other template
        var template = $("#authors-template").html();
        var comboBoxHtml = comboBox.render(template);
        var container = $('#container');
        container.append(comboBoxHtml);
    });
}());