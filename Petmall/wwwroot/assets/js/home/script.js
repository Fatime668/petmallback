$(".setting").click(function () {
    $(".box").css("display","block")
  })
  $(".close").click(function () {
    $(".box").css("display","none")
  })
//slider
  $('.slider').slick({
    dots: true,
    infinite: true,
    speed: 500,
    fade: true,
    cssEase: 'linear',
    nextArrow: $(".nextBtn"),
    prevArrow: $(".prevBtn"),
    autoplay: true,
    autoplaySpeed: 2000,
})    
$('.brands').slick({
    slidesToShow: 6,
    slidesToScroll: 1,
    dots: true,
    // responsive: [
    //     {
    //       breakpoint: 768,
    //       settings: {
    //         arrows: false,
    //         centerMode: true,
    //         centerPadding: '40px',
    //         slidesToShow: 3
    //       }
    //     },
    //     {
    //       breakpoint: 480,
    //       settings: {
    //         arrows: false,
    //         centerMode: true,
    //         centerPadding: '40px',
    //         slidesToShow: 1
    //       }
    //     }
    //   ]
})
//tabmenu
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
