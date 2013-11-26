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

        public override bool AddEdge(NodeType node1, NodeType node2) {
            throw new NotImplementedException();
        }
    }
}
