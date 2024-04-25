// var body=document.querySelector("body")

// body.innerHTML+=` 
// <ol>
// <li>
//     Rauf
// </li>
// <li>
//     Nazrin
// </li>
// <li>
//     Inara
// </li>
// <li>
//     Shahin
// </li>
// </ol>
// `


const students=[
    {
        Name:"Psy",
        Surname:"Psyzade",
        Group:"AB106"
    },
    {
        Name:"Samuray",
        Surname:"Katanov",
        Group:"AB106"
    },
    {
        Name:"Inara",
        Surname:"Ahmadova",
        Group:"AB106"
    }
]

var body=document.querySelector("div")

body.innerHTML=`
<table>
<thead>
    <tr>
        <th>
            name
        </th>
        <th>
            surname
        </th>
        <th>
            group
        </th>
    </tr>

</thead>

<tbody>`

for(let i=0;i<students.length;i++){
body.innerHTML+=`

<tr>
<td>
${students[i].Name}
</td>
<td>
${students[i].Surname}
</td>
<td>
${students[i].Group}
</td>
</tr>`
}


innerHeight.innerHTML+=`
</tbody>
</table>`
