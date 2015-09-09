//Homework 14-5 Melissa Cunningham
//Essay Design Letter Grade Class
#ifndef GRADE_H_INCLUDED
#define GRADE_H_INCLUDED
#include <iostream>
#include <string>
    using namespace std;

//Declare constants
const int A = 90;
const int B = 80;
const int C = 70;
const int D = 60;

class LetterGrade
{
    private:
    //Field declarations
    double score;

    public:
    //Mutator
    void setScore (double eScore)
    {
        score = eScore;
    }//end setScore

    //Accessor Methods
    double getScore()
    {
        return score;
    } //end getScore

    // getGrade function
    string getGrade()
    {
        // Local variable to hold a grade.
        string grade;

        // Determine the grade
        if (score >= A)
          grade = "A";
        else if (score >= B)
          grade = "B";
        else if (score >= C)
          grade = "C";
        else if (score >= D)
          grade = "D";
        else
          grade = "F";

        // Return the grade.
        return grade;
    } //end getGrade
}; //end LetterGrade class


#endif // GRADE_H_INCLUDED
