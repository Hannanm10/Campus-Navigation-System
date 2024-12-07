using System;
using System.Collections.Generic;

namespace UetMap
{
    class GraphNode
    {
        public string Name { get; set; }
        public string Zone { get; set; }
        public string LocationType { get; set; }
        public (double x, double y) Coordinates { get; set; } // Coordinates for visualization
        public HashMap<GraphNode, int> Neighbors { get; set; } = new HashMap<GraphNode, int>(); // Using custom HashMap

        public GraphNode(string name, string zone, string locationType, (double x, double y) coordinates)
        {
            Name = name;
            Zone = zone;
            LocationType = locationType;
            Coordinates = coordinates;
        }

        public void AddNeighbor(GraphNode node, int distance)
        {
            Neighbors.Add(node, distance);
        }
    }
}
