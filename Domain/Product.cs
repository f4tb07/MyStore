using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Product
    {
       
        public int ID { get; set; }
        public int inStoreCount { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double CurrentPrice { get; set; }
        //first commit  for testing git private Price CurrentPrice { get; set; }
        public List<ProductImage> ImagesList { get; set; } = new List<ProductImage>();
        public List<ProductPrice> PriceHistory { get; set; } = new List<ProductPrice>();

        //private ItemOff CurrentOff { get; set; }
        public List<ProudctOff> OffList { get; set; } = new List<ProudctOff>();
        //public List<CustomerComment> CommentList { set; get; } = new List<CustomerComment>();


       

    }
}
