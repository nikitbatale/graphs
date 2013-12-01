using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class DirectedWeightedEdge<NodeType, T3> : WeightedEdge<NodeType, T3>, IDirectedEdge<NodeType> {

        public DirectedWeightedEdge(Node<NodeType> fromNode, Node<NodeType> toNode, T3 weight)
            : base(fromNode, toNode, weight) {
        }

        public Node<NodeType> FromNode() {
            return EndNodes.Item1;
        }

        public Node<NodeType> ToNode() {
            return EndNodes.Item2;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <summary>
        /// The commented loc where it the object is compared to itself is intentionally left commented as it is throwng a StackOverflow exception
        /// for some unknown reason.
        /// </summary>
        /// <param name="obj">The object with which the current object is to be compared.</param>
        /// <returns>Bool value depending upon the equality of the objects.</returns>
        public override bool Equals(object obj) {
            //if (this.Equals(obj)) return true;
            DirectedWeightedEdge<NodeType, T3> comparisionObject = obj as DirectedWeightedEdge<NodeType, T3>;
            return (FromNode().Equals(comparisionObject.FromNode()) && ToNode().Equals(ToNode())) && this.Weight.Equals(comparisionObject.Weight);
        }

        public override string ToString() {
            return FromNode() + "--" + Weight + "-->" + ToNode();
        }
    }
}
