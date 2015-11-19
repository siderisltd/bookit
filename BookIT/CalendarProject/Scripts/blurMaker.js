var blurMaker = (function(){

    function blur(elementQuerySelector){
        $(elementQuerySelector).foggy({
            blurRadius: 2,          // In pixels.
            opacity: 0.8,           // Falls back to a filter for IE.
            cssFilterSupport: true  // Use "-webkit-filter" where available.
        });
    }

    return {
        blur: blur
    }
}());