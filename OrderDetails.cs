using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public  class OrderDetails
    {
        public int Id { get; set;}

        public int Orderheader { get; set; }

        public OrderHeader OrderHeader { get; set; }

        public int ItemId { get; set;}

        public Item Item { get; set; }

        public int Count { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }


        public double Price { get; set; }


    }
}
