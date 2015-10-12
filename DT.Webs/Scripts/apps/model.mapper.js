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
            item.title = dto.name;
            return item;
        }
    };

    var question = {
        getDtoId: function (dto) {
            return dto.id;
        },

        fromDto: function (dto, item) {
            item = new model.question();
            item.id = dto.id;
            item.text = dto.text;
            item.topicId = dto.topicId;
            return item;
        }
    };

    return {
        topic: topic,
        question: question
    }
});