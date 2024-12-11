using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estructuras_lineales_colas_
{
    internal class Node
    {
        public int Turn { get; set; }
        public Dish Dish { get; set; }
        public Node Next { get; set; }

        public Node(int turn, Dish dish)
        {
            Turn = turn;
            Dish = dish;
            Next = null;
        }
        public override string ToString()
        {
            return $"{Turn} (${Dish})";
        }
    }
}
