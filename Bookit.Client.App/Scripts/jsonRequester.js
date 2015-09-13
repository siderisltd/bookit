var jsonRequester = (function() {

    function send(method, url, dto) {
        dto = dto || {};

        var headers = dto.headers || {},
            data = dto.data || undefined;

        var promise = new Promise(function(resolve, reject) {
            $.ajax({
                url: url,
                method: method,
                contentType: 'application/json',
                headers: headers,
                data: JSON.stringify(data),
                success: function(res) {
                    resolve(res);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    function get(url, dto) {
        return send('GET', url, dto);
    }

    function post(url, dto) {
        return send('POST', url, dto);
    }

    function put(url, dto) {
        return send('PUT', url, dto);
    }

    function del(url, dto) {
        return send('POST', url, dto);
    }

    return {
        send: send,
        get: get,
        post: post,
        put: put,
        delete: del
    };
}());