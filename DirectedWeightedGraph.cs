using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class DirectedWeightedGraph<NodeType, WeightType>: Graph<NodeType>{
        public DirectedWeightedGraph() : base() { }

        public DirectedWeightedGraph(params NodeType[] nodeData)
            : base() {
            foreach (NodeType node in nodeData) Nodes.Add(new Node<NodeType>(node));
        }

        public bool AddNode(Node<NodeType> node) {
            return Nodes.Add(node);
        }

        public override bool AddEdge(Edge<NodeType> edge) {
            if (!(Nodes.Contains(edge.EndNodes.Item1) && Nodes.Contains(edge.EndNodes.Item2))) return false;
            return Edges.Add(edge as DirectedWeightedEdge<NodeType, WeightType>);
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

        public override bool HasEdgeBetween(Node<NodeType> fromNode, Node<NodeType> toNode) {
            foreach(DirectedWeightedEdge<NodeType, WeightType> edge in Edges)
                if(edge.FromNode().Equals(fromNode) && edge.ToNode().Equals(toNode)) return true;
            return false;
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
