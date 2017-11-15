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


    public void AddNode(Node a) {
        nodes.Add(a);

        //create new list that adds a new node
        //write for loop that adds the new node
        List<int> newNode = new List<int>();
        adjMatrix.Add(newNode);

        for (int i = 0; i < nodes.Count; i++) {
            newNode.Add(0);
            adjMatrix[i].Add(0);
        }
    }

    public void AddEdge(Node a, Node b, int c) {
        //add edges
    }

    public List<Node> Nodes()
    {
        return nodes;
    }

    public List<Node> Neighbours(Node a)
    {
        //to-from function 
        //if function
        return new List<Node>();
    }

    public int Cost(Node a, Node b)
    {
        return 1;
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