// Homework 7-5 Melissa Cunningham

  #include <iostream>
  #include <cstdlib>
  #include <ctime>
  #include <string>
  #include <algorithm>

   using namespace std;

   //Declare constants
   const int MIN = 1;
   const int MAX = 3;
   const int ZERO = 0;
   const int ONE = 1;
   const int TWO = 2;
   const string QUIT_WORD = "q";

   //Declare methods
   void getUserChoice(string &uChoice);
   void playGame(string &uChoice);

   int main()
   {
    //Declare variables
    string userChoice;

    //Get the system time
    unsigned seed = time(0);
    //Seed the random number generator
    srand(seed);

    //Get the user's choise
    getUserChoice(userChoice);

    //Get results of game and start over or quit
    playGame(userChoice);

    system("Pause");
    return 0;

   } //end main()

   //Function to get random choice from computer
   string getComputerChoice()
   {
       //Set randomNumber to zero
       int randomNumber = ZERO;
       //Get a random number for randomNumber
       randomNumber = MIN + rand() % (MAX-MIN+1);

       //Set computerChoice to nothing
       string computerChoice = "";

       //If random number is 1, say rock
       if(randomNumber == ONE)
       {
           computerChoice = "rock";
       }//end rock
       //if random number is 2, say paper
       else if(randomNumber == TWO)
       {
           computerChoice = "paper";
       }//end paper
       //if random number is 3, say scissors
       else
       {
           computerChoice = "scissors";
       }//end scissors

       //send back the random string
       return computerChoice;
   }//end getComputerChoice()

   //Method to get user's choice
   void getUserChoice(string &uChoice)
   {
       //Ask for user's choice and input it
       cout << "Type selection, 'rock', 'paper' OR 'scissors' - '" << QUIT_WORD << "' to QUIT" << endl;
       cin >> uChoice;
       //Convert to lower case
       transform(uChoice.begin(), uChoice.end(), uChoice.begin(), ::tolower);
       //If user's choice is invalid
       while (uChoice != "rock" && uChoice != "paper" && uChoice != "scissors" && uChoice != "q")
       {
           //Tell user it's invalid and ask them to re-enter
           cout << "Sorry, wrong input..." << endl;
           cout << "Type selection, 'rock', 'paper' OR 'scissors' - '" << QUIT_WORD << "' to QUIT" << endl;
           //Input user's choice
           cin >> uChoice;
           //Convert to lower case
           transform(uChoice.begin(), uChoice.end(), uChoice.begin(), ::tolower);
       }//end validation


   }//end getUserChoice()

   //Method to play game - show results or quit
   void playGame(string &uChoice)
   {
       //Give get the computer's random choice
       string cChoice = getComputerChoice();

       //Unless the user enters quit word
       while (uChoice != QUIT_WORD)
       {
            //If the two choices are equal, it's a tie
            if (uChoice == cChoice)
            {
                cout << "TIE" << endl;
            }// end if equal
            //If user chooses rock
            else if (uChoice == "rock")
            {
                //and computer chooses paper, then lose
                if(cChoice == "paper")
                {
                    cout << "LOSE" << endl;
                }//end computer chooses paper
                //Otherwise, win
                else
                {
                    cout << "WIN" << endl;
                }//end computer chooses scissors
            }//user chooses rock
            //If user chooses paper
            else if (uChoice == "paper")
            {
                //If computer chooses rock, win
                if (cChoice == "rock")
                {
                    cout << "WIN" << endl;
                }//end if computer chooses rock
                //Otherwise, lose
                else
                {
                    cout << "LOSE" << endl;
                }//end if computer chooses scissors
            }// end if user chooses paper
            //If user chooses scissors
            else
            {
                //If computer chooses rock, lose
                if (cChoice == "rock")
                {
                    cout << "LOSE" << endl;
                }//end if computer chooses rock
                //Otherwise, win
                else
                {
                    cout << "WIN" << endl;
                }//end if computer chooses paper
            }//end if user chooses scissors

            //Show results
            cout << "User: " << uChoice << " Computer: " << cChoice << endl;
            //Ask to play again or quit
            cout << "Type selection, 'rock', 'paper' OR 'scissors' - 'q' to QUIT" << endl;
            //Input user choice
            cin >> uChoice;
            //Convert to lower case
            transform(uChoice.begin(), uChoice.end(), uChoice.begin(), ::tolower);

            //If the user's choice is invalid.
            while (uChoice != "rock" && uChoice != "paper" && uChoice != "scissors" && uChoice != "q")
           {
               //Tell user it's invalid and ask them to re-enter
               cout << "Sorry, wrong input..." << endl;
               cout << "Type selection, 'rock', 'paper' OR 'scissors' - '" << QUIT_WORD << "' to QUIT" << endl;
               //Input user's choice
               cin >> uChoice;
               //Convert to lower case
               transform(uChoice.begin(), uChoice.end(), uChoice.begin(), ::tolower);
           }//end validation

            //Reset random computer choice
            cChoice = getComputerChoice();
       }
       //Good bye message to show when quit
       cout << "Good Bye" << endl;
   }//end playGame()
