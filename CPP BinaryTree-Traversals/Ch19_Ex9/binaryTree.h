/*
Melissa Cunningham
Chapter 19 Exercise 9
7/29/15

All of the code below was provided for the assignement and not written by me.
*/
//Header File Binary Search Tree
#ifndef H_binaryTree
#define H_binaryTree

#include <iostream>

using namespace std; 

    //Definition of the Node
template <class elemType>
struct nodeType2
{
    elemType info;
    nodeType2<elemType> *lLink;
    nodeType2<elemType> *rLink;
};
	
    //Definition of the class
template <class elemType>
class binaryTreeType
{
public:
    const binaryTreeType<elemType>& operator=
                 (const binaryTreeType<elemType>&); 
      //Overload the assignment operator.

    bool isEmpty() const;
      //Function to determine whether the binary tree is empty.
      //Postcondition: Returns true if the binary tree is empty;
      //               otherwise, returns false.

    void inorderTraversal() const;
      //Function to do an inorder traversal of the binary tree.
      //Postcondition: Nodes are printed in inorder sequence.

    void preorderTraversal() const;
      //Function to do a preorder traversal of the binary tree.
      //Postcondition: Nodes are printed in preorder sequence.

    void postorderTraversal() const;
      //Function to do a postorder traversal of the binary tree.
      //Postcondition: Nodes are printed in postorder sequence.

    int treeHeight() const;
      //Function to determine the height of a binary tree.
      //Postcondition: Returns the height of the binary tree.

    int treeNodeCount() const;
      //Function to determine the number of nodes in a 
      //binary tree.
      //Postcondition: Returns the number of nodes in the 
      //               binary tree.

    int treeLeavesCount() const;
      //Function to determine the number of leaves in a 
      //binary tree.
      //Postcondition: Returns the number of leaves in the 
      //               binary tree.

    void destroyTree();
      //Function to destroy the binary tree.
      //Postcondition: Memory space occupied by each node 
      //               is deallocated.
      //               root = NULL;

    virtual bool search(const elemType& searchItem) const = 0;
      //Function to determine if searchItem is in the binary 
      //tree.
      //Postcondition: Returns true if searchItem is found in 
      //               the binary tree; otherwise, returns 
      //               false.

    virtual void insert(const elemType& insertItem) = 0;
      //Function to insert insertItem in the binary tree.
      //Postcondition: If there is no node in the binary tree
      //               that has the same info as insertItem, a
      //               node with the info insertItem is created
      //               and inserted in the binary search tree.

    virtual void deleteNode(const elemType& deleteItem) = 0;
      //Function to delete deleteItem from the binary tree 
      //Postcondition: If a node with the same info as 
      //               deleteItem is found, it is deleted from
      //               the binary tree.
      //               If the binary tree is empty or 
      //               deleteItem is not in the binary tree, 
      //               an appropriate message is printed.

    binaryTreeType(const binaryTreeType<elemType>& otherTree); 
      //Copy constructor

    binaryTreeType();   
      //Default constructor

    ~binaryTreeType();   
      //Destructor

protected:
    nodeType2<elemType>  *root;

private:
    void copyTree(nodeType2<elemType>* &copiedTreeRoot,
                  nodeType2<elemType>* otherTreeRoot);
      //Makes a copy of the binary tree to which 
      //otherTreeRoot points. 
      //Postcondition: The pointer copiedTreeRoot points to
      //               the root of the copied binary tree.

    void destroy(nodeType2<elemType>* &p);
      //Function to destroy the binary tree to which p points. 
      //Postcondition: Memory space occupied by each node, in 
      //               the binary tree to which p points, is 
      //               deallocated.
      //               p = NULL;

    void inorder(nodeType2<elemType> *p) const;
      //Function to do an inorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in inorder sequence.

    void preorder(nodeType2<elemType> *p) const;
      //Function to do a preorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in preorder 
      //               sequence.

    void postorder(nodeType2<elemType> *p) const;
      //Function to do a postorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in postorder 
      //               sequence.

    int height(nodeType2<elemType> *p) const;
      //Function to determine the height of the binary tree
      //to which p points. 
      //Postcondition: Height of the binary tree to which 
      //               p points is returned.

    int max(int x, int y) const;
      //Function to determine the larger of x and y.
      //Postcondition: Returns the larger of x and y.

    int nodeCount(nodeType2<elemType> *p) const;
      //Function to determine the number of nodes in 
      //the binary tree to which p points. 
      //Postcondition: The number of nodes in the binary 
      //               tree to which p points is returned.

