fetch('https://localhost:5001/api/Productos')
  .then(response => response.json())
  .then(data => {
    data.forEach(element => {
       let h2= document.getElementById("productos");
       h2.innerHTML = element.nombre
    });
    
  });