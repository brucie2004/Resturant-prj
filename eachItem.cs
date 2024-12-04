using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project
{
    internal class eachItem
    {
        
        public int id { get; set; }
        public int foodrink_id { get; set; }
        public int ordered_number { get; set; }
        public double price { get; set; }
    }
}
