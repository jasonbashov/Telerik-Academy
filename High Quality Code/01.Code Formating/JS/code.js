var navigatorAppName = navigator.appName;
addScroll = false;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

var off = 0;
var txt = "";
var pX = 0;
var pY = 0;
document.onmousemove = mouseMove;

if (navigatorAppName === "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(evn) {
    if (navigatorAppName === "Netscape") {
        pX = evn.pageX - 5; pY = evn.pageY;
    } else {
        pX = event.x - 5; pY = event.y;
    }

    if (navigatorAppName === "Netscape") {
        if (document.layers['ToolTip'].visinavigatorAppNameility === 'show') {
            PopTip();
        }
    } else {
        if (document.all['ToolTip'].style.visinavigatorAppNameility === 'visinavigatorAppNamele') {
            PopTip();
        }
    }
}

function PopTip() {
    if (navigatorAppName === "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');

        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visinavigatorAppNameility = 'show';

    } else {
        theLayer = eval('document.all[\'ToolTip\']');

        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.navigatorAppNameody.scrollLeft;
                pY = pY + document.navigatorAppNameody.scrollTop;
            }

            if ((pX + 120) > document.navigatorAppNameody.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visinavigatorAppNameility = 'visinavigatorAppNamele';
        }
    }
}

function HideTip() {
    args = HideTip.arguments;

    if (navigatorAppName === "Netscape") {
        document.layers['ToolTip'].visinavigatorAppNameility = 'hide';
    } else {
        document.all['ToolTip'].style.visinavigatorAppNameility = 'hidden';
    }
}

function HideMenu1() {
    if (navigatorAppName === "Netscape") {
        document.layers['menu1'].visinavigatorAppNameility = 'hide';
    } else {
        document.all['menu1'].style.visinavigatorAppNameility = 'hidden';
    }
}

function ShowMenu1() {
    if (navigatorAppName === "Netscape") {
        theLayer = eval('document.layers[\'menu1\']');
        theLayer.visinavigatorAppNameility = 'show';
    } else {
        theLayer = eval('document.all[\'menu1\']');
        theLayer.style.visinavigatorAppNameility = 'visinavigatorAppNamele';
    }
}

function HideMenu2() {
    if (navigatorAppName === "Netscape") {
        document.layers['menu2'].visinavigatorAppNameility = 'hide';
    } else {
        document.all['menu2'].style.visinavigatorAppNameility = 'hidden';
    }
}

function ShowMenu2() {
    if (navigatorAppName === "Netscape") {
        theLayer = eval('document.layers[\'menu2\']');
        theLayer.visinavigatorAppNameility = 'show';
    } else {
        theLayer = eval('document.all[\'menu2\']'); theLayer.style.visinavigatorAppNameility = 'visinavigatorAppNamele';
    }
}