define('model',
    ['model.topic', 'model.question'],
    function (topic, question) {

        return {
            topic: topic,
            question: question
        }

    });