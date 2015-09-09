//Homework 11 Melissa Cunningham
//Italian Translate Class
#ifndef ITALIAN_H_INCLUDED
#define ITALIAN_H_INCLUDED
#include <iostream>
#include <string>
#include "Language.h"
    using namespace std;

class Italian : public Language
{
    public:
        //Constructor
        Italian()
        {
            //Local variable to hold translation
            string goodMorning = "Buongiorno";
            //Save the translation
            setGoodMorning(goodMorning);
        } //end constructor

}; //end Italian class

#endif // ITALIAN_H_INCLUDED
