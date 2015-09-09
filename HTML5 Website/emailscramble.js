/* 
Melissa Cunningham
HTML Project - JavaScript File for Email Scrambling
7/28/15
*/

//Function to reverse text
function reverse(text){
	if(!text) return '';
	var reverseText='';
	for (i=text.length-1; i>=0; i--)
		reverseText+=text.charAt(i);
	return reverseText;
}

//Show email address
function showEmail(userName, emailServer){
	userName = reverse(userName);
	emailServer = reverse(emailServer);
	var emailLink = userName + "@" + emailServer;
	var emailHTML = "<a href='mailto:" + emailLink + "'>" + emailLink + "</a>";
	document.write(emailHTML);
}