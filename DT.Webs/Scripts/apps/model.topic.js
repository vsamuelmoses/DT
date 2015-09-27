define('model.topic',
    ['ko'],
    function (ko) {

    var Topic = function () {
        var self = this;
        self.id = ko.observable("unknown");
        self.title = ko.observable("Topic title..");
    }

    Topic.Nullo = new Topic()
        .id(-1)
        .title("Null title");

    return Topic;
});