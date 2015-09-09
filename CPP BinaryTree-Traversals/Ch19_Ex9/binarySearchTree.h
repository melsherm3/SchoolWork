/*
Melissa Cunningham
Chapter 19 Exercise 9
7/29/15

Assignment was to take this existing code and add the createList and addToList functions.

*/
//Header File Binary Search Tree

#ifndef H_binarySearchTree
#define H_binarySearchTree
#include <iostream>
#include "binaryTree.h"
#include "orderedLinkedList.h"
 
using namespace std;

template <class elemType>
class bSearchTreeType: public binaryTreeType<elemType>
{
public:
    bool search(const elemType& searchItem) const;
      //Function to determine if searchItem is in the binary 
      //search tree.
      //Postcondition: Returns true if searchItem is found in 
      //               the binary search tree; otherwise, 
      //               returns false.

    void insert(const elemType& insertItem);
      //Function to insert insertItem in the binary search tree.
      //Postcondition: If there is no node in the binary search
      //               tree that has the same info as 
      //               insertItem, a node with the info 
      //               insertItem is created and inserted in the
      //               binary search tree.

    void deleteNode(const elemType& deleteItem);
      //Function to delete deleteItem from the binary search tree 
      //Postcondition: If a node with the same info as deleteItem
      //               is found, it is deleted from the binary 
      //               search tree.
      //               If the binary tree is empty or deleteItem
      //               is not in the binary tree, an appropriate
      //               message is printed.

	void createList(orderedLinkedList<elemType> &newlist);
	//Create an ordered list from the items in the tree

	void addToList(orderedLinkedList<elemType> &newlist, nodeType2<elemType> *current);
	//Recursive function to add items to list

private:
    void deleteFromTree(nodeType2<elemType>* &p);
      //Function to delete the node to which p points is 
      //deleted from the binary search tree.
      //Postcondition: The node to which p points is deleted
      //               from the binary search tree.
};


template <class elemType>
bool bSearchTreeType<elemType>::search
                    (const elemType& searchItem) const
{
    nodeType2<elemType> *current;
    bool found = false;

    if (root == NULL)
        cout << "Cannot search an empty tree." << endl;
    else
    { 
       current = root;

       while (current != NULL && !found)
        {
            if (current->info == searchItem)
                found = true;
            else if (current->info > searchItem)
                current = current->lLink;
            else
                current = current->rLink;
        }//end while
    }//end else

    return found;
}//end search

template <class elemType>
void bSearchTreeType<elemType>::insert
                 (const elemType& insertItem)
{
    nodeType2<elemType> *current; //pointer to traverse the tree
    nodeType2<elemType> *trailCurrent; //pointer behind current
    nodeType2<elemType> *newNode;  //pointer to create the node

    newNode = new nodeType2<elemType>;
    newNode->info = insertItem;
    newNode->lLink = NULL;
    newNode->rLink = NULL;

    if (root == NULL)
        root = newNode;
    else
    {
        current = root;
 
        while (current != NULL)
        {
            trailCurrent = current;

            if (current->info == insertItem)
            {
                cout << "The item to be inserted is already ";
                cout << "in the tree -- duplicates are not "
                     << "allowed." << insertItem << endl;
                return;
            }
            else if (current->info > insertItem)
                current = current->lLink;
            else
                current = current->rLink;
        }//end while

        if (trailCurrent->info > insertItem)
            trailCurrent->lLink = newNode;
        else
            trailCurrent->rLink = newNode;
    }
}//end insert

template <class elemType>
void bSearchTreeType<elemType>::deleteNode
                                (const elemType& deleteItem)
{
    nodeType2<elemType> *current; //pointer to traverse the tree
    nodeType2<elemType> *trailCurrent; //pointer behind current
    bool found = false;

    if (root == NULL)
        cout << "Cannot delete from an empty tree." 
             << endl;
    else
    {
        current = root;
        trailCurrent = root;

        while (current != NULL && !found)
        {
            if (current->info == deleteItem)
                found = true;
            else
            {
                trailCurrent = current;

                if (current->info > deleteItem)
                    current = current->lLink;
                else
                    current = current->rLink;
            }
        }//end while

        if (current == NULL)
            cout << "The item to be deleted is not in the tree." 
                 << endl;
        else if (found)
        {
            if (current == root)
                deleteFromTree(root);
            else if (trailCurrent->info > deleteItem)
                deleteFromTree(trailCurrent->lLink);
            else
                deleteFromTree(trailCurrent->rLink);
        }
        else
            cout << "The item to be deleted is not in the tree."
                 << endl;
    }
} //end deleteNode

template <class elemType>
void bSearchTreeType<elemType>::deleteFromTree
                                 (nodeType2<elemType>* &p)
{
    nodeType2<elemType> *current; //pointer to traverse the tree
    nodeType2<elemType> *trailCurrent;  //pointer behind current
    nodeType2<elemType> *temp;      //pointer to delete the node

    if (p == NULL)
        cout << "Error: The node to be deleted is NULL."
             << endl;
    else if (p->lLink == NULL && p->rLink == NULL)
    {
        temp = p;
        p = NULL;
        delete temp;
    }
    else if (p->lLink == NULL)
    {
        temp = p;
        p = temp->rLink;
        delete temp;
    }
    else if (p->rLink == NULL)
    {
        temp = p;
        p = temp->lLink;
        delete temp;
    }
    else
    {
        current = p->lLink;
        trailCurrent = NULL;

        while (current->rLink != NULL)
        {
            trailCurrent = current;
            current = current->rLink;
        }//end while

        p->info = current->info;

        if (trailCurrent == NULL) //current did not move; 
                               //current == p->lLink; adjust p
            p->lLink = current->lLink;
        else
            trailCurrent->rLink = current->lLink;
 
        delete current;
    }//end else
} //end deleteFromTree

/*
NEW FUNCTIONS TO INSERT BINARY TREE NOTES INTO AN ORDERED LIST
Below is code added by Melissa Cunningham. Above code was provided.
*/
template <class elemType>
void bSearchTreeType<elemType>::createList(orderedLinkedList<elemType> &newlist)
{
	//Declare variables to hold tree nodes and an item for adding to list
	nodeType2<elemType> *current;
	current = root;

	//Make sure tree is not empty
    if (root == NULL)
        cout << "Tree is empty. Cannot create list" << endl; 
    else
    { 
       //Add all items to list
	   addToList(newlist, current);
	}
}//end createList

template <class elemType>
void bSearchTreeType<elemType>::addToList(orderedLinkedList<elemType> &newlist, nodeType2<elemType> *current)
{
	elemType item;

	if(current != NULL)
	{
		//Set item to the current value
		item = current->info;
		//Add item to the new list
		newlist.insert(item);
		//Repeat function for left and right sides
		addToList(newlist, current->lLink);
		addToList(newlist, current->rLink);
	}

}//end addToList

#endif
