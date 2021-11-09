using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        //свойства 
        public int Value { get; set; }
        public Node Next { get; set; }
        //контструкторы 
        public Node(int value)
        {
            Value = value;
            Next = null;//cсылка на момент создания ноды никуда не ведет 
        }
    }
}

