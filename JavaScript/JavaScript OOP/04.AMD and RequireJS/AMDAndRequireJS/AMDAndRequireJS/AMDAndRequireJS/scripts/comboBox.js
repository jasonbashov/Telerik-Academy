/// <reference path="libs/jquery-2.1.1.js" />
define(["handlebars"], function () {
    var ComboBox = function (people) {
        function render(template) {
            var $comboBoxContainer = $('<div class="comboBox-container" />');
            var selectTemplate = Handlebars.compile(template);
            var renderedHtml = selectTemplate({
                people: people
            });

            $comboBoxContainer.append(renderedHtml);

            var hiddenClass = 'hidden';
            var selectedClass = 'selected';
            var visibleClass = 'visible';

            $comboBoxContainer.children().first().addClass(selectedClass);

            $comboBoxContainer.addClass(hiddenClass);

            $comboBoxContainer.on('click', '.person-item', function () {
                var $this = $(this);

                if ($comboBoxContainer.hasClass(hiddenClass)) {
                    $comboBoxContainer.children().addClass(visibleClass);
                    $comboBoxContainer.removeClass(hiddenClass)
                } else {
                    $comboBoxContainer.children().removeClass(visibleClass);
                    $comboBoxContainer.find('.' + selectedClass).removeClass(selectedClass);
                    $this.addClass(selectedClass);
                    $comboBoxContainer.addClass(hiddenClass);
                }
            });
            
            return $comboBoxContainer;
        };

        return {
            render: render
        }
    };

    return {
        ComboBox: ComboBox
    }
});