const list = document.querySelectorAll('.list');
function activeLink() {
    list.forEach((item) => {
        item.classList.remove('list');
        this.classList.add('active');
    });
}
list.forEach((item) => {
    item.addEventListener('click', activeLink);
});