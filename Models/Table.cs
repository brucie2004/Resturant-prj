using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Table
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="the number field is Required"),
            AllowedValues([1,2,3,4,5,6,7,8,9],
            ErrorMessage ="table number must be greater than or 1 and less than or 9")]
        public int Number { get; set; }

        public bool State { get; set; }
        [Required(ErrorMessage ="the Floor field is required"), 
            AllowedValues([1,2,3,4,5],
            ErrorMessage ="table floor must be a number from 1 to 5")]
        public int Floor { get; set; }

        public ICollection<Order> orders { get; set; }
    }
}
