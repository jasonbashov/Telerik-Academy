define(function () {
    var httpRequest = (function () {
        var getJSON, postJSON;
        makeRequest = function (options) {
            deferred = Q.defer();
            return deferred.promise;
        };

        getJSON = function (url) {
            deferred = Q.defer();
            $.getJSON(url, function (data) {
                deferred.resolve(data);
            }).error(function (data) {
                deferred.reject(data);
            });

            return deferred.promise;
        };

        postJSON = function (url, data) {
            deferred = Q.defer();
            $.ajax({
                url: url,
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(data),
                dataType: "json",
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (err) {
                    deferred.reject(err);
                }
            });

            return deferred.promise;
        };
        return {
            getJSON: getJSON,
            postJSON: postJSON
        };
    })();
    return httpRequest;
});