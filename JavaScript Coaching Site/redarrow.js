/*
   JavaScript Project: Red Arrow Racing

   Author: Melissa Cunningham      

   Filename:  redarrow.js
   
 */

//Function for load function
function addEvent(object, evName, fnName, cap) {
   if (object.attachEvent)
       object.attachEvent("on" + evName, fnName);
   else if (object.addEventListener)
       object.addEventListener(evName, fnName, cap);
}

//Add init function when page is loaded
addEvent(window, "load", init, false);

//Starting slider image number
var imageNumber = 1;
//Total number of slider images
var total = 3;

function init()
{
	//Add in the HTML for the menu and header
	makeHeader();
	//Make an array that contains the items in each tab and set changes when scrolling over them
	//Declare empty array
	var navTabs = new Array();
	//Store all elements in array called allElems
	var allElems = document.getElementsByTagName("*");
	
	//Loop through all elements and push items in tab class to the navTabs array
	for (var i = 0; i < allElems.length; i++)
	{
		if (allElems[i].className == "tab")
			navTabs.push(allElems[i]);
	}
	
	//For every item in the navTabs array, add an onlick event handler that runs the showTab() function
	for (var j = 0; j < navTabs.length; j++)
	{
		navTabs[j].onmouseover = showTab;
		navTabs[j].onmouseout = hideTab;
	}
	
	//Homepage Slider code
	//Get the left and right arrow images
	var rArrow = document.getElementById("rightarrow");
	var lArrow = document.getElementById("leftarrow");
	//Change the cursor when mouseover
	rArrow.style.cursor = "pointer";
	lArrow.style.cursor = "pointer";
	//Add slide change when image is clicked
	rArrow.addEventListener("click", function() {slider(1);});
	lArrow.addEventListener("click", function() {slider(-1);});	
	//Run automatic slider function
	window.setInterval(autoslider, 5000);
}

//Make Header / Menu Section
function makeHeader() 
{
	var headerDiv = document.getElementById("header");
	var header = '<a href="home.html" target="top"><img src="img/logo-white.png" /></a>\
            <div class="social">\
                <a class="nounderline" onclick="twitterPopup()" target="_new"><img src="img/twitter.png" /></a>\
                <a class="nounderline" onclick="facebookPopup()" target="_new"><img src="img/facebook.png" /></a>\
                <a class="nounderline" onclick="linkedInPopup()" target="_new"><img src="img/linkedin.png" /></a>\
            </div>\
		<ul class="nav">\
         <li class="tab" style="color: #560202;"><a href="home.html" target="top">HOME</a>\
         </li>\
         <li class="tab"><a href="about.html" target="top">ABOUT</a>\
            <ul style="visibility:hidden;">\
               <li><a href="about.html" target="top">About Richie</a></li>\
               <li><a href="coaching-resume.html" target="top">Coaching Resume</a></li>\
               <li><a href="career-highlights.html" target="top">Career Highlights</a></li>\
            </ul>\
         </li>\
		 <li class="tab"><a href="running-calculator.html" target="top">TOOLS</a>\
            <ul style="visibility:hidden;">\
               <li><a href="running-calculator.html" target="top">Running Calculator</a></li>\
			   <li><a href="calendar.html" target="top">Race Calendar</a></li>\
            </ul>\
         </li>\
         <li class="tab"><a href="boulder-coaching.html" target="top">SERVICES</a>\
            <ul style="visibility:hidden;">\
               <li><a href="boulder-coaching.html" target="top">Boulder Coaching</a></li>\
               <li><a href="online-coaching.html" target="top">Online Coaching</a></li>\
               <li><a href="consulting.html" target="top">Consulting</a></li>\
            </ul>\
         </li>\
         <li class="tab"><a href="contact.html" target="top">CONTACT</a>\
         </li>\
      </ul>';
	 headerDiv.innerHTML = header;
}

//Show the dropdown nav
function showTab()
{
	//Create tabList to reference first ul element in this object
	var tabList = this.getElementsByTagName("ul")[0];
	//Make the tabList object visible
	tabList.style.visibility = "visible";
}
//Hide the dropdown nav
function hideTab()
{
	//Create tabList to reference first ul element in this object
	var tabList = this.getElementsByTagName("ul")[0];
	//Make the tabList object hidden
	tabList.style.visibility = "hidden";
}

//Function to use with setInterval for making slideshow go automatically
function autoslider() {
	//Get current slide image
	var image = document.getElementById("slide");
	//Increase the slide image number by one
	imageNumber = imageNumber + 1;	
	//If you are at the end of the list, change back to first image
	if(imageNumber > total)
	{
		imageNumber = 1;
	}
	//If you are past the beginning of the list, change to last image
	if(imageNumber < 1)
	{
		imageNumber = total;
	}
	//Change the image, on a 5000 interval
	image.src = "img/homeimage" + imageNumber + ".jpg";
}

//Slideshow function
function slider(x) {
	//Get current slide image
	var image = document.getElementById("slide");
	//Change the slide number
	imageNumber = imageNumber + x;
	//If you are at the end of the list, change back to first image
	if(imageNumber > total)
	{
		imageNumber = 1;
	}
	//If you are past the beginning of the list, change to last image
	if(imageNumber < 1)
	{
		imageNumber = total;
	}
	//Change the image
	image.src = "img/homeimage" + imageNumber + ".jpg";
}

//Popup window for Twitter
function twitterPopup() {
	return(popWin("twitterWidget.html"));
}

//Popup window for Facebook
function facebookPopup() {
	popWin("https://m.facebook.com/richiecunninghamtri");
}

//Popup window for LinkedIn
function linkedInPopup() {
	popWin("https://www.linkedin.com/profile/view?id=306334523");
}
//Function to deal with popup blockers
function popWin(url) {
	pop = window.open(url, "pop", "width=400, height=400, scrollbars=yes, top=40, left=40");
	testpop = (pop==null || typeof(pop) == "undefined") ? true: false;
	return testpop;
}