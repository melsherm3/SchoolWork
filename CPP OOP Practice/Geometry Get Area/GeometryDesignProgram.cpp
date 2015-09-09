//Homework 11 Melissa Cunningham
//Geometry Design Program

  #include <iostream>
  #include <string>
  #include <cstdlib>
  #include "Shape.h"
  #include "Circle.h"
  #include "Rectangle.h"
  #include "Triangle.h"
   using namespace std;

  //Declare constants
  const int CIRCLE = 1;
  const int RECTANGLE = 2;
  const int TRIANGLE = 3;
  const int EXIT = 4;

  int main()
   {
        //Declare variable
        int selection;
        double aRadius;
        double aLength;
        double aWidth;
        double aBase;
        double aHeight;
        //Get the selection and repeatedly ask for it unless user chooses to exit
        do
            {
                cout << "Geometry Calculator" << endl;
                cout << CIRCLE << ". Calculate the area of a circle." << endl;
                cout << RECTANGLE << ". Calculate the area of a rectangle." << endl;
                cout << TRIANGLE << ". Calculate the area of a triangle." << endl;
                cout << EXIT << ". End the program" << endl;
                cout << "Enter your selection: ";
                 cin >> selection;

                //Respond to selection
                switch(selection)
                {
                    case CIRCLE:
                        {
                            //Get the radius
                            cout << "Enter the radius of the circle: " << endl;
                            cin >> aRadius;
                            //Create a circle object
                            Circle myCircle(aRadius);
                            //Return the area
                            cout << myCircle.getArea() << endl;
                            break;
                        } //end circle
                    case RECTANGLE:
                       {
                            //Get the length and width
                            cout << "Enter the length and width of the rectangle: "<< endl;
                            cin >> aLength >> aWidth;
                            //Create a rectangle object
                            Rectangle myRectangle(aLength, aWidth);
                            //Return the area
                            cout << myRectangle.getArea() << endl;
                            break;
                       } //end rectangle
                    case TRIANGLE:
                        {
                            //Get the base and height
                            cout << "Enter the base and height of the triangle: "<< endl;
                            cin >> aBase >> aHeight;
                            //Create a triangle object
                            Triangle myTriangle(aBase, aHeight);
                            //Return the area
                            cout << myTriangle.getArea() << endl;
                            break;
                        } //end triangle
                    case EXIT:
                        {
                            //say good bye
                            cout << "Good Bye" << endl;
                            break;
                        } //end Exit
                    default:
                        {
                            // Display an error message.
                            cout << "That is an invalid selection." << endl;
                        } //end Default

                } //end switch


            } //end loop
            //Exit loop when exit number is entered
            while (selection != EXIT);

      system("Pause");
      return 0;
   }  //end main()
