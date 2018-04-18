(function FuncionPadre(Saludo){

    document.getElementById('btn').addEventListener("click",function(){
      console.log("Click en mi " + Saludo)
    });

})("Victor");//Hacer esto al final es mandar a llamar 
