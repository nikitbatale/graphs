using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class WeightedEdge<NodeType, WeightType> : Edge<NodeType>{
        WeightType weight;

        public WeightType Weight { get { return weight; } }

        public WeightedEdge(Node<NodeType> t1, Node<NodeType> t2, WeightType t3)
            : base(t1, t2) {
            weight = t3;
        }

        public override int GetHashCode() {
            int hashCodeConstant = 17;
            return hashCodeConstant + weight.GetHashCode() + base.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj == this) return true;
            return weight.Equals((obj as WeightedEdge<NodeType, WeightType>).Weight) && base.Equals(obj);
        }

        public override string ToString() {
            return endNodes.Item1.ToString() + "--" + weight.ToString() +"--" + endNodes.Item2.ToString();
        }
    }

}
