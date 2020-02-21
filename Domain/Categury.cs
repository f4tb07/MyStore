using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Categury
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Product> ProductList { get; set; }

    }
}
