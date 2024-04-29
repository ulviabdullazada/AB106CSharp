
var container=document.getElementsByClassName("container")[0]
var id=window.location.search.slice(3)


axios.get(`https://api.tvmaze.com/shows/${id}`).then(element=>container.innerHTML=
`<h1>${element.data.name}</h1>
<img src="${element.data.image.medium}" alt="${element.data.name}">
<p><strong>imdb:</strong> ${element.data.rating.average}</p>
${element.data.summary}
`)