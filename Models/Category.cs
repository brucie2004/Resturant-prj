using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Category
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Foodrink> foodrinks  { get; set;}
    }
}
