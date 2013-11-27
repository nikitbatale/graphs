using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public interface IDirectedEdge<NodeType> {
        Node<NodeType> FromNode();
        Node<NodeType> ToNode();
    }
}
