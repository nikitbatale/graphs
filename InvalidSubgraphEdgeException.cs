using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    class InvalidSubgraphEdgeException : Exception {
        public InvalidSubgraphEdgeException(string message) : base(message){
        }
    }
}
