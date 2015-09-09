//Homework 11 Melissa Cunningham
//Rectangle Class
#ifndef RECTANGLE_H_INCLUDED
#define RECTANGLE_H_INCLUDED
#include <iostream>
#include <string>
#include "Shape.h"
    using namespace std;

class Rectangle : public Shape
{
    private:
        //Declare variables
        double rLength;
        double rWidth;
        //Accessor
        double calcArea()
        {
            //Declare and calculate the area
            double rArea = rLength * rWidth;
            return rArea;
        } //end Accessor

    public:
        //Constructor
        Rectangle(double aLength, double aWidth)
        {
            //Give value to length and width
            rLength = aLength;
            rWidth = aWidth;
            //Set the area using calcArea()
            setArea(calcArea());

        } //end constructor

}; //end Rectangle class


#endif // RECTANGLE_H_INCLUDED
