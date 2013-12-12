using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    class UndirectedWeightedGraph<NodeType, WeightType> : Graph<NodeType> {

        public UndirectedWeightedGraph(params NodeType[] nodeData)
            : base() {
                foreach (NodeType node in nodeData) Nodes.Add(new Node<NodeType>(node));            
        }

        public override bool AddEdge(Edge<NodeType> edge) {
            if (!(Nodes.Contains(edge.EndNodes.Item1) && Nodes.Contains(edge.EndNodes.Item2))) return false;
            return base.Edges.Add(edge as WeightedEdge<NodeType, WeightType>);
        }

        public override Graph<NodeType> SubGraph(params Edge<NodeType>[] subgraphEdges) {
            foreach (Edge<NodeType> edge in subgraphEdges)
                if (!Edges.Contains(edge))
                    throw new InvalidSubgraphEdgeException("Attempting to construct a subgraph from an edge that does not exist in the original graph.");
            DirectedWeightedGraph<NodeType, WeightType> subGraph = new DirectedWeightedGraph<NodeType, WeightType>();
            foreach (Edge<NodeType> edge in subgraphEdges) {
                subGraph.AddNode(edge.EndNodes.Item1);
                subGraph.AddNode(edge.EndNodes.Item2);
                subGraph.AddEdge(edge);
            }
            return subGraph;
        }

        
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
