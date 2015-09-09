/*
   JavaScript Project: Red Arrow Racing

   Author: Melissa Cunningham      

   Filename:  calendar.js
   
 */

function addEvent(object, evName, fnName, cap) {
   if (object.attachEvent)
       object.attachEvent("on" + evName, fnName);
   else if (object.addEventListener)
       object.addEventListener(evName, fnName, cap);
}
//Load the setupSlideshow function on first load
addEvent(window, "load", setupSlideshow, false);

function setupSlideshow() {
	var slides = new Array();
	//Look at each image on page
	for (var i=0; i<document.images.length; i++) {
		//Assign thumb as the image
		var thumb = document.images[i];
		//If the class is slide and it's a link, add to slides array
		if (thumb.className == "slide" && thumb.parentNode.tagName == "A") {
			slides.push(thumb);
		}
	}
	//Go through each image in slides array
	for (var i=0; i<slides.length; i++) {
		//Make rollover image
		createRollover(slides[i]);
		//Make high res image
		createHighRes(slides[i], i);
	}
	//Ass long as there are images
	if (slides.length > 0) {
		//Create the gallery and the overlay
		createGallery(slides);
		createOverlay();
	}	
	//Add event handler for keys - esc key closes the slideshow
	addEvent(document, "keydown", keyShow, false);
}
//Show big image on click
function createHighRes(thumb, index) {
	thumb.big = new Image();
	//Replace thumb version with big image version
	thumb.big.src = thumb.src.replace(/_thumb/, "");
	//Show the gallery if clicked
	thumb.onclick = showGallery;
	//Change image index to passed index
	thumb.big.index = index;
}

