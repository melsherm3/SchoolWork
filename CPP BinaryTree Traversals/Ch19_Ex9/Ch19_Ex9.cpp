/*
Melissa Cunningham
Chapter 19 Exercise 9
7/29/15

The assignment was to get this main program to work. 
The following code was provided and not written by me.
My code addition can be found in binarySearchTree.h.
*/
//Data
//68 43 10 56 77 82 61 82 33 56 72 66 99 88 12 6 7 21 -999

#include <iostream>
#include "binarySearchTree.h"
#include "orderedLinkedList.h"

using namespace std;
  
int main()
{
	//Declare a binary search tree and ordered linked list
	bSearchTreeType<int>  treeRoot;
	orderedLinkedList<int> newList;
	
	//Declare a num for entering in number to search tree
	int num;

	cout << "Enter numbers ending with -999" << endl;
	cin >> num;

	//Enter numbers into tree
	while (num != -999)
	{
		treeRoot.insert(num);
		cin >> num;
	}

	//Print nodes of tree
	cout << endl << "Tree nodes in inorder: ";
	treeRoot.inorderTraversal();
	cout << endl;

	//Print tree height
	cout << "Tree Height: " << treeRoot.treeHeight()
		 << endl;
	treeRoot.createList(newList);

	//Print new list version of tree
	cout << "newList: ";
	newList.print();
	
	cout << endl;
	system("pause");

	return 0;
}