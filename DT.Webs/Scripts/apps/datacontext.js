define('datacontext',
    ['model.mapper', 'dataservice.topics'],
    function (mapper, topicsDataService) {

        var run = function() {

            topicsDataService.getTopics({
                //ASSERT
                success: function (result) {
                    var item = result[0];
                    alert(mapper.topic.getDtoId(item));
                    alert(result && result.length);
                },
                error: function (result) {
                    alert('Failed with: ' + result.responseText);
                }
            });;
        };

        return {
            run: run
        }
});