//Make function that happens when mouseover
function createRollover(thumb) {
	//Assign which image should show - thumb vs over
	thumb.out = new Image();
	thumb.over = new Image();	
	thumb.out.src = thumb.src;
	thumb.over.src = thumb.src.replace(/_thumb/, "_over");
	//Show thumb image when not rolling over
	thumb.onmouseout = function() {
		thumb.src = thumb.out.src;
	}
	//Show over image on mouseover
	thumb.onmouseover = function() {
		thumb.src = thumb.over.src;
	}
}
//Create galler of images
function createGallery(slides) {
	//Create a new div with id galleryBox
	var galleryBox = document.createElement("div");
	galleryBox.id = "galleryBox";
	//Create a new paragraph with id galleryTitle
	var galleryTitle = document.createElement("p");
	galleryTitle.id = "galleryTitle";
	//Create a close button that fades out the image popup
	var closeButton = document.createElement("input");
	closeButton.type = "image";
	closeButton.src = "img/closeButton.png";
	closeButton.onclick = function() {
		fadeOut("galleryBox", 100, 0.5, 0);
		fadeOut("pageOverlay", 80, 0.5, 0);
		setTimeout(function() {
			galleryBox.style.display = "none";
			document.getElementById("pageOverlay").style.display = "none";
		}, 500);
		
	}
	//Add close button to the galleryTitle paragraph
	galleryTitle.appendChild(closeButton);
	//Add the galleryBox div to the galleryTitle paragraph
	galleryBox.appendChild(galleryTitle);
	//Create a new image element and append it to galleryBox
	var slide = document.createElement("img");
	slide.id = "gallerySlide";
	slide.src = slides[0].big.src;
	slide.index = 0;
	galleryBox.appendChild(slide);
	//Add a paragraph element for the description of the image
	var slideCaption = document.createElement("p");
	slideCaption.id = "slideCaption";
	slideCaption.innerHTML = slides[0].alt;
	galleryBox.appendChild(slideCaption);
	//Add another paragraph element for the footer text
	var galleryFooter = document.createElement("p");
	galleryFooter.id = "galleryFooter";
	//Make a back button
	var slideBack = document.createElement("input");
	slideBack.type = "image";
	slideBack.src = "img/back.png";
	slideBack.onclick = function() {
		var currentSlide = document.getElementById("gallerySlide");
		var currentIndex = currentSlide.index;
		currentIndex--;
		if (currentIndex == -1) currentIndex = slides.length - 1;
		
		changeSlide(slides[currentIndex]);
	}
	//Add the back button
	galleryFooter.appendChild(slideBack);
	//Add an element for keeping track of which slide you are on
	var slideNum = document.createElement("span");
	slideNum.id = "slideNumber";
	slideNum.innerHTML = "1";
	
	var slideTotal = document.createTextNode(" of " + slides.length);
	galleryFooter.appendChild(slideNum);
	galleryFooter.appendChild(slideTotal);
	//Add a forward button
	var slideForward = document.createElement("input");
	slideForward.type = "image";
	slideForward.src = "img/forward.png";
	slideForward.onclick = function() {
		var currentSlide = document.getElementById("gallerySlide");
		var currentIndex = currentSlide.index;
		currentIndex++;
		if (currentIndex == slides.length) currentIndex = 0;
		changeSlide(slides[currentIndex]);
	}
	galleryFooter.appendChild(slideForward);	
	galleryBox.appendChild(galleryFooter);	
	document.body.appendChild(galleryBox);
}
//Show the gallery
function showGallery() {
	changeSlide(this);
	
	setOpacity("galleryBox", 0);
	setOpacity("pageOverlay", 0);
	document.getElementById("galleryBox").style.display = "block";
	document.getElementById("pageOverlay").style.display = "block";
	fadeIn("galleryBox", 100, 0.5, 0);
	fadeIn("pageOverlay", 80, 0.5, 0);
	return false;
}
//Show the next slide
function changeSlide(slide) {
	//Get galleryBox, lastSlide, caption and slide number
	var galleryBox = document.getElementById("galleryBox");
	var lastSlide = document.getElementById("gallerySlide");
	var slideCaption = document.getElementById("slideCaption");
	var slideNum = document.getElementById("slideNumber");
	//Set opacity of gallerySlide to 0
	setOpacity("gallerySlide", 0);
	//Make the next slide based on the last one
	var nextSlide = lastSlide.cloneNode(true);
	nextSlide.src = slide.big.src;
	nextSlide.index = slide.big.index;
	galleryBox.replaceChild(nextSlide, lastSlide);
	//Fade the transition
	fadeIn("gallerySlide", 100, 0.5, 0);
	//Add the alt text and increase the index
	slideCaption.innerHTML = slide.alt;
	slideNum.innerHTML = nextSlide.index + 1;
}
//Make the overlay
function createOverlay() {
	var pageOverlay = document.createElement("div");
	pageOverlay.id = "pageOverlay";	
	document.body.appendChild(pageOverlay);
}
//Set the opacity based on the passed value
function setOpacity(objID, value) {
	var object = document.getElementById(objID);
	object.style.filter = "alpha(opacity = " + value + ")";
	object.style.opacity = value/100;
}
//Fade in according to arguments
function fadeIn(objID, maxOpacity, fadeTime, delay) {
	var fadeInt = Math.round(fadeTime*1000)/maxOpacity;
	for (var i=0; i<=maxOpacity; i++)
	{
		setTimeout("setOpacity('" + objID + "', " + i + ")", delay);
		delay += fadeInt;
	}
}
//Fade out according to arguments
function fadeOut(objID, maxOpacity, fadeTime, delay) {
	var fadeInt = Math.round(fadeTime*1000)/maxOpacity;

	for (var i = maxOpacity; i>=0; i--) {
		setTimeout("setOpacity('" + objID + "', " + i + ")", delay);
		delay += fadeInt;
	}
}

//Respond to esc key click in slideshow
function keyShow(e)
{
	var evt = e || window.event;
	var key = evt.keyCode;
	
	if (key == 27) close();
}
//Close slideshow when Esc key is pressed
function close() {
		fadeOut("galleryBox", 100, 0.5, 0);
		fadeOut("pageOverlay", 80, 0.5, 0);
		setTimeout(function() {
			galleryBox.style.display = "none";
			document.getElementById("pageOverlay").style.display = "none";
		}, 500);
		
	}