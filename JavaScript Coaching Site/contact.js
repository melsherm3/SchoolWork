/*
   JavaScript Project: Red Arrow Racing

   Author: Melissa Cunningham      

   Filename:  contact.js
   
 */
//Run formSetup function on load
addEvent(window, "load", formSetup, false);

function formSetup() 
{
	//When submit button is pressed, run checkContactForm function
	document.getElementById("saveContact").onclick = addCookies;
	document.forms[0].onsubmit = checkContactForm;
	
	//Get cookies for user contact info if it's there
	if (getCookie("cphone")) {
		var allInputs = document.getElementsByTagName("input");
		for (var i=0; i<allInputs.length; i++) {
			if (allInputs[i].type == "text") {
				if (getCookie(allInputs[i].id)) {
					allInputs[i].value = getCookie(allInputs[i].id);
				}
			}
		}
	}
	
	//Scramble the email address
	var emailAdd = showEmail("37ceihcir", "moc.liamtoh");
	document.getElementById("emailAddress").innerHTML = emailAdd;
	
	//Show when page was last updated
	var lastUpdate = new Date(document.lastModified);
	lastUpdate = writeDateString(lastUpdate);
	
	var lastUpdateDiv = document.createElement("div");
	lastUpdateDiv.id = "lastUpdate";
	lastUpdateDiv.innerHTML = "<p><br />Last Updated: " + lastUpdate + "</p>";
	document.getElementById("contact-info").appendChild(lastUpdateDiv);
	
	//Use focus and blur events to change main image
	var contactName = document.getElementById("cname");
	addEvent(contactName, "focus", changeImage, false);
	addEvent(contactName, "blur", revertImage, false);
}
//Function to add cookies
function addCookies() {
	var expire = new Date();
	expire.setFullYear(expire.getFullYear() + 1);
	//Loop through all of the elements in the contact form
	var allTextFields = document.contactForm.elements;
	for (var i=0; i<allTextFields.length; i++) {
		//For text fields only
		if (allTextFields[i].type == "text") {
			//write input box value to a cookie
			setCookie(allTextFields[i].id, allTextFields[i].value, expire);
		}
	}
	alert("Contact info saved");
}

//Function to check if form is filled out properly
function checkContactForm() {
	if (document.forms[0].name.value.length == 0)
	{
		alert("You must enter a name.");
		return false;
	}
	else if (document.forms[0].phone.value.length == 0)
	{
		alert("You must enter a phone number.");
		return false;
	}
	else if (isPhoneNumber(document.forms[0].phone.value) == false)
	{
		alert("Invalid phone format.");
		return false;
	}
	else if (document.forms[0].email.value.length == 0)
	{
		alert("You must enter an email address.");
		return false;
	}
	else if (isEmail(document.forms[0].email.value) == false)
	{
		alert("Invalid email format.");
		return false;
	}
	else if(document.forms[0].coaching.selectedIndex == 1){
		alert("No Boulder Coaching availability at this time.");
		return false;
	}
	else if(questionExists(document.forms[0].message.value) == true){
		alert("I see you have a question. You may get an immediate answer by checking the Services pages, but I will still submit your question.");
		return true;
	}
		
	else return true;
}
//Check validity of phone number
function isPhoneNumber(phone){
	//Match a US phone number 
	regex = /^(1?(?: |\-|\.)?(?:\(\d{3}\)|\d{3})(?: |\-|\.)?\d{3}(?: |\-|\.)?\d{4})$/;
	return regex.test(phone);
}
//Check validity of email address
function isEmail(email){
	regex = /[a-zA-Z0-9_\.\+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-\.]+/;
	return regex.test(email);
}
//Function to reverse text
function reverse(text){
	if(!text) return '';
	var rText='';
	for (i=text.length-1; i>=0; i--)
		rText+=text.charAt(i);
	return rText;
}
//Show email address
function showEmail(userName, emailServer){
	userName = reverse(userName);
	emailServer = reverse(emailServer);
	var emailLink = userName + "@" + emailServer;
	var emailHTML = "<a href='mailto:" + emailLink + "'>" + emailLink + "</a>";
	return emailHTML;
}

//Write Date Format
function writeDateString(dateObj) {

   var monthName = new Array("Jan", "Feb", "Mar",
  "Apr", "May", "Jun", "Jul", "Aug", "Sep",
  "Oct", "Nov", "Dec");
	
   var thisMonth = dateObj.getMonth();
   var thisYear = dateObj.getFullYear();

   return monthName[thisMonth] + " " + dateObj.getDate() + ", " + thisYear;
}

//Create a cookie
function setCookie(cName, cValue, expDate) {
	if (cName && cValue != "") {
		var cString = cName + "=" + escape(cValue);
		if (expDate) cString += ";expires=" + expDate.toGMTString();
		document.cookie = cString;
	}
}

//Retrieve a cookie
function getCookie(cName) {
	if (document.cookie) {
		var cookiesArray = document.cookie.split("; ");
		for (var i=0; i<cookiesArray.length; i++) {
			if (cookiesArray[i].split("=")[0] == cName) {
				return unescape(cookiesArray[i].split("=")[1]);
			}
		}
	}
}

//Check if a question exists in the comments section
function questionExists(comment) {
	if (comment.indexOf("?", 0) == -1) return false;
	else return true;
}

//Change images
function changeImage() {
	var image = document.getElementById("contactimage");
	image.src = "img/richie-profile2.jpg";
}

//Revert image
function revertImage(image) {	
	var image = document.getElementById("contactimage");
	image.src = "img/richie-profile.jpg";
}
