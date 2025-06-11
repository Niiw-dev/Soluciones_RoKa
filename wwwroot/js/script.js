(function () {
    const scrollWrapper = document.getElementById('scrollWrapper');
    if (!scrollWrapper) return;

    const items = scrollWrapper.querySelectorAll('.service-card');
    if (items.length === 0) return;

    const middleIndex = Math.floor(items.length / 2);
    const middleItem = items[middleIndex];

    scrollWrapper.scrollLeft = middleItem.offsetLeft - (scrollWrapper.offsetWidth / 2) + (middleItem.offsetWidth / 2);

    let isDown = false;
    let startX;
    let scrollLeft;

    if (!scrollWrapper.dataset.hasListener) {
        scrollWrapper.addEventListener('mousedown', (e) => {
            isDown = true;
            scrollWrapper.classList.add('active');
            startX = e.pageX - scrollWrapper.offsetLeft;
            scrollLeft = scrollWrapper.scrollLeft;
        });
    
        scrollWrapper.addEventListener('mouseleave', () => isDown = false);
        scrollWrapper.addEventListener('mouseup', () => isDown = false);
        scrollWrapper.addEventListener('mousemove', (e) => {
            if (!isDown) return;
            e.preventDefault();
            const x = e.pageX - scrollWrapper.offsetLeft;
            const walk = (x - startX) * 1.5;
            scrollWrapper.scrollLeft = scrollLeft - walk;
        });
    
        scrollWrapper.dataset.hasListener = "true";
    }
})();
