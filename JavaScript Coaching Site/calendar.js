/*
   JavaScript Project: Red Arrow Racing

   Author: Melissa Cunningham      

   Filename:  calendar.js
   
 */
var race1 = new Date("March 28, 2015");
var race2 =  new Date("April 12, 2015");
var race3 = new Date("June 26, 2015");
var race4 = new Date("May 2, 2015");
var race5 = new Date("May 24, 2015");
var raceDates = new Array(race1, race2, race3, race4, race5);
var raceNames = new Array("Silverman", "Quassy", "Vegas", "St Andrews", "Boulder");
	
 //Create a month calendar based on date
function calendar(calendarDay)
{
	//Use current date if it's not entered
	if(calendarDay == null) calDate = new Date();
		else calDate = new Date(calendarDay);
	//Write out the calendar HTML code
	document.write("<table class=\"calendar\">");
	writeCalTitle(calDate);
	writeDayNames();
	writeCalDays(calDate);
	document.write("</table>");
}
//Write out the month title section of the calendar
function writeCalTitle(calendarDay)
{
	//Enter all the possible months
	var monthName = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
	//Get the month based on the date
	var thisMonth = calendarDay.getMonth();
	//Get the year based on the date
	var thisYear = calendarDay.getFullYear();
	
	//Write out the month headers
	document.write("<tr class=\"calendarRow\">");
	document.write("<th colspan='7'>");
	document.write(monthName[thisMonth]+" "+thisYear);
	document.write("</th>");
	document.write("</tr>");
}
//Write out the day of week headers
function writeDayNames()
{
	//Enter all possible days of week
	var dayName = new Array("Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat");
	//Write out the days of the week as headers
	document.write("<tr class=\"calendarRow\">");
	for (var i=0; i < dayName.length; i++)
	{
		document.write("<th> "+dayName[i]+"</th>");
	}
	document.write("</tr>");
}
//Figure out the number of days in the month
function daysInMonth(calendarDay)
{
	//Get the year based on the date
	var thisYear = calendarDay.getFullYear();
	//Get the month based on the date
	var thisMonth = calendarDay.getMonth();
	//Make a list of the number of days for each month
	var dayCount = new Array(31,28,31,30,31,30,31,31,30,31,30,31);
	//Figure out if it's a leap year. If so, give the Feb days =29
	if (thisYear % 4 == 0)
	{
		if((thisYear % 100 != 0) || (thisYear % 400 == 0))
		{
			dayCount[1] = 29;
		}
	}
	//Return the number of days
	return dayCount[thisMonth];
}
//Write out the days in the month
function writeCalDays(calendarDay)
{
	//Get the date
	var currentDay = calendarDay.getDate();
	
	//Get the year and month (to determine if a day is a race day)
	var year = calendarDay.getFullYear();
	var month = calendarDay.getMonth();
	
	//Start on Sunday (1)
	var dayCount = 1;
	//Figure out the total days in the month
	var totalDays = daysInMonth(calendarDay);
	//Set the date to the first day of the month
	calendarDay.setDate(1);
	//Get the day of the week for that day
	var weekDay = calendarDay.getDay();
	//Write blank days for the part of the week that's not part of the month
	document.write("<tr>");
	for (var i=0; i < weekDay; i++)
	{
		document.write("<td class=\"calendarCell\"></td>");
	}
	//Write days for each day of the month
	while (dayCount <= totalDays)
	{			
		if (weekDay == 0) document.write("<tr class=\"calendarRow\">");
			//Show if a date is a race day
			if(isRaceDay(year, month, dayCount) && dayCount == currentDay)
			{
				document.write("<td class=\"calendarCellRaceDay\">"+"Today's Race: "+getRaceName(year, month, dayCount)+"</td>");
			}
			else if(isRaceDay(year, month, dayCount))
			{
				document.write("<td class=\"calendarCellRaceDay\">"+getRaceName(year, month, dayCount)+"</td>");
			}
			//Show if a date is the current date
			else if(dayCount == currentDay)
			{
				document.write("<td class=\"calendarCellToday\">"+dayCount+"</td>");
			}
			//Format other dates
			else{
				document.write("<td class=\"calendarCell\">"+dayCount+"</td>");
			}
			
		if (weekDay == 6) document.write("</tr>");

		dayCount++;
		calendarDay.setDate(dayCount);
		weekDay = calendarDay.getDay();
	}
	document.write("</tr>");
}

//Find out if date is a race day
function isRaceDay(year, month, day) {
	var isDay = false;
	for (var d=0; d<raceDates.length; d++)
	{
		if(raceDates[d].getFullYear() == year && raceDates[d].getMonth() == month && raceDates[d].getDate() == day) isDay=true;
	}
	return isDay;
}

//Function to get name of race
function getRaceName(year, month, day) {
	for (var r=0; r<raceDates.length; r++)
	{
		if(raceDates[r].getFullYear() == year && raceDates[r].getMonth() == month && raceDates[r].getDate() == day)
		{
			return raceNames[r];
		}
	}
}

