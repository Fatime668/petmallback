$(".setting").click(function () {
    $(".box").css("display","block")
  })
  $(".close").click(function () {
    $(".box").css("display","none")
  })
  let tabBtn = document.querySelectorAll(".tabBtn")
  let tabContent = document.querySelectorAll(".tab-content")
  
  for (let i = 0; i < tabBtn.length; i++) {
    tabBtn[i].onclick = function(e){
      e.preventDefault()
      for (let j = 0; j < tabContent.length; j++) {
        tabContent[j].classList.remove('active')
      }
      for (let j = 0; j < tabBtn.length; j++) {
        tabBtn[j].style.borderBottom = "none"
        tabBtn[j].style.color = "rgb(168, 165, 165)"
      }
      let btnI = this.getAttribute('data-btn')
      tabContent[btnI].classList.add('active')
      this.style.borderBottom = "3px solid #16B8B8"
      this.style.color = "#000"
    }  
  }
  $('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})
