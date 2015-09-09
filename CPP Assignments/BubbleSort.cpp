// Homework 9-8-1 Melissa Cunningham
// Bubble Sort

#include <iostream>
#include <cstdlib>
    using namespace std;

//Declare methods
//Method to sort arrow using Bubble sort
void bubbleSort(int array[], int size, int &numSwaps);
//Swap method used in Bubble sort
void swap(int &a, int &b);
//Method to display test scores
void showTestScores(int array[], int size);

//Declare constant for array size
const int SIZE = 20;

//Declare constants for increments and initializing
const int ONE = 1;
const int ZERO = 0;

int main()
{
    //Declare and initialize array
    int testScores[SIZE]={26, 45, 56, 12, 78, 74, 39, 22, 5, 90, 87, 32, 28, 11, 93, 62, 79, 53, 22, 51};

    //Declare and initialize number of swaps to display
    int swaps = ZERO;
    //Display original array
    cout << "Original order: "<< endl;
    showTestScores(testScores, SIZE);

    //Sort the array
    bubbleSort(testScores, SIZE, swaps);

    //Display sorted array
    cout << "Bubble sorted: " << endl;
    showTestScores(testScores, SIZE);

    //Show number of location swaps
    cout << "Number of location swaps: " << swaps << endl;

    system("Pause");
    return 0;
}  //end main())


void bubbleSort(int array[], int size, int &numSwaps)
{
    //Declare int for last element to compare
    int maxElement;
    //Declare int for index of element to compare
    int index;
    //Start loop, which searches a smaller amount of the array each pass
    for (maxElement = size - ONE; maxElement >= ZERO; maxElement--)
    {
         //Loop the searches each element in the array and switches if out of order
         for (index = ZERO; index <= maxElement - ONE; index++)
         {
            // Compare an element with its neighbor.
            if (array[index] > array[index + ONE])
            {
               // Swap the two elements.
               swap(array[index], array[index + ONE]);
               //Keep a count of the number of swaps
               numSwaps = numSwaps +ONE;
            }//end if first array item is bigger
         }//end small loop
    }//end start loop
}  //end bubbleSort()

//Method to swap items in an array
void swap(int &a, int &b)
{
    //Declare temp variable
    int temp;
    //Give temp first value
    temp = a;
    //Give first value the second value
    a = b;
    //Give second value the temp value
    b = temp;
}  //end swap()

//Method to display test scores
void showTestScores(int array[], int size)
{
  //Declare counter variable
  int index;

  //Display the test scores.
   for (index = ZERO; index < size; index++)
   {
     cout << array[index] << " ";
   } //end display test scores
   //end the line
   cout << endl;
}  //end showTestScores()

