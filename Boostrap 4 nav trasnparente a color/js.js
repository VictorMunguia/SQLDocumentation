$(window).scroll(function(){
  if ($("#menu").offset().top > 56) {
    $("#menu").addClass("CambioColorNav");
  }else{
    $("#menu").removeClass("CambioColorNav")
  }
});
