//Homework 11 Melissa Cunningham
//Spanish Translate Class
#ifndef SPANISH_H_INCLUDED
#define SPANISH_H_INCLUDED
#include <iostream>
#include <string>
#include "Language.h"
    using namespace std;

class Spanish : public Language
{
    public:
        //Constructor
        Spanish()
        {
            //Local variable to hold translation
            string goodMorning = "Buenos dias";
            //Save the translation
            setGoodMorning(goodMorning);
        } //end constructor

}; //end Spanish class


#endif // SPANISH_H_INCLUDED
