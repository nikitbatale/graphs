using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public abstract class Edge<Node> {
        protected Tuple<Node, Node> endNodes;

        protected Tuple<Node, Node> EndNodes { get { return endNodes; } }

        public Edge(Node t1, Node t2) {
            endNodes = new Tuple<Node, Node>(t1, t2);
        }

        public override int GetHashCode() {
            int hashCodeConstant = 17;
            return hashCodeConstant + endNodes.Item1.GetHashCode() + endNodes.Item2.GetHashCode();
        }

        public override bool Equals(object obj) {
            Edge<Node> comparatorObject = (Edge<Node>)obj;
            return (endNodes.Item1.Equals(comparatorObject.EndNodes.Item1) && endNodes.Item2.Equals(comparatorObject.EndNodes.Item2))
                || (endNodes.Item1.Equals(comparatorObject.EndNodes.Item2) && endNodes.Item2.Equals(comparatorObject.EndNodes.Item1));
        }

        public override string ToString() {
            return EndNodes.Item1 + "-----" + EndNodes.Item2;
        }
    }
}
