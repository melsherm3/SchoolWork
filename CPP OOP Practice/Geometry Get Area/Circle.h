//Homework 11 Melissa Cunningham
//Circle Class
#ifndef CIRCLE_H_INCLUDED
#define CIRCLE_H_INCLUDED
#include <iostream>
#include <string>
#include "Shape.h"
    using namespace std;

//Declare constant
const double PIE = 3.14159;

class Circle : public Shape
{
    private:
        //Declare variable
        double radius;
        //Accessor
        double calcArea()
        {
            //declare and calculate area
            double cArea = PIE * (radius * radius);
            return cArea;
        } //end Accessor

    public:
        //Constructor
        Circle(double aRadius)
        {
            //Give value to radius
            radius = aRadius;
            //Set the area using calcArea()
            setArea(calcArea());

        } //end constructor

}; //end Circle class


#endif // CIRCLE_H_INCLUDED
