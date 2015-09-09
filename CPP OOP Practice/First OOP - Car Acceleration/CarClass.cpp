//Homework 14-2 Melissa Cunningham
//Car Design Class

  #include <iostream>
  #include <string>
   using namespace std;



class CarDesign
{
    private:
    //Field declarations
    int yearModel;
    string make;
    int speed;

    public:
    //Constructor
    CarDesign(int yModel, string carMake, int carSpeed)
    {
        yearModel = yModel;
        make = carMake;
        speed = carSpeed;

    } //end constructor

    //Mutators
    void setYearModel(int yModel)
    {
        yearModel = yModel;
    }//end setYearModel

    void setMake (string carMake)
    {
        make = carMake;
    }//end setMake

    void  setSpeed (int carSpeed)
    {
        speed = carSpeed;
    } //end setSpeed

    //Accessor Methods
    int getYearModel()
    {
        return yearModel;
    } //end getYearModel

    string getMake()
    {
        return make;
    } //end getMake

    int getSpeed()
    {
        return speed;
    } //end getSpeed

    int accelerate(int acceleration)
    {
        speed = speed + acceleration;
        return speed;
    } //end accelerate

    int slow(int acceleration)
    {
        speed = speed - acceleration;
        return speed;
    } //end slow

}; //end CarDesign class