    int leavesCount(nodeType2<elemType> *p) const;
      //Function to determine the number of leaves in  
      //the binary tree to which p points 
      //Postcondition: The number of leaves in the binary 
      //               tree to which p points is returned.
};

	//Definition of member functions

template <class elemType>
binaryTreeType<elemType>::binaryTreeType()
{
    root = NULL;
}

template <class elemType>
bool binaryTreeType<elemType>::isEmpty() const
{
    return (root == NULL);
}

template <class elemType>
void binaryTreeType<elemType>::inorderTraversal() const
{
    inorder(root);
}

template <class elemType>
void binaryTreeType<elemType>::preorderTraversal() const
{
    preorder(root);
}

template <class elemType>
void binaryTreeType<elemType>::postorderTraversal() const
{
    postorder(root);
}

template <class elemType>
int binaryTreeType<elemType>::treeHeight() const
{
    return height(root);
}

template <class elemType>
int binaryTreeType<elemType>::treeNodeCount() const
{
    return nodeCount(root);
}

template <class elemType>
int binaryTreeType<elemType>::treeLeavesCount() const
{
    return leavesCount(root);
}

template <class elemType>
void  binaryTreeType<elemType>::copyTree
                       (nodeType2<elemType>* &copiedTreeRoot,
                        nodeType2<elemType>* otherTreeRoot)
{
    if (otherTreeRoot == NULL)
        copiedTreeRoot = NULL;
    else
    {
        copiedTreeRoot = new nodeType2<elemType>;
        copiedTreeRoot->info = otherTreeRoot->info;
        copyTree(copiedTreeRoot->lLink, otherTreeRoot->lLink);
        copyTree(copiedTreeRoot->rLink, otherTreeRoot->rLink);
    }
} //end copyTree

template <class elemType>
void binaryTreeType<elemType>::inorder
                              (nodeType2<elemType> *p) const
{
    if (p != NULL)
    {
        inorder(p->lLink);
        cout << p->info << " ";
        inorder(p->rLink);
    }
}

template <class elemType>
void binaryTreeType<elemType>::preorder
                              (nodeType2<elemType> *p) const
{
    if (p != NULL)
    {
        cout << p->info << " ";
        preorder(p->lLink);
        preorder(p->rLink);
    }
}

template <class elemType>
void binaryTreeType<elemType>::postorder
                              (nodeType2<elemType> *p) const
{
    if (p != NULL)
    {
        postorder(p->lLink);
        postorder(p->rLink);
        cout << p->info << " ";
    }		
}

   //Overload the assignment operator
template <class elemType>
const binaryTreeType<elemType>& binaryTreeType<elemType>::
        operator=(const binaryTreeType<elemType>& otherTree)
{ 
    if (this != &otherTree) //avoid self-copy
    {
        if (root != NULL)   //if the binary tree is not empty,
                            //destroy the binary tree
            destroy(root);

        if (otherTree.root == NULL) //otherTree is empty
            root = NULL;
        else
            copyTree(root, otherTree.root);
    }//end else

    return *this; 
}

template <class elemType>
void  binaryTreeType<elemType>::destroy(nodeType2<elemType>* &p)
{
    if (p != NULL)
    {
        destroy(p->lLink);
        destroy(p->rLink);
        delete p;
        p = NULL;
    }
}

template <class elemType>
void  binaryTreeType<elemType>::destroyTree()
{
    destroy(root);
}

	//copy constructor
template <class elemType>
binaryTreeType<elemType>::binaryTreeType
                (const binaryTreeType<elemType>& otherTree)
{
    if (otherTree.root == NULL) //otherTree is empty
        root = NULL;
    else
        copyTree(root, otherTree.root);
}

    //Destructor
template <class elemType>
binaryTreeType<elemType>::~binaryTreeType()
{
    destroy(root);
}

template<class elemType>
int binaryTreeType<elemType>::height
                             (nodeType2<elemType> *p) const
{
    if (p == NULL)
        return 0;
    else
        return 1 + max(height(p->lLink), height(p->rLink));
}

template <class elemType>
int binaryTreeType<elemType>::max(int x, int y) const
{
    if (x >= y)
        return x;
    else
        return y;
}

template <class elemType>
int binaryTreeType<elemType>::nodeCount(nodeType2<elemType> *p) const
{
    //Return zero if no nodes
	if (p == NULL)
        return 0;  
    else 
	{
		//Start count at 1

		int count = 1;
		//Increase count for each node
		count += nodeCount(p->lLink);                              
		count += nodeCount(p->rLink); 
        //return total                           
		return count;
    }
}

template <class elemType>
int binaryTreeType<elemType>::leavesCount(nodeType2<elemType> *p) const
{
	return 0;
}

#endif