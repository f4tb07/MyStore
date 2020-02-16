using System;
using System.Collections.Generic;
using System.Text;





namespace Domain
{
    public class ProudctOff    {
        public int ID { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public Product RelatedProduct{ get; set; }
        //public Customer RelatedCustomer { get; set; }
        

    }
}
