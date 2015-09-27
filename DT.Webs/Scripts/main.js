(function() {

    var root = this;

    define3rdPartyLibs();
    loadPluginsAndBoot();

    function define3rdPartyLibs() {
        define('ko', [], function () { return root.ko; });
    }

    function loadPluginsAndBoot() {
        // Plugins must be loaded after jQuery and Knockout, 
        // since they depend on them.
        requirejs([], boot);
    }

    function boot() {
        require(['datacontext'], function(dc) { dc.run(); });
    }

})();