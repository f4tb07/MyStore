using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
     public class ProductPrice
    {
        public int ID { get; set; }
        public DateTime RgisterDate { get; set; }
        public DateTime Todate { get; set; }
        public double Value { set; get; }
        public Product RelatedProduct{ get; set; }

    }
}
