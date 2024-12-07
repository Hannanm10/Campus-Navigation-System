using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

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
        public void AddEdge(GraphNode from, GraphNode to, int distance, Color lineColor, float lineWidth = 10f)
        {
            if (!from.Neighbors.ContainsKey(to))
                from.AddNeighbor(to, distance);

            if (!to.Neighbors.ContainsKey(from))
                to.AddNeighbor(from, distance);

            // Add visual representation of the edge
            Edges.Add(new Edge(from, to, lineColor, lineWidth));
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
                edge.Draw(g);
            }
        }

        public List<GraphNode> Dijkstra(GraphNode start, GraphNode end)
        {
            var distances = new HashMap<GraphNode, int>();
            var previousNodes = new HashMap<GraphNode, GraphNode>();
            var unvisitedNodes = new HashSet<GraphNode>(Nodes);

            // Initialize distances and previous nodes
            foreach (var node in Nodes)
            {
                distances.Add(node, int.MaxValue); // Set initial distances to infinity
                previousNodes.Add(node, null);    // No previous nodes initially
            }
            distances.Add(start, 0); // Distance to the start node is 0

            while (unvisitedNodes.Count > 0)
            {
                // Get the closest node
                var closestNode = unvisitedNodes.OrderBy(node => distances.Get(node)).First();
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
        public Color LineColor { get; set; }
        public float LineWidth { get; set; }

        public Edge(GraphNode startNode, GraphNode endNode, Color lineColor, float lineWidth = 10f)
        {
            StartNode = startNode;
            EndNode = endNode;
            LineColor = lineColor;
            LineWidth = lineWidth;
        }

        // Draw method to render the edge using Graphics
        public void Draw(Graphics g)
        {
            // Convert coordinates to points for visualization
            Point startPoint = new Point((int)StartNode.Coordinates.x, (int)StartNode.Coordinates.y);
            Point endPoint = new Point((int)EndNode.Coordinates.x, (int)EndNode.Coordinates.y);

            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
