using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Node
    {
        private float info;
        private Node next;

        public Node(float x)
        {
            info = x;
            next = null;
        }

        public float Info
        {
            set { this.info = value; }
            get { return info; }
        }

        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
}
