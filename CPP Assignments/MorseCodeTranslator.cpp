// Homework 12 Melissa Cunningham

  #include <iostream>
  #include <cstdlib>
  #include <locale>
  #include <string>
   using namespace std;

   //Declare functions
   void getText(string &uText);
   void convertText(string &uText);
   void convertLetter(string &tLetter);

   //Declare constants
   const string QUITWORD = "eee";
   const int ZERO = 0;

   int main()
   {
      //Declare variables
      string userText;

      //Get text from user
      getText(userText);

      system("Pause");
      return 0;

   } //end main()

   //Function to get text
   void getText(string &uText)
   {
       //Keep asking for words until user enters quit word
       do
       {
           cout << "Enter the text to convert (" << QUITWORD << " to QUIT)" << endl;
           //save the line with spaces
           getline(cin, uText);
           //convert the text
           convertText(uText);
       }//end quit word loop
       while(uText != QUITWORD);
       //Say good bye
       cout << "Good Bye" << endl;
   }//end getTextI()

   //Function to convert text
   void convertText(string &uText)
   {
        //Declare variables
        unsigned int i = ZERO;
        string letter;
        //Show translation as long as quit word isn't entered
        if(uText != QUITWORD)
        {
            //Look at each letter of the text
            for(i=ZERO; i<uText.length(); i++)
            {
                //Convert the letter to uppercase
                uText[i] = toupper(uText[i]);
                letter = uText[i];
                //Display the letter
                cout << letter << ": ";
                //Convert the letter
                convertLetter(letter);
                //Display the Morse code letter
                cout << letter << endl;
            } //end for loop for uText string
        } //end if quit word is not entered
   }//end convertText()

   //Function to convert letters
   void convertLetter(string &tLetter)
   {
        //convert letters to Morse code
        if (tLetter == " ")
            {
                tLetter = " ";
            } //end space
        else if (tLetter ==  ",")
           {
                tLetter = "--..--";
           } //end comma
        else if (tLetter ==  ".")
            {
                tLetter = ".-.-.-";
            } //end period
        else if (tLetter ==  "?")
            {
                tLetter = "..--..";
            } //end ?
        else if (tLetter ==  "0")
            {
                tLetter = "-----";
            } //end 0
        else if (tLetter ==  "1")
            {
                tLetter = ".----";
            } //end 1
        else if (tLetter ==  "2")
            {
                tLetter = "..---";
            } //end 2
        else if (tLetter ==  "3")
            {
                tLetter = "...--";
            } //end 3
        else if (tLetter ==  "4")
            {
                tLetter = "....-";
            } //end 4
        else if (tLetter ==  "5")
            {
                tLetter = ".....";
            } //end 5
        else if (tLetter ==  "6")
            {
                tLetter = "-....";
            } //end 6
        else if (tLetter ==  "7")
            {
                tLetter = "--...";
            } //end 7
        else if (tLetter ==  "8")
            {
                tLetter = "---..";
            } //end 8
        else if (tLetter ==  "9")
            {
                tLetter = "----.";
            } //end 9
        else if (tLetter ==  "A")
            {
                tLetter = ".-";
            } //end A
        else if (tLetter ==  "B")
            {
                tLetter = "-...";
            } //end B
        else if (tLetter ==  "C")
            {
                tLetter = "-.-.";
            } //end C
        else if (tLetter ==  "D")
            {
                tLetter = "-..";
            } //end D
        else if (tLetter ==  "E")
            {
                tLetter = ".";
            } //end E
        else if (tLetter ==  "F")
            {
                tLetter = "..-.";
            } //end F
        else if (tLetter ==  "G")
            {
                tLetter = "--.";
            } //end G
        else if (tLetter ==  "H")
            {
                tLetter = "....";
            } //end H
        else if (tLetter ==  "I")
            {
                tLetter = "..";
            } //end I
        else if (tLetter ==  "J")
            {
                tLetter = ".---";
            } //end J
        else if (tLetter ==  "K")
            {
                tLetter = "-.-";
            } //end K
        else if (tLetter ==  "L")
            {
                tLetter = ".-..";
            } //end L
        else if (tLetter ==  "M")
            {
                tLetter = "--";
            } //end M
        else if (tLetter ==  "N")
            {
                tLetter = "-.";
            } //end N
        else if (tLetter ==  "O")
            {
                tLetter = "---";
            } //end O
        else if (tLetter ==  "P")
            {
                tLetter = ".---.";
            } //end P
        else if (tLetter ==  "Q")
            {
                tLetter = "--.-";
            } //end Q
        else if (tLetter ==  "R")
            {
                tLetter = ".-.";
            } //end R
        else if (tLetter ==  "S")
            {
                tLetter = "...";
            } //end S
        else if (tLetter ==  "T")
            {
                tLetter = "-";
            } //end T
        else if (tLetter ==  "U")
            {
                tLetter = "..-";
            } //end U
        else if (tLetter ==  "V")
            {
                tLetter = "...-";
            } //end V
        else if (tLetter ==  "W")
            {
                tLetter = ".--";
            } //end W
        else if (tLetter ==  "X")
            {
                tLetter = "-..-";
            } //end X
        else if (tLetter ==  "Y")
            {
                tLetter = "-.--";
            } //end Y
        else if (tLetter ==  "Z")
            {
                tLetter = "--..";
            } //end Z
        else
            {
                // Display an error message.
                cout << "That is an invalid selection." << endl;
            } //end default
   }//end convertLetter()
