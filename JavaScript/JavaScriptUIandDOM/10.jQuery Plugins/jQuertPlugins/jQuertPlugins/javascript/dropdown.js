/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\10.jQuery Plugins\jQuertPlugins\jQuertPlugins\libraries/jquery-2.1.1.js" />
(function ($) {
    $.fn.dropdown = function () {
        var $initialDropdown = $('#dropdown').css('display', 'none'),
            $initialDropdownChildren = $initialDropdown.children(),
            container = $('#dropdownContainer');

        container.append('<div class="dropdown-list-container"><ul class="dropdown-list-options"></ul></div>');

        var $theNewUL = $('.dropdown-list-options');

        for (var i = 0, len = $initialDropdownChildren.length; i < len; i++) {
            $theNewUL.append(listItemFrame(i + 1, $($initialDropdownChildren[i]).html()));
        }

        $(".dropdown-list-option").on("click", function () {
            var data = $(this).attr('data-value');
            var selector = 'option[value="' + data + '"]';
            $('option').removeAttr('selected');
            $('.dropdown-list-option').css('background-color', '');
            $('#dropdown').find(selector).attr('selected', 'selected');
            $(this).css('background-color', 'purple');
            $('#screen').html('').append('You\'ve selected option: ' + $('#dropdown :selected').html());

        });

        function listItemFrame(dataValue, innerText) {
            return ('<li class="dropdown-list-option" data-value="' + dataValue + '">' + innerText + '</li');
        }

        return this;
    };
}(jQuery));