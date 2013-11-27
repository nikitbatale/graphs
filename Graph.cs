using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public abstract class Graph<NodeType> {
        HashSet<Node<NodeType>> nodes;
        HashSet<Edge<NodeType>> edges;

        public Graph(){
            this.nodes = new HashSet<Node<NodeType>>();
            this.edges = new HashSet<Edge<NodeType>>();
        }

        public HashSet<Node<NodeType>> Nodes {
            get { return nodes; }
        }

        public HashSet<Edge<NodeType>> Edges {
            get { return edges; }
        }

        public int Order() { return nodes.Count(); }
        public int Size() { return edges.Count(); }

        public abstract bool AddEdge(Node<NodeType> node1, Node<NodeType> node2);
    }
}
