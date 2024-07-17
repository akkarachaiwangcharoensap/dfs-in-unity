using System.Collections.Generic;
using UnityEngine;

using Vector2 = UnityEngine.Vector2;

namespace AkiWiki
{
    public class GraphBehaviour : MonoBehaviour
    {
        private static Graph dfsGraph;
        void Awake()
        {
            dfsGraph = new Graph();

            // Row #5
            dfsGraph.AddEdge(new Vector2(-6, -4), new Vector2(-4, -4));
            dfsGraph.AddEdge(new Vector2(-6, -4), new Vector2(-6, -2));

            dfsGraph.AddEdge(new Vector2(-4, -4), new Vector2(-6, -4));
            dfsGraph.AddEdge(new Vector2(-4, -4), new Vector2(-4, -2));
            dfsGraph.AddEdge(new Vector2(-4, -4), new Vector2(-2, -4));

            dfsGraph.AddEdge(new Vector2(-2, -4), new Vector2(-4, -4));
            dfsGraph.AddEdge(new Vector2(-2, -4), new Vector2(-2, -2));
            dfsGraph.AddEdge(new Vector2(-2, -4), new Vector2(0, -4));

            dfsGraph.AddEdge(new Vector2(0, -4), new Vector2(-2, -4));
            dfsGraph.AddEdge(new Vector2(0, -4), new Vector2(0, -2));
            dfsGraph.AddEdge(new Vector2(0, -4), new Vector2(2, -4));

            dfsGraph.AddEdge(new Vector2(2, -4), new Vector2(0, -4));
            dfsGraph.AddEdge(new Vector2(2, -4), new Vector2(2, -2));
            dfsGraph.AddEdge(new Vector2(2, -4), new Vector2(4, -4));

            dfsGraph.AddEdge(new Vector2(4, -4), new Vector2(2, -4));
            dfsGraph.AddEdge(new Vector2(4, -4), new Vector2(4, -2));
            dfsGraph.AddEdge(new Vector2(4, -4), new Vector2(6, -4));

            dfsGraph.AddEdge(new Vector2(6, -4), new Vector2(4, -4));
            dfsGraph.AddEdge(new Vector2(6, -4), new Vector2(6, -2));

            // Row #4
            dfsGraph.AddEdge(new Vector2(-6, -2), new Vector2(-6, 0));
            dfsGraph.AddEdge(new Vector2(-6, -2), new Vector2(-4, -2));
            dfsGraph.AddEdge(new Vector2(-6, -2), new Vector2(-6, -4));

            dfsGraph.AddEdge(new Vector2(-4, -2), new Vector2(-6, -2));
            dfsGraph.AddEdge(new Vector2(-4, -2), new Vector2(-4, 0));
            dfsGraph.AddEdge(new Vector2(-4, -2), new Vector2(-2, -2));
            dfsGraph.AddEdge(new Vector2(-4, -2), new Vector2(-4, -4));

            dfsGraph.AddEdge(new Vector2(-2, -2), new Vector2(-4, -2));
            dfsGraph.AddEdge(new Vector2(-2, -2), new Vector2(-2, 0));
            dfsGraph.AddEdge(new Vector2(-2, -2), new Vector2(0, -2));
            dfsGraph.AddEdge(new Vector2(-2, -2), new Vector2(-2, -4));

            dfsGraph.AddEdge(new Vector2(0, -2), new Vector2(-2, -2));
            dfsGraph.AddEdge(new Vector2(0, -2), new Vector2(0, 0));
            dfsGraph.AddEdge(new Vector2(0, -2), new Vector2(2, -2));
            dfsGraph.AddEdge(new Vector2(0, -2), new Vector2(0, -4));

            dfsGraph.AddEdge(new Vector2(2, -2), new Vector2(0, -2));
            dfsGraph.AddEdge(new Vector2(2, -2), new Vector2(2, 0));
            dfsGraph.AddEdge(new Vector2(2, -2), new Vector2(4, -2));
            dfsGraph.AddEdge(new Vector2(2, -2), new Vector2(2, -4));

            dfsGraph.AddEdge(new Vector2(4, -2), new Vector2(2, -2));
            dfsGraph.AddEdge(new Vector2(4, -2), new Vector2(4, 0));
            dfsGraph.AddEdge(new Vector2(4, -2), new Vector2(6, -2));
            dfsGraph.AddEdge(new Vector2(4, -2), new Vector2(4, -4));

            dfsGraph.AddEdge(new Vector2(6, -2), new Vector2(4, -2));
            dfsGraph.AddEdge(new Vector2(6, -2), new Vector2(6, 0));
            dfsGraph.AddEdge(new Vector2(6, -2), new Vector2(6, -4));

            // Row #3
            dfsGraph.AddEdge(new Vector2(-6, 0), new Vector2(-6, 2));
            dfsGraph.AddEdge(new Vector2(-6, 0), new Vector2(-4, 0));
            dfsGraph.AddEdge(new Vector2(-6, 0), new Vector2(-6, -2));

            dfsGraph.AddEdge(new Vector2(-4, 0), new Vector2(-6, 0));
            dfsGraph.AddEdge(new Vector2(-4, 0), new Vector2(-4, 2));
            dfsGraph.AddEdge(new Vector2(-4, 0), new Vector2(-2, 0));
            dfsGraph.AddEdge(new Vector2(-4, 0), new Vector2(-4, -2));

            dfsGraph.AddEdge(new Vector2(-2, 0), new Vector2(-4, 0));
            dfsGraph.AddEdge(new Vector2(-2, 0), new Vector2(-2, 2));
            dfsGraph.AddEdge(new Vector2(-2, 0), new Vector2(0, 0));
            dfsGraph.AddEdge(new Vector2(-2, 0), new Vector2(-2, -2));

            dfsGraph.AddEdge(new Vector2(0, 0), new Vector2(-2, 0));
            dfsGraph.AddEdge(new Vector2(0, 0), new Vector2(0, 2));
            dfsGraph.AddEdge(new Vector2(0, 0), new Vector2(2, 0));
            dfsGraph.AddEdge(new Vector2(0, 0), new Vector2(0, -2));

            dfsGraph.AddEdge(new Vector2(2, 0), new Vector2(0, 0));
            dfsGraph.AddEdge(new Vector2(2, 0), new Vector2(2, 2));
            dfsGraph.AddEdge(new Vector2(2, 0), new Vector2(4, 0));
            dfsGraph.AddEdge(new Vector2(2, 0), new Vector2(2, -2));

            dfsGraph.AddEdge(new Vector2(4, 0), new Vector2(2, 0));
            dfsGraph.AddEdge(new Vector2(4, 0), new Vector2(4, 2));
            dfsGraph.AddEdge(new Vector2(4, 0), new Vector2(6, 0));
            dfsGraph.AddEdge(new Vector2(4, 0), new Vector2(4, -2));

            dfsGraph.AddEdge(new Vector2(6, 0), new Vector2(4, 0));
            dfsGraph.AddEdge(new Vector2(6, 0), new Vector2(6, 2));
            dfsGraph.AddEdge(new Vector2(6, 0), new Vector2(6, -2));

            // Row #2
            dfsGraph.AddEdge(new Vector2(-6, 2), new Vector2(-6, 4));
            dfsGraph.AddEdge(new Vector2(-6, 2), new Vector2(-4, 2));
            dfsGraph.AddEdge(new Vector2(-6, 2), new Vector2(-6, 0));

            dfsGraph.AddEdge(new Vector2(-4, 2), new Vector2(-6, 2));
            dfsGraph.AddEdge(new Vector2(-4, 2), new Vector2(-4, 4));
            dfsGraph.AddEdge(new Vector2(-4, 2), new Vector2(-2, 2));
            dfsGraph.AddEdge(new Vector2(-4, 2), new Vector2(-4, 0));

            dfsGraph.AddEdge(new Vector2(-2, 2), new Vector2(-4, 2));
            dfsGraph.AddEdge(new Vector2(-2, 2), new Vector2(-2, 4));
            dfsGraph.AddEdge(new Vector2(-2, 2), new Vector2(0, 2));
            dfsGraph.AddEdge(new Vector2(-2, 2), new Vector2(-2, 0));

            dfsGraph.AddEdge(new Vector2(0, 2), new Vector2(-2, 2));
            dfsGraph.AddEdge(new Vector2(0, 2), new Vector2(0, 4));
            dfsGraph.AddEdge(new Vector2(0, 2), new Vector2(2, 2));
            dfsGraph.AddEdge(new Vector2(0, 2), new Vector2(0, 0));

            dfsGraph.AddEdge(new Vector2(2, 2), new Vector2(0, 2));
            dfsGraph.AddEdge(new Vector2(2, 2), new Vector2(2, 4));
            dfsGraph.AddEdge(new Vector2(2, 2), new Vector2(4, 2));
            dfsGraph.AddEdge(new Vector2(2, 2), new Vector2(2, 0));

            dfsGraph.AddEdge(new Vector2(4, 2), new Vector2(2, 2));
            dfsGraph.AddEdge(new Vector2(4, 2), new Vector2(4, 4));
            dfsGraph.AddEdge(new Vector2(4, 2), new Vector2(6, 2));
            dfsGraph.AddEdge(new Vector2(4, 2), new Vector2(4, 0));

            dfsGraph.AddEdge(new Vector2(6, 2), new Vector2(4, 2));
            dfsGraph.AddEdge(new Vector2(6, 2), new Vector2(6, 4));
            dfsGraph.AddEdge(new Vector2(6, 2), new Vector2(6, 0));

            // Row #1
            dfsGraph.AddEdge(new Vector2(-6, 4), new Vector2(-4, 4));
            dfsGraph.AddEdge(new Vector2(-6, 4), new Vector2(-6, 2));

            dfsGraph.AddEdge(new Vector2(-4, 4), new Vector2(-6, 4));
            dfsGraph.AddEdge(new Vector2(-4, 4), new Vector2(-2, 4));
            dfsGraph.AddEdge(new Vector2(-4, 4), new Vector2(-4, 2));

            dfsGraph.AddEdge(new Vector2(-2, 4), new Vector2(-4, 4));
            dfsGraph.AddEdge(new Vector2(-2, 4), new Vector2(0, 4));
            dfsGraph.AddEdge(new Vector2(-2, 4), new Vector2(-2, 2));

            dfsGraph.AddEdge(new Vector2(0, 4), new Vector2(-2, 4));
            dfsGraph.AddEdge(new Vector2(0, 4), new Vector2(2, 4));
            dfsGraph.AddEdge(new Vector2(0, 4), new Vector2(0, 2));

            dfsGraph.AddEdge(new Vector2(2, 4), new Vector2(0, 4));
            dfsGraph.AddEdge(new Vector2(2, 4), new Vector2(4, 4));
            dfsGraph.AddEdge(new Vector2(2, 4), new Vector2(2, 2));

            dfsGraph.AddEdge(new Vector2(4, 4), new Vector2(2, 4));
            dfsGraph.AddEdge(new Vector2(4, 4), new Vector2(6, 4));
            dfsGraph.AddEdge(new Vector2(4, 4), new Vector2(4, 2));

            dfsGraph.AddEdge(new Vector2(6, 4), new Vector2(4, 4));
            dfsGraph.AddEdge(new Vector2(6, 4), new Vector2(6, 2));
        }

        // Update is called once per frame
        void Update()
        {

        }

        public static List<Vector2> DFS(Vector2 start, Vector2 end)
        {
            return dfsGraph.DFS(start, end);
        }
    }
}