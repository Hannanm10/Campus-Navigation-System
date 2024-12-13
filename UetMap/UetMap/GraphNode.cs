using System;
using System.Collections.Generic;

namespace UetMap
{
    class GraphNode
    {
        public string Name { get; set; }
        public string LocationType { get; set; }
        public HashMap<GraphNode, int> Neighbors { get; set; } = new HashMap<GraphNode, int>(); 

        public GraphNode(string name, string locationType)
        {
            Name = name;
            LocationType = locationType;
        }

        public void AddNeighbor(GraphNode node, float distance)
        {
            Neighbors.Add(node, (int)distance);
        }
    }
}
