using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public abstract class Edge<NodeType> {
        protected Tuple<Node<NodeType>, Node<NodeType>> endNodes;

        public Tuple<Node<NodeType>, Node<NodeType>> EndNodes { get { return endNodes; } }

        public Edge(Node<NodeType> t1, Node<NodeType> t2) {
            endNodes = new Tuple<Node<NodeType>, Node<NodeType>>(t1, t2);
        }

        public override int GetHashCode() {
            int hashCodeConstant = 17;
            return hashCodeConstant + endNodes.Item1.GetHashCode() + endNodes.Item2.GetHashCode();
        }

        public override bool Equals(object obj) {
            Edge<NodeType> comparisionObject = (Edge<NodeType>)obj;
            return (endNodes.Item1.Equals(comparisionObject.EndNodes.Item1) && endNodes.Item2.Equals(comparisionObject.EndNodes.Item2))
                || (endNodes.Item1.Equals(comparisionObject.EndNodes.Item2) && endNodes.Item2.Equals(comparisionObject.EndNodes.Item1));
        }

        public override string ToString() {
            return EndNodes.Item1 + "-----" + EndNodes.Item2;
        }
    }
}
