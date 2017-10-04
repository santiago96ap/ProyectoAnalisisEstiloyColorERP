<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstiloyColorERP.publico.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- banner -->
	<div class="banner">
		<!-- container -->
		<div class="container">
			<div class="banner-agileinfo">
				<script src="js/responsiveslides.min.js"></script>
				<script>
					// You can also use "$(window).load(function() {"
					$(function () {
					// Slideshow 4
						$("#slider3").responsiveSlides({
							auto: true,
							pager: true,
							nav: false,
							speed: 500,
							namespace: "callbacks",
							before: function () {
								$('.events').append("<li>before event fired.</li>");
							},
							after: function () {
								$('.events').append("<li>after event fired.</li>");
							}
						 });				
					});
				</script>
				<div  id="top" class="callbacks_container-wrap">
					<ul class="rslides" id="slider3">
						<li>
							<div class="banner-w3text">
								<h3>Historia</h3>
								<h5>Estilo y Color</h5>
								<p>Nuestra empresa más que ofrecerle productos para la decoración de interiores de alta calidad, lo invita a ser parte de una experiencia distinta donde el servicio al cliente es uno de nuestros pilares. 

								Somos un negocio familiar, turrialbeño, con un alto compromiso en los temas sociales y ambientales, que busca en la experiencia de decoración, brindarle la asesoría necesaria para volver cada uno de tus rincones favoritos en espacios de inspiración y creatividad.</p>
							</div>
						</li>
						<li>
							<div class="banner-w3text">
								<h3>Valores</h3>
								<h5>Estilo y Color</h5>
								<p>Los valores que rigen nuestro negocio:<br>
										•	Igualdad <br>
										•	Responsabilidad<br>
										•	Respeto <br>
										•	Honestidad<br>
										•	Comunicación <br>
										•	Innovación <br>
										•	Trabajo de equipo 
										•	Amor <br>
										•	Compromiso y entrega <br></p>
							</div>
						</li>
					</ul>
				</div>	
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //banner -->
	<!-- welcome -->
	<div class="welcome">
		<!-- container -->
		<div class="container">
			<div class="welcome-info">
				<h2 class="agileits-title">Misión</h2>
				<h5>Estilo y Color</h5>
				<p>Somos una empresa turrialbeña que ofrece productos para la decoración de interiores de alta calidad, exclusivos, diferentes; ofrecemos la mejor experiencia de compra y asesoría a nuestros y nuestras clientes</p>
			</div>
		</div>
		<!-- //container -->
	</div>
	<!-- //welcome -->
	<!-- slider -->
	<div class="slider">
		<div class="arrival-grids wthree-grids">			 
			 <ul id="flexiselDemo1">
				 <li>
					 <a href="single.html"><img src="images/s1.jpg" alt=""/>
					 </a>
				 </li>
				 <li>
					 <a href="single.html"><img src="images/s2.jpg" alt=""/>
					 </a>
				 </li>
				 <li>
					 <a href="single.html"><img src="images/s3.jpg" alt=""/>
					 </a>
				 </li>
				 <li>
					 <a href="single.html"><img src="images/s4.jpg" alt=""/>
					 </a>
				 </li>
				 <li>
					 <a href="single.html"><img src="images/s1.jpg" alt=""/>
					 </a>
				 </li>
				 <li>
					 <a href="single.html"><img src="images/s2.jpg" alt=""/>
					 </a>
				 </li>
				</ul>
				<script type="text/javascript">
				 $(window).load(function() {			
				  $("#flexiselDemo1").flexisel({
					visibleItems: 4,
					animationSpeed: 1000,
					autoPlay: true,
					autoPlaySpeed: 3000,    		
					pauseOnHover:true,
					enableResponsiveBreakpoints: true,
					responsiveBreakpoints: { 
						portrait: { 
							changePoint:480,
							visibleItems: 1
						}, 
						landscape: { 
							changePoint:640,
							visibleItems: 2
						},
						tablet: { 
							changePoint:768,
							visibleItems: 3
						}
					}
				});
				});
				</script>
				<script type="text/javascript" src="js/jquery.flexisel.js"></script>			 
		</div>
	</div>
	<!-- //slider -->
</asp:Content>
