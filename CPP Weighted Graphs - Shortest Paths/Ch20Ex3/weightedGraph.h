 /*
	Melissa Cunningham
	Chapter 20 Exercise 3
	8/5/15
	
	Assignment: Write the code for createWeightedGraph()
	All other code was provided for the assignment.
 */
#ifndef H_weightedGraph
#define H_weightedGraph
 
#include <iostream>
#include <fstream>
#include <iomanip>
#include <cfloat> 
#include "graphType.h"

using namespace std;

class weightedGraphType: public graphType
{
public:
    void createWeightedGraph();
      //Function to create the graph and the weight matrix.
      //Postcondition: The graph using adjacency lists and 
      //               its weight matrix is created.

    void shortestPath(int vertex);
      //Function to determine the weight of a shortest path 
      //from vertex, that is, source, to every other vertex 
      //in the graph.
      //Postcondition: The weight of the shortest path from
      //               vertex to every other vertex in the
      //               graph is determined.

    void printShortestDistance(int vertex);
      //Function to print the shortest weight from vertex 
      //to the other vertex in the graph.
      //Postcondition: The weight of the shortest path from
      //               vertex to every other vertex in the
      //               graph is printed.

    weightedGraphType(int size = 0); 
      //Constructor
      //Postcondition: gSize = 0; maxSize = size;
      //               graph is an array of pointers to linked
      //               lists.
      //               weights is a two-dimensional array to 
      //               store the weights of the edges.
      //               smallestWeight is an array to store the 
      //               smallest weight from source to vertices.

    ~weightedGraphType();
      //Destructor
      //The storage occupied by the vertices and the arrays
      //weights and smallestWeight is deallocated.

protected:
    double **weights;   //pointer to create weight matrix
    double *smallestWeight;	//pointer to create the array to
                            //store the smallest weight from 
                            //source to vertices
};

//Code written by Melissa Cunningham below
void weightedGraphType::createWeightedGraph()
{
    int vertex;
	int adjacentVertex;
	double weight;
	
	//Clear graph if it has something in it
	if(gSize != 0)
		clearGraph();
	
	//Get file for weighted graph
	ifstream file;
	char fileName[50];
	cout << "Enter input filename: ";
	cin >> fileName;
	cout << endl;

	//Open the file
	file.open(fileName);


	//Show error if it doesn't open
	if(!file)
	{
		cout << "Cannot open file." << endl;
		return;
	}

	//Get the number of vertices
	file >> gSize;

	//Create the graph
	for (int i=0; i<gSize; i++)
	{
        file >> vertex;
        file >> adjacentVertex;

        while (adjacentVertex != -999)
        {
            graph[vertex].insertLast(adjacentVertex);
            file >> adjacentVertex;
        } 
    } 

	//Give weights an initial value at all locations
	for (int i = 0; i < gSize; i++)
		for (int j = 0; j < gSize; j++)
			weights[i][j] = DBL_MAX;

	//Add the weights to the graph
	for (int i=0; i<gSize; i++)
	{
        file >> vertex;
        file >> adjacentVertex;
		file >> weight;
		weights[vertex][adjacentVertex] = weight;

		//Until you hit the end, add the weight of each path
        while (adjacentVertex != -999)
        {
            file >> adjacentVertex;
			if(adjacentVertex != -999)
			{
				file >> weight;
				weights[vertex][adjacentVertex] = weight;
			}
        } 
    } 

	//Close the file
	file.close();
} //end createWeightedGraph (code written by Melissa Cunningham)

void weightedGraphType::shortestPath(int vertex)
{
    for (int j = 0; j < gSize; j++)
        smallestWeight[j] = weights[vertex][j];

    bool *weightFound;
    weightFound = new bool[gSize];

    for (int j = 0; j < gSize; j++)
        weightFound[j] = false;

    weightFound[vertex] = true;
    smallestWeight[vertex] = 0;

    for (int i = 0; i < gSize - 1; i++)
    {
        double minWeight = DBL_MAX;
        int v;

        for (int j = 0; j < gSize; j++)
            if (!weightFound[j])
                if (smallestWeight[j] < minWeight)
                {
                    v = j;
                    minWeight = smallestWeight[v];
                }

        weightFound[v] = true;

        for (int j = 0; j < gSize; j++)
            if (!weightFound[j])
                if (minWeight + weights[v][j] < smallestWeight[j])
                    smallestWeight[j] = minWeight + weights[v][j];
    } //end for
} //end shortestPath

void weightedGraphType::printShortestDistance(int vertex)
{
    cout << "Source Vertex: " << vertex << endl;
    cout << "Shortest Distance from Source to each Vertex."
         << endl;
    cout << "Vertex  Shortest_Distance" << endl;

    for (int j = 0; j < gSize; j++)
        cout << setw(4) << j << setw(12) << smallestWeight[j]
             << endl;
    cout << endl;
} //end printShortestDistance

    //Constructor
weightedGraphType::weightedGraphType(int size)
                  :graphType(size)
{
    weights = new double*[size];

    for (int i = 0; i < size; i++)
        weights[i] = new double[size];

    smallestWeight = new double[size];
}

    //Destructor
weightedGraphType::~weightedGraphType()
{
    for (int i = 0; i < gSize; i++)
       delete [] weights[i];

    delete [] weights;
    delete smallestWeight;
}

#endif
