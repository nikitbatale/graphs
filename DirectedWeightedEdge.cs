using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class DirectedWeightedEdge<Node, T3> : WeightedEdge<Node, T3>, IDirectedEdge<Node> {

        public DirectedWeightedEdge(Node fromNode, Node toNode, T3 weight)
            : base(fromNode, toNode, weight) {
        }

        public Node FromNode() {
            return endNodes.Item1;
        }

        public Node ToNode() {
            return endNodes.Item2;
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override string ToString() {
            return endNodes.Item1 + "--" + Weight + "-->" + endNodes.Item2;
        }
    }
}
