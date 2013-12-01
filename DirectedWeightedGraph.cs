using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class DirectedWeightedGraph<NodeType, T3>: Graph<NodeType>{
        public DirectedWeightedGraph() : base() { }

        public DirectedWeightedGraph(params NodeType[] nodeData)
            : base() {
            foreach (NodeType node in nodeData) Nodes.Add(new Node<NodeType>(node));
        }

        public bool AddNode(Node<NodeType> node) {
            return Nodes.Add(node);
        }

        public bool AddEdge(Node<NodeType> fromNode, Node<NodeType> toNode, T3 weight) {
            if (!(Nodes.Contains(fromNode) && Nodes.Contains(toNode))) return false;
            DirectedWeightedEdge<NodeType, T3> dwe = new DirectedWeightedEdge<NodeType, T3>(fromNode, toNode, weight);
            return AddEdge(dwe);
        }

        public override bool AddEdge(Edge<NodeType> edge) {
            return Edges.Add(edge);
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
