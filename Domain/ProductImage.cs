using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ProductImage
    {
        public int ID { get; set; }
        public  String Img { get; set; }
        public Product RelatedProduct { get; set; }

    }
}
