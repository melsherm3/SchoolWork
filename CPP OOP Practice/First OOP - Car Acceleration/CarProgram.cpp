//Homework 14-2 Melissa Cunningham
//Car Design Program

  #include <iostream>
  #include <string>
  #include <cstdlib>

  #include "CarClass.cpp"
   using namespace std;

   //Declare constants
   int START_SPEED = 0;
   int ACCELERATE_SPEED = 5;
   int ACCELERATIONS = 30;
   int LOOP_START = 0;

   int main()
   {
      // Declare variables
      int year;
      string make;
      int speed = START_SPEED;
      int i;

      // Get variable values
      cout << "Enter the car's year" << endl;
      cin >> year;
      cout << "Enter the car's make" << endl;
      cin >> make;

      // Create an object and initializes its fields with the values passed to the constructor.
      CarDesign myCar (year, make, speed);

      // Display the values stored in the fields.
      cout << "The car's year is " << myCar.getYearModel() << endl;
      cout << "The car's make is " << myCar.getMake() << endl;
      cout << "The speed is " << myCar.getSpeed() << endl;

      //Accelerate results
      cout << "Let's see what it can do!" << endl;
      cout << "The speed is... " <<  endl;

      //Show each speed
      for (i=LOOP_START; i<ACCELERATIONS; i++)
      {
          cout << myCar.accelerate(ACCELERATE_SPEED) << " ";
      } //end accelerate loop
      cout << endl;

      //Start deceleration
      cout << "STOP! STOP! LET ME OUT!!!" << endl;
      cout << "The speed is... " <<  endl;

      //Show each speed
      for (i=LOOP_START; i<ACCELERATIONS; i++)
      {
          cout << myCar.slow(ACCELERATE_SPEED) << " ";
      } //end slow down loop
      //Ending message
      cout << endl;
      cout << "Whew! I'll just walk from here thanks." << endl;

      system("Pause");
      return 0;
   }  //end main()
