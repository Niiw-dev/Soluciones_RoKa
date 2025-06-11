window.startStatAnimation = () => {
    const statNumbers = document.querySelectorAll('#numbers .stat-number');

    const animateCount = (el) => {
        if (el.dataset.animating === 'true') return; // ya está animando
        el.dataset.animating = 'true';

        const rawTarget = el.dataset.target;
        const suffix = rawTarget.match(/[+%]/g)?.[0] || '';
        const target = parseInt(rawTarget.replace(/[^\d]/g, ''));

        const duration = 2000;
        const startTime = performance.now();

        const step = (now) => {
            const progress = Math.min((now - startTime) / duration, 1);
            const value = Math.floor(progress * target);
            el.textContent = value + suffix;

            if (progress < 1) {
                requestAnimationFrame(step);
            } else {
                el.textContent = target + suffix;
                setTimeout(() => {
                    el.dataset.animating = 'false';
                }, 300);
            }
        };

        requestAnimationFrame(step);
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                animateCount(entry.target);
            }
        });
    }, {
        threshold: 0.5
    });

    statNumbers.forEach(el => {
        el.textContent = '0';
        el.dataset.animating = 'false';
        observer.observe(el);
    });
};
