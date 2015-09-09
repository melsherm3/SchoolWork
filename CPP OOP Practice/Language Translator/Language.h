//Homework 11 Melissa Cunningham
//Language Class
#ifndef LANGUAGE_H_INCLUDED
#define LANGUAGE_H_INCLUDED
#include <iostream>
#include <string>
    using namespace std;

class Language
{
    private:
        //Field declarations
        string goodMorning;

    public:

        //Mutator
        void setGoodMorning (string gMorning)
        {
            //Set the goodMorning value
            goodMorning = gMorning;
        }//end setGoodMorning

        //Accessor Methods
        string getGoodMorning()
        {
            return goodMorning;
        } //end getGoodMorning

}; //end Language class


#endif // LANGUAGE_H_INCLUDED
