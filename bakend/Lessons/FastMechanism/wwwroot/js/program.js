
window.onload = function(){ 

    document.querySelectorAll('.item_program').forEach(el => {
        el.onclick = (event) => {
            //set selected
            document.querySelectorAll('.item_program').forEach(elImg => {
                //remove selected
                elImg.classList.remove('selected');
            });

            event.target.classList.add('selected');

            //program name
            const programName = event.target.getAttribute('data-program-name');
            document.querySelector('#txt-program-name').innerHTML = programName;
    
            //program link
            const programLink = event.target.getAttribute('data-program-link');
            document.querySelector('#btn-program-buy').setAttribute('href', programLink);

            //program main imge
            const programBigImg = event.target.getAttribute('data-program-big-img');
            document.querySelector('#img-program-main').setAttribute('src', programBigImg);
        }
    });


};

