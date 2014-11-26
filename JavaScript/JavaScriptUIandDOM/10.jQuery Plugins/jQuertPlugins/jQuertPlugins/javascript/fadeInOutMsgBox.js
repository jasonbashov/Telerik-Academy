/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\10.jQuery Plugins\jQuertPlugins\jQuertPlugins\libraries/jquery-2.1.1.js" />
$.fn.messageBox = function (options) {
    var $this = $(this);

    function success(message) {
        $this.each(function () {
            $this.animate({ 'opacity': 1 }, 1000);
            $this.css('background-color', 'green');
            $(this).html(message);
            setInterval(function () { $this.animate({ 'opacity': 0 }, 1000); }, 3000);
        });
        return $this;
    }

    function error(message) {
        $this.each(function () {
            $this.animate({ 'opacity': 1 }, 1000);
            $this.css('background-color', 'red');
            $(this).html(message);
            setInterval(function () { $this.animate({ 'opacity': 0 }, 1000); }, 3000);
        });
        return $this;
    }

    return {
        success : success,
        error : error
    };
}