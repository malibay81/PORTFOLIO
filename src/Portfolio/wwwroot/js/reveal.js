// Scroll-Reveal: fügt Elementen mit .pf-reveal beim Eintritt in den Viewport
// die Klasse .pf-in hinzu. Idempotent (data-pf-observed-Guard), damit
// wiederholte Aufrufe (z. B. nach asynchronem Nachladen von Inhalten) sicher sind.
(function () {
    var io = null;

    function ensureObserver() {
        if (io) return io;
        io = new IntersectionObserver(function (entries) {
            entries.forEach(function (entry) {
                if (entry.isIntersecting) {
                    entry.target.classList.add('pf-in');
                    io.unobserve(entry.target);
                }
            });
        }, { threshold: 0.15, rootMargin: '0px 0px -40px 0px' });
        return io;
    }

    window.pfInitReveal = function () {
        var observer = ensureObserver();
        document.querySelectorAll('.pf-reveal:not([data-pf-observed])').forEach(function (el) {
            el.dataset.pfObserved = '1';
            observer.observe(el);
        });
    };
})();
