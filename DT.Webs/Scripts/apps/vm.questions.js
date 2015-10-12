define(
    'vm.questions',
    ['datacontext', 'ko'],
    function (dc, ko) {

        var
            questions = ko.observableArray(),

            activate = function () {
                questions(dc.questions.getAllLocal());
            };

        return {
            activate: activate,
            questions: questions
        }
    });