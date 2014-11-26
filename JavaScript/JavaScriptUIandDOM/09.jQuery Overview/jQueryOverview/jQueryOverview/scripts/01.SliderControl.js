/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\09.jQuery Overview\jQueryOverview\jQueryOverview\libraries/jquery-2.1.1.js" />
(function () {
    var $nextBtn = $('#next'),
        $prevBtun = $('#prev'),
        $slideShowBtn = $('#slideShow'),
        $slideShowStopBtn = $('#slideShowStop'),
        isSlideShowOn = false;

    $nextBtn.on('click', onNextBtnClick);
    $prevBtun.on('click', onPrevBtnClick);
    $slideShowBtn.on('click', onStartSlideShow);
    $slideShowStopBtn.on('click', onStopSlideShow);

    function onNextBtnClick() {
        var $currSlide = $('.current');
        var $nextCurrent = $currSlide.next();
        if ($nextCurrent.hasClass('invis')) {
            $nextCurrent.removeClass('invis');
            $nextCurrent.addClass('current');
            $currSlide.removeClass('current');
            $currSlide.addClass('invis');
        }
    }

    function onPrevBtnClick() {
        var $currSlide = $('.current');
        var $prevCurrent = $currSlide.prev();
        if ($prevCurrent.hasClass('invis')) {
            $prevCurrent.removeClass('invis');//this may be optimized and avoid removing the "invis" class
            $prevCurrent.addClass('current');
            $currSlide.removeClass('current');
            $currSlide.addClass('invis');
        }
    }

    function onStartSlideShow() {
        isSlideShowOn = true;
        changingSlides();

        function changingSlides() {
            if (isSlideShowOn) {
                onNextBtnClick();
                setTimeout(changingSlides, 5000);
            }
        }
        
    }

    function onStopSlideShow() {
        isSlideShowOn = false;
    }
}());