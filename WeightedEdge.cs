using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class WeightedEdge<Node, T3> : Edge<Node>{
        T3 weight;

        public T3 Weight { get { return weight; } }

        public WeightedEdge(Node t1, Node t2, T3 t3)
            : base(t1, t2) {
            weight = t3;
        }

        public override int GetHashCode() {
            int hashCodeConstant = 17;
            return hashCodeConstant + weight.GetHashCode() + base.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj == this) return true;
            return weight.Equals((obj as WeightedEdge<Node, T3>).Weight) && base.Equals(obj);
        }

        public override string ToString() {
            return endNodes.Item1.ToString() + "--" + weight.ToString() +"--" + endNodes.Item2.ToString();
        }
    }

}
