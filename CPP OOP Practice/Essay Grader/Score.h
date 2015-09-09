//Homework 14-5 Melissa Cunningham
//Essay Design Score Class
#ifndef SCORE_H_INCLUDED
#define SCORE_H_INCLUDED
#include <iostream>
#include <string>
#include "Grade.h"
    using namespace std;

class EssayScore : public LetterGrade
{
    private:
    //Field declarations
    double grammar;
    double spelling;
    double length;
    double content;

    public:
    //Constructor
    EssayScore(double grammarScore, double spellingScore, double lengthScore, double contentScore)
    {
        //Local variable to hold essay score
        double essayScore;
        //Set scores
        grammar = grammarScore;
        spelling = spellingScore;
        length = lengthScore;
        content = contentScore;

        //Set total score
        essayScore = grammar + spelling + length + content;
        //Use from Grade.h class
        setScore(essayScore);

    } //end EssayScore()
    //Mutators to set grammar, spelling, length, and content scores
    void setGrammer (double grammarScore)
    {
        grammar = grammarScore;
    } //end setGrammar
    void setSpelling (double spellingScore)
    {
        spelling = spellingScore;
    } //end setSpelling
    void setLength (double lengthScore)
    {
        length = lengthScore;
    } //end setLength
    void setContent (double contentScore)
    {
        content = contentScore;
    } //end setContent

    //Accessors to get grammar, spelling, length, and content scores
    double getGrammar()
    {
        return grammar;
    } //end getGrammar
    double getSpelling()
    {
        return spelling;
    } //end getSpelling
    double getLength()
    {
        return length;
    } //end getLength
    double getContent()
    {
        return content;
    } //end getContent

}; //end EssayScore class


#endif // SCORE_H_INCLUDED
