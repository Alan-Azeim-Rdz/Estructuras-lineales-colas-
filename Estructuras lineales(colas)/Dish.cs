using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estructuras_lineales_colas_
{
    internal class Dish
    {
    public string Name { get; set; }
    public double Price { get; set; }

    public Dish(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} (${Price:F2})";
    }
}
}
