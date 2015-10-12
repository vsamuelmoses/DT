(function() {

    var root = this;

    define3rdPartyLibs();
    loadPluginsAndBoot();

    function define3rdPartyLibs() {
        define('jquery', [], function() { return root.jquery; });
        define('ko', [], function () { return root.ko; });
        define('moment', [], function () { return root.moment; });
        define('toastr', [], function () { return root.toastr; });
        define('underscore', [], function () { return root._; });
    }

    function loadPluginsAndBoot() {
        // Plugins must be loaded after jQuery and Knockout, 
        // since they depend on them.
        requirejs([], boot);
    }

    function boot() {

        require(['dataprimer', 'binder'], function(dp, binder) {
            dp.fetch()
                .done(function() { binder.bind(); })
                .always(function () { alert('dataprimer fetch finished'); });
        });
    }

})();