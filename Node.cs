using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs {
    public class Node<T> {
        T data;

        public T Data {
            get { return data; }
        }

        public Node(T t) { data = t; }

        public override int GetHashCode() {
            return data.GetHashCode();
        }

        public override bool Equals(object obj) {
            if(obj == this) return true;
            return data.Equals((obj as Node<T>).Data);
        }

        public override string ToString() {
            return data.ToString();
        }
    }
}
