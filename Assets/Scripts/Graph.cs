using System.Collections.Generic;
using UnityEngine;

namespace AkiWiki {
    public class Graph
    {
        private Dictionary<Vector2, List<Vector2>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<Vector2, List<Vector2>>();
        }

        public void AddEdge(Vector2 vertex1, Vector2 vertex2)
        {
            if (!adjacencyList.ContainsKey(vertex1))
            {
                adjacencyList.Add(vertex1, new List<Vector2>());
            }
            if (!adjacencyList.ContainsKey(vertex2))
            {
                adjacencyList.Add(vertex2, new List<Vector2>());
            }

            adjacencyList[vertex1].Add(vertex2);
        }

        public List<Vector2> DFS(Vector2 startVertex, Vector2 goalVertex)
        {
            List<Vector2> visited = new List<Vector2>();
            List<Vector2> paths = new List<Vector2>();
            
            // Recursively traverse through the tree (preorder) until goal is found.
            // When the goal is found, build the path that got us there.
            if (this.DFSRecursiveHelper(startVertex, goalVertex, visited, paths))
            {
                return paths;
            }
            
            return null;
        }

        private bool DFSRecursiveHelper(Vector2 current, Vector2 goalVertex, List<Vector2> visited, List<Vector2> path)
        {
            visited.Add(current);
            path.Add(current);

            if (current == goalVertex)
            {
                return true;
            }

            foreach (Vector2 neighbor in adjacencyList[current])
            {
                if (!visited.Contains(neighbor))
                {
                    if (this.DFSRecursiveHelper(neighbor, goalVertex, visited, path))
                    {
                        return true;
                    }
                }
            }

            path.RemoveAt(path.Count - 1); // backtrack
            return false;
        }
    }
}