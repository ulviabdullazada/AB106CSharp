// fetch('https://hp-api.onrender.com/api/characters')
//     .then(res=> res.json())
//     .then(a=>{
//         getCharacters(a.filter(h=>h.image != "" && h.house != ""));
//     })

// console.log(document.getElementById("cards-area").innerHTML);

// var area = document.getElementById("cards-area");
// function getCharacters(characters){
//     area.innerHTML = "";
//     characters.forEach(char => {
//         area.innerHTML +=
//     `<div class="col-md-3 my-2">
//         <div class="card">
//             <img src="${char.image}" height="450px" class="card-img-top" alt="${char.name}"/>
//             <div class="card-body">
//               <h5 class="card-title">${char.name}</h5>
//               <p class="card-text">${char.house} <br> <small>${char.dateOfBirth}</small> </p>
//               <a href="#!" class="btn btn-primary" data-mdb-ripple-init>About</a>
//             </div>
//           </div>
//         </div>`;
//     })
// }


var list = document.getElementById("list-area")
var nextBtn = document.getElementById("btn-nxt");
var prevBtn = document.getElementById("btn-prv");

fetchData('https://pokeapi.co/api/v2/pokemon?limit=15&offset=0');

function getPokemons(data) {
    list.innerHTML = "";
    nextBtn.setAttribute("page-link", data.next ?? "#");
    prevBtn.setAttribute("page-link", data.previous ?? "#");
    data.results.forEach(elem => {
        list.innerHTML += `<span onclick=getImage("${elem.url}") class="list-group-item list-group-item-action px-3 border-0 bg-qara">${elem.name}</span>`
    });
}
function fetchData(link)
{
    fetch(link)
    .then(res => res.json())
    .then(data => getPokemons(data));
}

function getImage(link)
{
    fetch(link)
    .then(res => res.json())
    .then(data => 
        {
            document.getElementById("img-area").innerHTML = `<img class="w-100" src="${data.sprites.other.dream_world.front_default}" alt="">`
        }
    );
}

nextBtn.onclick = function(e){
    fetchData(e.target.getAttribute("page-link"));
}
prevBtn.onclick = function(e){
    fetchData(e.target.getAttribute("page-link"));
}