/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\11.HTML Templates\HTMLTemplates\HTMLTemplates\libraries/jquery-2.1.1.js" />
(function () {
    var tableRowsTemplate,
        data = {
            lections: [{
                number: 0,
                name: 'Course Introduction',
                date1: 'Wed 18:00, 28-May-2014',
                date2: 'Thu 14:00, 29-May-2014',
            }, {
                number: 1,
                name: 'Documnet Object Model',
                date1: 'Wed 18:00, 28-May-2014',
                date2: 'Thu 14:00, 29-May-2014',
            },
        {
            number: 2,
            name: 'HTML5 Canvas',
            date1: 'Thu 18:00, 29-May-2014',
            date2: 'Fri 14:00, 30-May-2014',
        },
        {
            number: 3,
            name: 'KineticJS Overview',
            date1: 'Thu 18:00, 29-May-2014',
            date2: 'Fri 14:00, 30-May-2014',
        }, {
            number: 4,
            name: 'SVG and RaphaelJS',
            date1: 'Wed 18:00, 04-Jun-2014',
            date2: 'Thu 14:00, 29-Jun-2014',
        }, {
            number: 5,
            name: 'Animations with Canvas and SVG',
            date1: 'Wed 18:00, 04-Jun-2014',
            date2: 'Thu 14:00, 05-Jun-2014',
        }, {
            number: 6,
            name: 'DOM operations',
            date1: 'Wed 18:00, 05-Jun-2014',
            date2: 'Thu 14:00, 06-Jun-2014',
        }, {
            number: 7,
            name: 'Event model',
            date1: 'Wed 18:00, 05-Jun-2014',
            date2: 'Thu 14:00, 06-Jun-2014',
        }, {
            number: 8,
            name: 'jQuery overview',
            date1: 'Wed 18:00, 11-Jun-2014',
            date2: 'Thu 14:00, 12-Jun-2014',
        }, {
            number: 9,
            name: 'HTML templates',
            date1: 'Wed 18:00, 11-Jun-2014',
            date2: 'Thu 14:00, 12-Jun-2014',
        }, {
            number: 10,
            name: 'Exam preparation',
            date1: 'Wed 18:00, 12-Jun-2014',
            date2: 'Thu 14:00, 13-Jun-2014',
        }, {
            number: 11,
            name: 'Exam',
            date1: 'Wed 10:00, 17-Jun-2014',
            date2: 'Thu 16:30, 17-Jun-2014',
        }, {
            number: 12,
            name: 'Teamwork Defense',
            date1: 'Tue 10:00, 19-Jun-2014',
            date2: 'Thu 10:00, 19-Jun-2014',
        }]
        };

    tableRowsTemplate = $("#table-rows-template").html();
    var template = Handlebars.compile(tableRowsTemplate);

    $('#table-container').append(template(data));
}());