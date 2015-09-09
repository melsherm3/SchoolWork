//Homework 14-5 Melissa Cunningham
//Essay Design Program

#include <iostream>
#include <string>
#include <cstdlib>
#include "Grade.h"
#include "Score.h"
    using namespace std;

//Declare constants
const int ZERO = 0;
const int THIRTY = 30;
const int TWENTY = 20;

int main()
{
    // Variables to hold user input
    double grammarS;
    double spellingS;
    double lengthS;
    double contentS;

    // Prompt the user for the scores and make sure they are valid scores

    //Grammar Score
    cout << "Grammar (must be THIRTY or less): " << endl;
    cin >> grammarS;
    //Grammar score validity check
    while (grammarS < ZERO || grammarS > THIRTY)
    {
        cout << "Score must be " << ZERO << " or more and up to " << THIRTY << endl;
        cout << "Grammar (must be THIRTY or less): " << endl;
        cin >> grammarS;
    } //end grammar score check

    //Spelling Score
    cout << "Spelling (must be TWENTY or less): " << endl;
    cin >> spellingS;
    //Spelling score validity check
    while (spellingS < ZERO || spellingS > TWENTY)
    {
        cout << "Score must be " << ZERO << " or more and up to " << TWENTY << endl;
        cout << "Spelling (must be TWENTY or less): " << endl;
        cin >> spellingS;
    } //end spelling score validity check

    //Length Score
    cout << "Correct Length (must be TWENTY or less): " << endl;
    cin >> lengthS;
    //Length score validity check
    while (lengthS < ZERO || lengthS > TWENTY)
    {
        cout << "Score must be " << ZERO << " or more and up to " << TWENTY << endl;
        cout << "Correct Length (must be TWENTY or less): " << endl;
        cin >> lengthS;
    } //end length score validity check

    //Content Score
    cout << "Content (must be THIRTY or less): " << endl;
    cin >> contentS;
    //Content score validity check
    while (contentS < ZERO || contentS > THIRTY)
    {
        cout << "Score must be " << ZERO << " or more and up to " << THIRTY << endl;
        cout << "Content (must be THIRTY or less): " << endl;
        cin >> contentS;
    } //end content score validity check


    // Create an EssayScore object
    EssayScore essayTest (grammarS, spellingS, lengthS, contentS);

    //Display the results
    cout << "The recorded scores are: " << endl;
    cout << "Grammar: " << grammarS << endl;
    cout << "Spelling: " << spellingS << endl;
    cout << "Correct Length: " << lengthS << endl;
    cout << "Content: " << contentS << endl;
    cout << "Total Score: " << essayTest.getScore() << endl;
    cout << "The Grade for this Essay is: " << essayTest.getGrade() << endl;


    system("Pause");
    return 0;
}  //emd main
