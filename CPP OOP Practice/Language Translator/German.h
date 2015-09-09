//Homework 11 Melissa Cunningham
//German Translate Class
#ifndef GERMAN_H_INCLUDED
#define GERMAN_H_INCLUDED
#include <iostream>
#include <string>
#include "Language.h"
    using namespace std;

class German : public Language
{
    public:
        //Constructor
        German()
        {
            //Local variable to hold translation
            string goodMorning = "Guten morgen";
            //Save the translation
            setGoodMorning(goodMorning);
        } //end constructor

}; //end German class


#endif // GERMAN_H_INCLUDED
