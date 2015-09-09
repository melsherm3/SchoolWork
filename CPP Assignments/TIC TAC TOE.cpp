// Homework 8-10 Melissa Cunningham

  #include <iostream>
  #include <cstdlib>
   using namespace std;

    //Declare constants
    //Number of rows and columns in game
    const int ROWS = 3;
    const int COLS = 3;
    //Where to start variables used in a loop
    const int START = 0;
    //Refers to positions in the array
    const int ZERO = 0;
    const int ONE = 1;
    const int TWO = 2;
    //Game results
    const int TIE = 2;
    const int WIN = 1;
    const int PLAY = 0;

    //Declare method to display board
    void displayStartBoard(string tttBoard[ROWS][COLS], int ROWS, int COLS);

    //Declare method to display current board
    void displayBoard(string tttBoard[ROWS][COLS], int ROWS, int COLS);

    //Declare method to play game
    void playGame(string tttBoard[ROWS][COLS], int ROWS, int COLS, int &result, string &whoWon);

    //Declare method to decide if someone won
    void someoneWon(int &result, string &whoWon, string tttBoard[ROWS][COLS], int ROWS, int COLS);

    //Declare method to determine if entry if valid
    void validCheck(int &rowEntered, int &colEntered);

   int main()
   {
        //Declare variables
        int result;
        string whoWon;
        //Declare array
        string tttBoard[ROWS][COLS];

        //Call method to play the game
        playGame(tttBoard, ROWS, COLS, result, whoWon);

        system("Pause");
        return 0;

   } //end main()

   //Method to display start board
   void displayStartBoard(string tttBoard[ROWS][COLS], int ROWS, int COLS)
   {
       //Declare variables
       int row;
       int col;
       int rowNum;
       int colNum;

        //Add the column headers
       for (col=START; col < COLS; col++)
           {
               //Start with number 1
               colNum = col + ONE;
               //Add headers
               cout << '\t' << colNum;
           }//end for column loop
        //Add a new line
        cout << endl;
        //Assign the row headers
       for (row=START; row < ROWS; row++)
       {
           //Start with the number 1
           rowNum = row + ONE;
           //Add headers
           cout << rowNum << '\t';
            //For each item in the board
           for (col=START; col < COLS; col++)
           {
               //Initialize all values to *
               tttBoard[row][col] = "*";
               //Display the values in the board
               cout << tttBoard[row][col] << '\t';
           }//end for column inside of row loop
           //Add a new line
           cout << endl;
       }//end for row loop
   }//end displayStartBoard()

   //Method to display current board
   void displayBoard(string tttBoard[ROWS][COLS], int ROWS, int COLS)
   {
       //Declare variables
       int row;
       int col;
       int rowNum;
       int colNum;

        //Assign the column headers
       for (col=START; col < COLS; col++)
           {
               //Start column header with one
               colNum = col + ONE;
               //Display column header
               cout << '\t' << colNum;
           }//end for column loop
        //Add a new line
        cout << endl;
        //Assign the row headers
       for (row=START; row < ROWS; row++)
       {
           //Start the row headers with 1
           rowNum = row + ONE;
           //Display the row headers
           cout << rowNum << '\t';
            //Show the board values
           for (col=START; col < COLS; col++)
           {
               //Display the board's values
               cout << tttBoard[row][col] << '\t';

           }//end for column inside of row loop
           //Add a new line
           cout << endl;
       }//end for row loop
   }//end displayBoard()


    //Method to play game
   void playGame(string tttBoard[ROWS][COLS], int ROWS, int COLS, int &result, string &whoWon)
   {
        //Declare variables
        int row = START;
        int col = START;

        //Call method to display the starting board
        displayStartBoard(tttBoard, ROWS, COLS);

        //Initialize result to play value
        result = PLAY;
        //While no winner
        while (result == PLAY)
        {
            //Ask for X's row
            cout << "Player X - Enter: row ";
            //Input row
            cin >> row;
            //Ask for X's column
            cout << " Enter: column ";
            //Input column
            cin >> col;
            //Check if entries are valid
            validCheck(row, col);
            //Match row and column to their value in the array by subtracting 1
            row = row - ONE;
            col = col - ONE;

            //If the spot is already taken
            while(tttBoard[row][col] != "*")
            {
                //Make the user pick a new spot and input that spot
                cout << "That spot is taken. Choose again." << endl;
                cout << "Enter: row ";
                cin >> row;
                cout << " Enter: column ";
                cin >> col;
                //Check if entries are valid
                validCheck(row, col);
                //Match row and column to their value in the array by subtracting 1
                row = row - ONE;
                col = col - ONE;
            }//end while the spot is taken
            //Assign an X to the spot chosen
            tttBoard[row][col] = "X";
            //Display the new X
            displayBoard(tttBoard, ROWS, COLS);
            //Check and see if someone won
            someoneWon(result, whoWon, tttBoard, ROWS, COLS);

            //If no one won
            if (result == PLAY)
            {
                //Ask player O to enter a row
                cout << "Player O - Enter: row ";
                //Input the row
                cin >> row;
                //Ask for the column
                cout << " Enter: column ";
                //Input the column
                cin >> col;
                //Check if entries are valid
                validCheck(row, col);
                //Match row and column to their value in the array by subtracting 1
                row = row - ONE;
                col = col - ONE;
                //Check to see if the spot is taken, if it's taken
                while(tttBoard[row][col] != "*")
                {
                    //Tell user it's taken and ask for a new spot and input that.
                    cout << "That spot is taken. Choose again." << endl;
                    cout << "Enter: row ";
                    cin >> row;
                    cout << " Enter: column ";
                    cin >> col;
                    //Check if entries are valid
                    validCheck(row, col);
                    //Match row and column to their value in the array by subtracting 1
                    row = row - ONE;
                    col = col - ONE;
                }//end while spot is taken
                //Assign an O to the new spot
                tttBoard[row][col] = "O";
                //Display the board with the new O spot
                displayBoard(tttBoard, ROWS, COLS);
                //Check to see if someone won
                someoneWon(result, whoWon, tttBoard, ROWS, COLS);
            }//end if no one won after x plays

        }//end while no winner
        //If someone won
        if(result==WIN)
        {
            //Display who won
            cout << "Player " << whoWon << " wins!" << endl;
        }//end if someone won
        //If it's a tie game
        else if (result==TIE)
        {
            //Display tie game
            cout << "TIE GAME" << endl;
        }//end if tie game

   }//end playGame()

     //Method to decide someone won and who it was
   void someoneWon(int &result, string &whoWon, string tttBoard[ROWS][COLS], int ROWS, int COLS)
   {
        //Declare variables
        int i=0;
        int j=0;
        //Check each row
        while (i<ROWS)
        {
            //If there are 3 matches in a row, someone won
            if(tttBoard[i][ZERO]!="*" && tttBoard[i][ZERO] == tttBoard[i][ONE] && tttBoard[i][ZERO] == tttBoard[i][TWO])
            {
                //Change result to someone won
                result = WIN;
                //Find out who won
                whoWon = tttBoard[i][ZERO];
                //Exit the loop
                i=ROWS;

            }//end if there are 3 matches in a row
            //Otherwise if no match
            else
            {
                //Set result to no one won
                result = PLAY;
                //Increase i to check the next row
                i=i+ONE;
            }//end if no match

        }//end check each row
        //If no one won
        if(result==PLAY)
        {
            //Reset i back to zero
            i=START;
            //Check each column
            while (i<COLS)
            {
                //If there are 3 matches in a column
                if(tttBoard[ZERO][i]!="*" && tttBoard[ZERO][i] == tttBoard[ONE][i] && tttBoard[ZERO][i] == tttBoard[TWO][i])
                {
                    //Someone won
                    result = WIN;
                    //Find out who won
                    whoWon = tttBoard[ZERO][i];
                    //Reset i to exit the loop
                    i=COLS;

                }//end if there are 3 matches in a column
                //Otherwise if no one won
                else
                {
                    //Set result to no one won
                    result = PLAY;
                    //Increase i to check next column
                    i=i+ONE;
                }//end if no one won

            }//end check each column
        }//end if no one won
        //If still no one won
        if(result==PLAY)
        {
            //Check the diagonals for 3 in a row - if 3 are the same diagonally...
            if((tttBoard[ZERO][ZERO]!="*" && tttBoard[ZERO][ZERO] == tttBoard[ONE][ONE] && tttBoard[ZERO][ZERO] == tttBoard[TWO][TWO]) || (tttBoard[ZERO][TWO]!="*" && tttBoard[ZERO][TWO] == tttBoard[ONE][ONE] && tttBoard[ZERO][TWO] == tttBoard[TWO][ZERO]))
                {
                    //Someone won
                    result = WIN;
                    //Find out who won
                    whoWon = tttBoard[ONE][ONE];

                }//end check diagonals
                //Otherwise, no one won
                else
                {
                    //Set result to no one won
                    result = PLAY;
                }//end no one won

        }//end if still no one won
        //If even still no one won
        if (result==PLAY)
        {
            //Check every column
            for(i=START; i<COLS; i++)
            {
                //And for each row in each column
                for(j=START; j<ROWS; j++)
                    {
                        //If there is a * left
                        if(tttBoard[j][i]!="*")
                        {
                            //No one has won yet
                            result=TIE;
                        }//end *'s are left
                        //Otherwise if there are no *'s left
                        else
                        {
                            //It's a tie game
                            result=PLAY;
                            //Exit the loop
                            j=ROWS;
                            i=COLS;
                        }//end no *'s left
                    }//end for each row
            }//end check every column
        }//end if even still no one won

   }//end someoneWon()

    //Method to check that location entered is valid
   void validCheck(int &rowEntered, int &colEntered)
   {
        //Make sure chosen location is valid
        while(rowEntered>ROWS || colEntered>COLS || rowEntered < ONE || colEntered < ONE)
        {
            //Make the user pick a new spot and input that spot
            cout << "Invalid location. Choose again." << endl;
            cout << "Enter: row ";
            cin >> rowEntered;
            cout << " Enter: column ";
            cin >> colEntered;
        }//end while the location is invalid
   }//end validCheck()



