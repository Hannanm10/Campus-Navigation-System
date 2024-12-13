using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UetMap
{
    class Graph
    {
        public List<GraphNode> Nodes { get; set; } = new List<GraphNode>();
        public List<Edge> Edges { get; set; } = new List<Edge>(); // Store painted edges (roads)

        private List<List<GraphNode>> routeHistory = new List<List<GraphNode>>(); // Route history

        // Add node to graph
        public void AddNode(GraphNode node)
        {
            if (!Nodes.Contains(node))
                Nodes.Add(node);
        }

        // Add edge between nodes (undirected graph)
        public void AddEdge(Edge edge, float distance)
        {
            // Ensure the nodes in the edge exist in the graph
            if (!Nodes.Contains(edge.StartNode))
                Nodes.Add(edge.StartNode);

            if (!Nodes.Contains(edge.EndNode))
                Nodes.Add(edge.EndNode);

            // Add the edge to the graph
            edge.Distance = distance;
            Edges.Add(edge);

            // Add neighbors with distance (if not already added)
            if (!edge.StartNode.Neighbors.ContainsKey(edge.EndNode))
                edge.StartNode.AddNeighbor(edge.EndNode, edge.Distance);

            if (!edge.EndNode.Neighbors.ContainsKey(edge.StartNode))
                edge.EndNode.AddNeighbor(edge.StartNode, edge.Distance);
        }

        // Find node by name (Location lookup)
        public GraphNode FindNode(string name)
        {
            return Nodes.FirstOrDefault(node => node.Name == name);
        }

        // Function to render edges (roads)
        public void DrawEdges(Graphics g)
        {
            foreach (var edge in Edges)
            {
                //edge.Draw(g);
            }
        }

        public List<GraphNode> Dijkstra(GraphNode start, GraphNode end)
        {
            var distances = new HashMap<GraphNode, int>(100); // Initialize with custom HashMap
            var previousNodes = new HashMap<GraphNode, GraphNode>(100); // Another HashMap for previous nodes
            var unvisitedNodes = new HashMap<GraphNode, bool>(100); // Using HashMap as a set

            // Initialize distances and previous nodes
            foreach (var node in Nodes)
            {
                distances.Add(node, int.MaxValue); // Set initial distances to infinity
                previousNodes.Add(node, null);    // No previous nodes initially
                unvisitedNodes.Add(node, true);  // Add all nodes to unvisitedNodes
            }
            distances.Add(start, 0); // Distance to the start node is 0

            while (unvisitedNodes.GetAll().Any())
            {
                // Get the closest node
                var closestNode = unvisitedNodes.GetAll()
                    .Select(pair => pair.Key) // Extract the keys (GraphNodes)
                    .OrderBy(node => distances.ContainsKey(node) ? distances.Get(node) : int.MaxValue)
                    .First();
                unvisitedNodes.Remove(closestNode);

                if (closestNode == end)
                    break; // Path to the end node found

                // Iterate over neighbors of the closest node
                foreach (var pair in closestNode.Neighbors.GetAll()) // Use GetAll() to get key-value pairs
                {
                    var neighbor = pair.Key; // The neighbor node
                    var distance = pair.Value; // The distance to the neighbor

                    int alt = distances.Get(closestNode) + distance;
                    if (alt < distances.Get(neighbor))
                    {
                        distances.Add(neighbor, alt); // Update distance
                        previousNodes.Add(neighbor, closestNode); // Update previous node
                    }
                }
            }

            var path = new List<GraphNode>();
            for (var currentNode = end; currentNode != null; currentNode = previousNodes.Get(currentNode))
            {
                path.Add(currentNode); // Add to the end of the list
            }

            path.Reverse(); // Reverse the list to get the correct order
            return path;
        }



        // BFS Traversal
        public List<GraphNode> BFS(GraphNode start)
        {
            var visited = new HashSet<GraphNode>();
            var queue = new Queue<GraphNode>();
            var result = new List<GraphNode>();

            // Start BFS
            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count() > 0)
            {
                var currentNode = queue.Dequeue();
                result.Add(currentNode);

                // Iterate through neighbors of the current node using the HashMap
                foreach (var pair in currentNode.Neighbors.GetAll()) // Assuming GetAll() method returns a list of key-value pairs
                {
                    var neighbor = pair.Key; // The neighbor node
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }

    // Edge class representing a painted road (visual element)

    class Edge
    {
        public GraphNode StartNode { get; set; }
        public GraphNode EndNode { get; set; }
        public Panel RoadPanel { get; set; }

        public float Distance;

        public Edge(GraphNode startNode, GraphNode endNode, Panel roadPanel)
        {
            StartNode = startNode;
            EndNode = endNode;
            RoadPanel = roadPanel;
        }


        public void ChangeRoadColor(Color newColor)
        {
            if (RoadPanel != null)
            {
                RoadPanel.BackColor = newColor;
            }
        }
    }


}
