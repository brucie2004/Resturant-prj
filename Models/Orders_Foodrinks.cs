using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Orders_Foodrinks
    {

        public int Id { get; set; }
        [ForeignKey("order")]

        public int OrderId { get; set; }
        public Order order { get; set; }

        [ForeignKey("foodrink")]
        public int FoodrinkId { get; set; }
        public Foodrink foodrink { get; set; }

    }
}
