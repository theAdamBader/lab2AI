using System;
using System.Collections.Generic;

class GreenGraph : Graph {
   
   // List of nodes in this graph
   private List<Node> nodes;

   // An adjacency matrix, recording edges between nodes
   // Edges FROM node i are recorded in adjMatrix[i]
   // Edge FROM node i to node j is recorded in adjMatrix[i][j]
   // Each int entry records the edge cost (> -1)
   // If entry is 0 there is no edge 
   private List<List<int>> adjMatrix;

   public GreenGraph() {
      nodes = new List<Node>();
      adjMatrix = new List<List<int>>();
   }


    public void AddNode(Node i) {
        //adds node i
        nodes.Add(i);

        //create new list that adds a new node
        //write for loop that adds the new node j
        List<int> newNode = new List<int>();
        adjMatrix.Add(newNode);

        for (int j = 0; j < nodes.Count; j++) {
            newNode.Add(0);
            adjMatrix[j].Add(0);
        }
    }

    public void AddEdge(Node i, Node j, int c) {
        //add edges
        //create variables node i and node j that takes the indexOf i and j
        //have c (cost) take the adjMatrix[i][j]
        int nodeI = nodes.IndexOf(i);
        int nodeJ = nodes.IndexOf(j);

        c = adjMatrix[nodeI][nodeJ];
    }

    public List<Node> Nodes()
    {
        //return a list of nodes
        return nodes;
    }

    public List<Node> Neighbours(Node i)
    {
        //adding a new list to find a neighbour list for node i
        //creating a new list to find the neighbour and int to sort the new neighbour node
        //using for loop, it searches through the matrix and if j is not i and adjMatrix[j][i] are not 0 then add node j
        //else returns node.IndexOf(i)
        List<Node> findMyNeighbours = new List<Node>();
        int neighbourNodeI = nodes.IndexOf(i);

        for (int j = 0; j < adjMatrix.Count; j++)
        {
            if (j != neighbourNodeI && adjMatrix[j][neighbourNodeI] != 0)
                findMyNeighbours.Add(nodes[j]);
        }
        return findMyNeighbours;
    }

    public int Cost(Node i, Node j)
    {
        //returns the adjMatrix[i][j]
        return adjMatrix[nodes.IndexOf(i)][nodes.IndexOf(j)];
    }


    public void Write() {
      Console.WriteLine("GreenGraph");

      for (int i = 0; i < nodes.Count; i++) {
         Console.Write(nodes[i] + ": ");

         bool first = true;
         for (int j = 0; j < nodes.Count; j++) {
            if (adjMatrix[i][j] > 0) {
               if (!first) Console.Write(", ");
               Console.Write(nodes[j] + "(" + adjMatrix[i][j] + ")");
               first = false;
            }
         }

         Console.Write("\n");
      }
   }
}