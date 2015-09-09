// Homework 7-3 Melissa Cunningham

  #include <iostream>
  #include <cstdlib>
   using namespace std;

   //Declare methods
   void getFat(double &fGrams);
   void getCalories(double &nCalories, double &fatGrams);
   void calculateCaloriesFromFat(double &fGrams, double &nCalories, double &fCalories, string &rOrQuit);

   //Declare constants
   const double FAT_MULTIPLIER = 9.0;
   const double FAT_MIN = 0.0;
   const double LOW_FAT = 0.3;
   const double PERCENT_MULTIPLIER = 100.0;
   const double LOW_FAT_PERCENT = LOW_FAT * PERCENT_MULTIPLIER;

   int main()
   {
    //Delcare variables
    double fatGrams;
    double numberCalories;
    double fatCalories;

    //Delcare and initialize resetOrQuit to start out going into the while loop
    string resetOrQuit = "c";

    //Intro text
    cout << "This program calculates the % of calories from fat in a food, " << endl;
    cout << "and signals when a food is low fat." << endl;
    cout << "When asked..." << endl;
    cout << "enter the number of fat grams and calories in the food." << endl;

    //Set up program to repeat until asked to stop
    while(resetOrQuit == "c")
        {
                //Get fat grams from user
                getFat(fatGrams);

                //Get calories from user
                getCalories(numberCalories, fatGrams);

                //Calculate and display calories from fat
                calculateCaloriesFromFat(fatGrams, numberCalories, fatCalories, resetOrQuit);
        }//end resetOrQuit loop

    //Good bye message at end of program
    cout << "Good Bye" << endl;

    system("Pause");
    return 0;

   } //end main()

   //Method to get fat input
   void getFat(double &fGrams)
   {
        //Ask user to input fat
        cout << "Enter the number of fat grams (not less than " << FAT_MIN << " grams): " << endl;
        cin >> fGrams;

        //Show error and ask to re-enter if input is invalid
        while(fGrams < FAT_MIN)
        {
            cout << "Fat grams can not be less than " << FAT_MIN << ". Please re-enter fat grams." << endl;
            cin >> fGrams;
        }//end fatGrams error message
   }// end getFat()

   //Method to get user to input calories
   void getCalories(double &nCalories, double &fGrams)
   {
        //Calculate max calories allowed
        double maxCalories = fGrams * FAT_MULTIPLIER;
        //Ask for user to enter calories
        cout << "Enter the number of calories (MUST exceed " << maxCalories << " (fat grams X " << FAT_MULTIPLIER << ")) " << endl;
        cin >> nCalories;

        //Show error and ask to re-enter if input is invalid
        while(nCalories <= maxCalories)
        {
            cout << "Calories must exceed " << maxCalories << ". Please re-enter calories." << endl;
            cin >> nCalories;
        }//end calories error message

   }// end getCalories()

   //Method to calculate and display calories from fat and if low fat and if want to quit or continue
   void calculateCaloriesFromFat(double &fGrams, double &nCalories, double &fCalories, string &rOrQuit)
   {
        //Calculate calories from fat
        fCalories = (fGrams * FAT_MULTIPLIER) / nCalories;
        //Turn the above number into a percent
        double percentFat = fCalories * PERCENT_MULTIPLIER;
        //Display message if food is low fat
        if(fCalories < LOW_FAT)
        {
            cout << "This food is considered low fat because the percentage of fat: " << percentFat << "%, is below " << LOW_FAT_PERCENT << "%." << endl;
        }//end if low fat
        //Otherwise display details on fat percent
        else
        {
            cout << "The percentage of fat in this food is: " << percentFat << "%." << endl;
        }//end otherwise display fat percent

        //Ask if user wants to continue or quit
        cout << "Press 'c' to continue OR 'q' to QUIT.";
        //Input user's answer
        cin >> rOrQuit;

   }// end calculateCaloriesFromFat()
