define('dataservice.topics',
    [],
    function () {

    var
        init = function() {

            amplify.request.define('topics', 'ajax', {
                url: '/api/topics',
                dataType: 'json',
                type: 'GET'
            });

            
        },

        getTopics = function(callbacks) {
            return amplify.request({
                resourceId: 'topics',
                success: callbacks.success,
                error: callbacks.error
            });
        };

    init();

    return {
        getTopics : getTopics
    }
});