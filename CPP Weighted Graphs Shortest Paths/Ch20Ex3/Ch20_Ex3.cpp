 /*
	Melissa Cunningham
	Chapter 20 Exercise 3
	8/5/15

	The following code was provided and not written by me. The assignment was to get it to work 
	by writing the code for createWeightedGraph(). See weightedGraph.h.
 */
#include <iostream>
#include <fstream>

#include "weightedGraph.h"
 
using namespace std;

int main() 
{
	//Create a new weightedGraphType object with 50 nodes
	weightedGraphType shortestPathGraph(50);

	//Create the graph
	shortestPathGraph.createWeightedGraph();

	//Find the shortest path from the root vertex
	shortestPathGraph.shortestPath(0);

	//Print the result of the shortest path
	shortestPathGraph.printShortestDistance(0);

	cout << endl;
	system("pause");
	return 0;
}