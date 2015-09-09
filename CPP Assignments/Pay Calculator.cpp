// Homework 7-1 Melissa Cunningham

  #include <iostream>
  #include <cstdlib>
   using namespace std;

   //Declare methods
   void getHourlyRate (double &hRate);
   void getHoursWorked (double &hWorked);
   void calculatePay (double &gPay, double &hRate, double &hWorked);

   //Declare constants
   const double MIN_PAY_RATE = 7.5;
   const double MAX_PAY_RATE = 18.25;
   const double MIN_HOURS = 0.0;
   const double MAX_HOURS = 40.0;

   int main()
   {
    //Declare variables
    double hourlyRate;
    double hoursWorked;
    double grossPay;

    //Ask user to input hourly rate
    getHourlyRate(hourlyRate);

    //Ask User to input hours worked
    getHoursWorked(hoursWorked);

    //Calculate and display the pay
    calculatePay(grossPay, hourlyRate, hoursWorked);

    system("Pause");
    return 0;

   } //end main()

   //Method to get hourly rate
   void getHourlyRate (double &hRate)
   {
       //Ask for and then get the hourly rate
       cout << "Enter the pay rate (between " << MIN_PAY_RATE << " and " << MAX_PAY_RATE << " ): " << endl;
       cin >> hRate;

       //Make sure the user enters a valid rate. If not, show error message and ask them to re-enter.
       while (hRate < MIN_PAY_RATE || hRate > MAX_PAY_RATE)
       {
            cout << "The pay rate must be between " << MIN_PAY_RATE << " and " << MAX_PAY_RATE <<". Enter a valid rate."<< endl;
            cin >> hRate;
       }//end pay rate validation
   }//end getHourlyRate

   //Method to get hours worked
   void getHoursWorked (double &hWorked)
   {
       //Ask for and then get the hours worked
       cout << "Enter the hours worked (between " << MIN_HOURS << " and " << MAX_HOURS << " ): " << endl;
       cin >> hWorked;

       //Make sure user enters a valid amount of hours. If not, show error message and ask them to re-enter.
       while (hWorked < MIN_HOURS || hWorked > MAX_HOURS)
       {
           cout << "The hours worked must be between " << MIN_HOURS << " and " << MAX_HOURS << ". Enter a valid number of hours." << endl;
           cin >> hWorked;
       }//end hourly validation
   }//end getHoursWorked()

   //Method to calculate and display pay
   void calculatePay (double &gPay, double &hRate, double &hWorked)
   {
       //Calculate gross pay
       gPay = hRate * hWorked;
       //Display gross pay
       cout << "Gross Pay is: $" << gPay << "." << endl;
   }//end calculatePay()
