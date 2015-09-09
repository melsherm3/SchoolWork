// Homework 9-8-3 Melissa Cunningham
// Insertion Sort

#include <iostream>
#include <cstdlib>
    using namespace std;

//Declare methods
//Method to sort arrow using insertion sort
void insertionSort(int array[], int size, int &numSwaps);
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
    insertionSort(testScores, SIZE, swaps);

    //Display sorted array
    cout << "Insertion sorted: " << endl;
    showTestScores(testScores, SIZE);

    //Show number of location swaps
    cout << "Number of location swaps: " << swaps << endl;

    system("Pause");
    return 0;
}  //end main())

//Method to use insertion sort to sort array
void insertionSort(int array[], int size, int &numSwaps)
{
    int unsortedValue;  // The first unsorted value
    int scan;           // Used to scan the array

    //Outer loop looks at each subscript starting at 1
    for (int index = ONE; index < size; index++)
    {
         //Store value of element in array[index]
         unsortedValue = array[index];

         //Give scan the index value
         scan = index;

         //Move first unsorted element into proper position
         while (scan > ZERO && array[scan-ONE] > unsortedValue)
         {
            array[scan] = array[scan - ONE];
            scan--;
         } //end inner loop

         //Insert the unsorted value in its proper position
         array[scan] = unsortedValue;
         //Keep a count of the number of swaps
         numSwaps = numSwaps + ONE;
    } //end outer loop
}  //end insertionSort()

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
