window.onload = function(){ 

    document.querySelectorAll('.div_photo_game').forEach(el => {
        el.onclick = (event) => {
            // set selected
            document.querySelectorAll('.div_photo_game').forEach(elImg => {
                // remove selected
                elImg.classList.remove('selected');
            });

            event.target.classList.add('selected');

            // game name
            const gameName = event.target.getAttribute('data-game-name');
            document.querySelector('#txt-game-name').innerHTML = gameName;
    
            //game link
            const gameLink = event.target.getAttribute('data-game-link');
            document.querySelector('#btn-game-buy').setAttribute('href', gameLink);

            //game main imge
            const gameBigImg = event.target.getAttribute('data-game-big-img');
            document.querySelector('#img-game-main').setAttribute('src', gameBigImg);
        }
    });


};

