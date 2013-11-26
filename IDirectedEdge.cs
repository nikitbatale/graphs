﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public interface IDirectedEdge<Node> {
        Node FromNode();
        Node ToNode();
    }
}
