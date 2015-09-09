// Homework 9-7 Melissa Cunningham

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
//Method to sequential search the array
void sequentialSearch(int array[], int size, int &sNumber, int &numSearches, int &location);
//Method to binary search the array
void binarySearch(int array[], int size, int &sNumber, int &numBinSearches, int &location);

//Declare constant for array size
const int SIZE = 20;

//Declare constant for increments and other math
const int ONE = 1;
const int ZERO = 0;
const int TWO = 2;


int main()
{
    //Declare and initialize array
    int testScores[SIZE]={26, 45, 56, 12, 78, 74, 39, 22, 5, 90, 87, 32, 28, 11, 93, 62, 79, 53, 22, 51};

    //Declare and initialize number of swaps to display
    int swaps = ZERO;

    //Declare number to search for
    int searchNumber;

    //Declare number of searches and location
    int searches = ZERO;
    int numLocation;
    int binarySearches = ZERO;
    int binNumLocation;

    //Declare string to search again
    string searchAgain = "y";

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

    //Loop for searching
    while (searchAgain == "y" || searchAgain == "Y")
    {
        //Get the number to search for
        cout << "Select a number in the array to search for: " << endl;
        cin >> searchNumber;

        //Return sequential search results
        sequentialSearch(testScores, SIZE, searchNumber, searches, numLocation);

        //Return binary search results
        binarySearch(testScores, SIZE, searchNumber, binarySearches, binNumLocation);

        //Ask user if they want to search again
        cout << "Do you want to search again? (Y=Yes)" << endl;
        cin >> searchAgain;

        //Reset number of search counts
        searches = 0;
        binarySearches = 0;
    } //end search loop


    system("Pause");
    return 0;
}  //end main())

//Method to sort using bubble method
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
               numSwaps = numSwaps +1;
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

//Method to sequential search the array
void sequentialSearch(int array[], int size, int &sNumber, int &numSearches, int &location)
{
    //Declare index variable
    int i=ZERO;
    //Set found to no
    string found = "n";
    //Loop while not found
    while (found == "n" && i<(SIZE-1))
    {
        //If array at index location equals the number the user entered..
        if(array[i] == sNumber)
        {
            //Location for user to understand is array location plus one
            location = i+ONE;
            //Change found to yes
            found = "y";
            //Include this search in the search count
            numSearches = numSearches + ONE;
        } //end if array at index is the number entered
        //If the array at the index is not what the user entered
        else
        {
            //Add to the search count
            numSearches = numSearches + ONE;
            //Increment the index
            i=i+ONE;
        } //end if not in search
    } //end not found loop
    //If the number is found
    if (found == "y")
    {
        //Show the number of searches and it's location
        cout << "Sequential Search comparisons: " << numSearches<< endl;
        cout << "The position of the number is: " << location << endl;
    } //end if number was found
    //If the number was not found
    else if (found == "n")
    {
        //Tell the user the number was not found
        cout << "Number not found." << endl;
    } //end if number not found
} //end sequentialSearch()

//Method to binary search the array
void binarySearch(int array[], int size, int &sNumber, int &numBinSearches, int &location)
{
    //Set the initial values
    int first = ZERO;
    int last = SIZE - ONE;
    bool found = false;

    //Search for the number
    while (!found && first <= last)
    {
         //Calculate mid point
         int middle = (first + last) / TWO;

         //If number is found at midpoint
         if (array[middle] == (sNumber))
         {
            //Set to found
            found = true;
            //Assign location
            location = middle+1;
            //Add this search for the final count of searches
            numBinSearches = numBinSearches + ONE;
         } //end if number found at midpoint
         //else if number is in lower half
         else if (array[middle] > (sNumber))
         {
            //Change last position to search to one less than middle
            last = middle - ONE;
            //Add this to number of searches
            numBinSearches = numBinSearches + ONE;
         } //end if number in lower half
         //else if number is in upper half
         else
         {
            //Change the first position to one more than the middle
            first = middle + ONE;
            //Add this to number of searches
            numBinSearches = numBinSearches + ONE;
         } //end if number in upper half

    } //end loop to search array
    //If the numer is found
    if (found == true)
    {
        //Show number of binary searches and location
        cout << "Binary Search comparisons: " << numBinSearches << endl;
        cout << "The position of the number is: " << location << endl;
    } //end if the number is found -- no else because already covered in sequential search
} //end binarySearch()


