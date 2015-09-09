//Homework 11 Melissa Cunningham
//Triangle Class
#ifndef TRIANGLE_H_INCLUDED
#define TRIANGLE_H_INCLUDED
#include <iostream>
#include <string>
#include "Shape.h"
    using namespace std;

//Declare constant
const double HALF = 0.5;

class Triangle : public Shape
{
    private:
        //Declare variables
        double tBase;
        double tHeight;
        //Accessor
        double calcArea()
        {
            //Declare and calculate the area
            double tArea = tBase * tHeight * HALF;
            return tArea;
        } //end Accessor

    public:
        //Constructor
        Triangle(double aBase, double aHeight)
        {
            //Give value to base and height
            tBase = aBase;
            tHeight = aHeight;
            //Set the area using calcArea()
            setArea(calcArea());

        } //end constructor

}; //end Triangle class


#endif // TRIANGLE_H_INCLUDED
