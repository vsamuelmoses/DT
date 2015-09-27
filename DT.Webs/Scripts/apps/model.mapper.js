define('model.mapper',
    ['model'],
function (model) {

    var topic = {
        getDtoId: function (dto) {
            return dto.id;
        },

        fromDto: function(dto, item) {
            item = new model.topic();
            item.id = dto.id;
            item.title = dto.title;
            return item;
        }
    };

    return {
        topic: topic
    }
});