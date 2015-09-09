// Homework 9-8-2 Melissa Cunningham
// Selection Sort

#include <iostream>
#include <cstdlib>
    using namespace std;

//Declare methods
//Method to sort arrow using selection sort
void selectionSort(int array[], int size, int &numSwaps);
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
    int swaps = 0;

    //Display original array
    cout << "Original order: "<< endl;
    showTestScores(testScores, SIZE);

    //Sort the array
    selectionSort(testScores, SIZE, swaps);

    //Display sorted array
    cout << "Selection sorted: " << endl;
    showTestScores(testScores, SIZE);

    //Show number of location swaps
    cout << "Number of location swaps: " << swaps << endl;

    system("Pause");
    return 0;
}  //end main())

//Method to use selection sort to sort array
void selectionSort(int array[], int size, int &numSwaps)
{
    int startScan;   // Starting position of the scan
    int index;       // To hold a subscript value
    int minIndex;    // Element with smallest value in the scan
    int minValue;    // The smallest value found in the scan

    //Outer loop - iterates once for each array
    for (startScan = ZERO; startScan < (size-ONE); startScan++)
    {
         // Assume the first element is the smallest
         minIndex = startScan;
         minValue = array[startScan];

         //Search array starting with second element and find the smallest
         for(index = startScan + ONE; index < size; index++)
         {
            //If the item in index location is less than the minValue
            if (array[index] < minValue)
            {
               //Assign the index value in the array to the minValue
               minValue = array[index];
               //Assign the index value to the minIndex
               minIndex = index;
            } //end if item in index location is less than minValue
     } //end search array

     // Swap the element with the smallest value
     // with the first element in the scannable area.
     swap(array[minIndex], array[startScan]);
     //Keep a count of the number of swaps
     numSwaps = numSwaps + ONE;
    } //end Outer loop
}  //end selectionSort()

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
