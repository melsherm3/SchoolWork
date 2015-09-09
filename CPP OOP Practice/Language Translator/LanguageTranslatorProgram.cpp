//Homework 11 Melissa Cunningham
//Language Translator Program

  #include <iostream>
  #include <string>
  #include <cstdlib>
  #include "Language.h"
  #include "English.h"
  #include "Italian.h"
  #include "Spanish.h"
  #include "German.h"
   using namespace std;

  //Declare constants
  const int ENGLISH = 1;
  const int ITALIAN = 2;
  const int SPANISH = 3;
  const int GERMAN = 4;
  const int EXIT = 5;

  int main()
   {
        //Declare variable
        int selection;
        //Get the selection and repeatedly ask for it unless user chooses to exit
        do
            {
                cout << "Select a language and I will say Good Morning" << endl;
                cout << ENGLISH << ". English" << endl;
                cout << ITALIAN << ". Italian" << endl;
                cout << SPANISH << ". Spanish" << endl;
                cout << GERMAN << ". German" << endl;
                cout << EXIT << ". End the program" << endl;
                cout << "Enter your selection: ";
                 cin >> selection;

                //Respond to selection
                switch(selection)
                {
                    case ENGLISH:
                        {
                            //Create a new English object
                            English eTranslate;
                            //Get the "Good Morning" translation
                            cout << eTranslate.getGoodMorning() << endl;
                            break;
                        } //end English
                    case ITALIAN:
                       {
                            //Create a new Italian object
                            Italian iTranslate;
                            //Get the "Good Morning" translation
                            cout << iTranslate.getGoodMorning() << endl;
                            break;
                       } //end Italian
                    case SPANISH:
                        {
                            //Create a new Spanish object
                            Spanish sTranslate;
                            //Get the "Good Morning" translation
                            cout << sTranslate.getGoodMorning() << endl;
                            break;
                        } //end Spanish
                    case GERMAN:
                        {
                            //Create a new German object
                            German gTranslate;
                            //Get the "Good Morning" translation
                            cout << gTranslate.getGoodMorning() << endl;
                            break;
                        } //end German
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

            } //end do-while loop
            //Exit loop when exit number is entered
            while (selection != EXIT);

      system("Pause");
      return 0;
   }  //end main()
