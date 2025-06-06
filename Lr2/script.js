
document.addEventListener('DOMContentLoaded', function() {
    // Анимация кнопок билетов
    const buyButtons = document.querySelectorAll('.buy-btn');
    
    buyButtons.forEach(button => {
        button.addEventListener('mouseenter', function() {
            this.classList.add('hover-effect');
        });
        
        button.addEventListener('mouseleave', function() {
            this.classList.remove('hover-effect');
        });
    });
});