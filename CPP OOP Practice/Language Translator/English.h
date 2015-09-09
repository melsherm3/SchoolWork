//Homework 11 Melissa Cunningham
//English Translate Class
#ifndef ENGLISH_H_INCLUDED
#define ENGLISH_H_INCLUDED
#include <iostream>
#include <string>
#include "Language.h"
    using namespace std;

class English : public Language
{
    public:
        //Constructor
        English()
        {
            //Local variable to hold translation
            string goodMorning = "Good Morning";
            //Save the translation
            setGoodMorning(goodMorning);
        } //end constructor

}; //end English class


#endif // ENGLISH_H_INCLUDED
