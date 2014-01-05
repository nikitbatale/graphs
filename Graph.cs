using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public abstract class Graph<NodeType> {
        private HashSet<Node<NodeType>> nodes;
        private HashSet<Edge<NodeType>> edges;

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

        public abstract bool AddEdge(Edge<NodeType> edge);

        public abstract Graph<NodeType> SubGraph(params Edge<NodeType>[] edges);

        public HashSet<Node<NodeType>> Neighbours(Node<NodeType> node){
            List<Edge<NodeType>> listOfEdges = edges.ToList();
            List<Edge<NodeType>> listOfContainingEdges = listOfEdges
                .Where(edge => edge.EndNodes.Item1.Equals(node) || edge.EndNodes.Item2.Equals(node)).ToList();
            List<Node<NodeType>> neignbouringNodes = listOfContainingEdges.Select(
                edge => edge.EndNodes.Item1.Equals(node) ? edge.EndNodes.Item2 : edge.EndNodes.Item1).ToList();
            return new HashSet<Node<NodeType>>(neignbouringNodes);
        }

        public abstract bool HasEdgeBetween(Node<NodeType> fromNode, Node<NodeType> toNode); 

        public override string ToString() {
            string ret = "";
            if (nodes.Count == 0) ret += "No nodes added\n";
            ret += "Nodes:\n";
            foreach (Node<NodeType> node in nodes) ret += node.ToString() + "\n";
            if (edges.Count == 0) ret += "No edges added\n";
            ret += "Edges:\n";
            foreach (Edge<NodeType> edge in edges) ret += edge.ToString() + "\n";
            return ret;
        }

        public override bool Equals(object obj) {
            if (this == obj) return true;
            Graph<NodeType> comparisionObject = obj as Graph<NodeType>;
            foreach (Node<NodeType> node in nodes)
                if (!comparisionObject.Nodes.Contains(node)) {
                    Console.WriteLine(node.ToString() + " x ");
                    return false; }
            foreach (Edge<NodeType> edge in edges)
                if (!comparisionObject.Edges.Contains(edge)) {
                    Console.WriteLine(edge.ToString() + " x ");
                    return false; }
            return true;
        }

        public override int GetHashCode() {
            int hashCodeConstant = 17;
            foreach (Node<NodeType> node in nodes) hashCodeConstant += node.GetHashCode();
            foreach (Edge<NodeType> edge in edges) hashCodeConstant += edge.GetHashCode();
            return base.GetHashCode();
        }

        
    }
}
