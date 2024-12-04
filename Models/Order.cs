using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Order
    {

        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime? AccessDate { get; set; }
        [AllowedValues(["ineer order","outer order"])]
        public string Type { get; set; }

        public bool DeliverState { get; set; }

        public int DeliveryEmployer { get; set; }

        public double Price { get; set; }

        public int NumberOfItems { get; set; }
        [ForeignKey("table")]
        public int? TableId { get; set; }
        public Table table { get; set; }
        public ICollection<Orders_Foodrinks> orders_foodrinks { get; set; }
    }
}
