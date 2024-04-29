
var row=document.getElementsByClassName("row")[0];
var search=document.getElementById("search")
// row.classList.add("d-flex")
// ${element.summary.length>=50?element.summary.substring(0,49)+"...</p>":element.summary}
function fillHtml(data){
    data.forEach(element => {


       row.innerHTML+=`<div class="card col-md-3 " style="width: 18rem;">
       <img src="${element.image.medium}" class="card-img-top" alt="...">
       <div class="card-body">
         <h5 class="card-title">${element.name}</h5> 
         ${element.summary.length>=300?element.summary.substring(0,300)+"...</p>":element.summary}
         <p class="card-text">${element.rating.average}</p>
         <a href="detail.html?q=${element.id}" class="btn btn-primary">Detail</a>
       </div>
       </div>
       `
    });
}
function fillHtmlSearch(data){
    data.forEach(element => {


       row.innerHTML+=`<div class="card col-md-3 " style="width: 18rem;">
       <img src="${element.show.image.medium}" class="card-img-top" alt="...">
       <div class="card-body">
         <h5 class="card-title">${element.show.name}</h5> 
         ${element.show.summary.length>=300?element.show.summary.substring(0,300)+"...</p>":element.show.summary}
         <p class="card-text">${element.show.rating.average}</p>
         <a href="detail.html?q=${element.show.id}" class="btn btn-primary">Detail</a>
       </div>
       </div>
       `
    });
}



$.ajax({
    method:"GET",
    url:"https://api.tvmaze.com/shows"
}).done(data=>fillHtml(data.sort((a,b)=>b.rating.average-a.rating.average)))



// fetch("https://api.tvmaze.com/shows").then(json=>json.json()).then(data=>fillHtml(data))
// axios.get("https://api.tvmaze.com/shows").then(elements=>fillHtml(elements.data))


search.onkeyup=function(e){
    axios.get(`https://api.tvmaze.com/search/shows?q=${search.value}`).then(json=>{
        row.innerHTML=""
        fillHtmlSearch(json.data)
    })
}