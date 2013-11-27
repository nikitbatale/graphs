﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class DirectedWeightedEdge<NodeType, T3> : WeightedEdge<NodeType, T3>, IDirectedEdge<NodeType> {

        public DirectedWeightedEdge(Node<NodeType> fromNode, Node<NodeType> toNode, T3 weight)
            : base(fromNode, toNode, weight) {
        }

        public Node<NodeType> FromNode() {
            return endNodes.Item1;
        }

        public Node<NodeType> ToNode() {
            return endNodes.Item2;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (this.Equals(obj)) return true;
            DirectedWeightedEdge<NodeType, T3> comparisionObject = obj as DirectedWeightedEdge<NodeType, T3>;
            return (FromNode().Equals(comparisionObject.FromNode()) && ToNode().Equals(ToNode())) && this.Weight.Equals(comparisionObject.Weight);
        }

        public override string ToString() {
            return FromNode() + "--" + Weight + "-->" + ToNode();
        }
    }
}
