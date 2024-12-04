using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Foodrink
    {
        [Key]
       public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
        [ForeignKey("category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public ICollection<Orders_Foodrinks> orders_foodrinks { get; set; }

    }
}
