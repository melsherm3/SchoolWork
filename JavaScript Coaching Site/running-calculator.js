/*
   JavaScript Project: Red Arrow Racing

   Author: Melissa Cunningham      

   Filename:  running-calculator.js
   
 */
 //Function for running calculator
function calculate() {
	
	//Get the entries from the user input
	var distance = Number(document.getElementById("distance").value);
	var hours = Number(document.getElementById("hours").value);
	var minutes = Number(document.getElementById("minutes").value);
	var seconds = Number(document.getElementById("seconds").value);
	
	//Calculate the amount of minutes and seconds
	var totalMinutes = minutes + hours*60;
	var totalSeconds = seconds + totalMinutes*60;
	
	//Calculate the paces
	var secondsPerMile = totalSeconds/distance;
	var hourPaceDecimal = secondsPerMile/3600;
	var hourPace = timeFormat(Math.floor(hourPaceDecimal));
	var minutePaceDecimal = 60*(hourPaceDecimal - hourPace);
	var minutePace = timeFormat(Math.floor(minutePaceDecimal));
	var secondPace = timeFormat(Math.round(60*(minutePaceDecimal-minutePace)));
	
	//Get the paragraph with the "pace" id and enter the resulting pace there
	pace = document.getElementById("pace");
	pace.style.color="red";
	//Show error if user did not enter a number
	if (isNaN(hourPace) || isNaN(minutePace) || isNaN(secondPace))
		pace.innerHTML = "You must enter only numbers.";
	else
		pace.innerHTML = "The pace is: " + " " + hourPace + ":" + minutePace + ":" + secondPace + " per mile.";
	
	//Show zero before number if it's less than 10
	function timeFormat(time) {
		return (time<10) ? ("0" + time) : time;
	}
}

//Calculator object
var calculator = {
	bgColor: "",
	changeBgColor : function(color) {
		var box = document.getElementById("calculator");
		box.style.backgroundColor = color;
		bgColor = color;
	},
	announceColor : function() {
		if (typeof bgColor == "undefined")
		{
			alert("#f0f0f0");
		}
		else 
		{
			alert(bgColor);			
		}

	}
};

