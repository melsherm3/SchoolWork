//Homework 11 Melissa Cunningham
//Shape Class

#ifndef SHAPE_H_INCLUDED
#define SHAPE_H_INCLUDED
#include <iostream>
#include <string>
    using namespace std;

class Shape
{
    private:
        //Field declarations
        double area;

    public:
        //Mutator
        void setArea (double anArea)
        {
            //Give area a value
            area = anArea;
        }//end setArea

        //Accessor Method
        double getArea()
        {
            return area;
        } //end getArea

}; //end Shape class


#endif // SHAPE_H_INCLUDED
