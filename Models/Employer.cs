using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Models
{
    internal class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="the name is Required")] 
        public string Name  { get; set; }
        [Required(ErrorMessage = "the phone Number is Required"),
            Length(10,10,
            ErrorMessage ="the phone number must be like 0912345678 and only 10  numbers"
            //ErrorMessageResourceName ="error"),
            ),Phone()]

        public string Phone { get; set; }
        [Required(ErrorMessage = "the address is Required")]

        public string Address { get; set; }

        [Required(ErrorMessage = "the age is Required"),
            AllowedValues([18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35],
            ErrorMessage = "the age must be older than 18 and younger than 36")]

        public int Age { get; set; }

        ICollection<Order> orders { get; set; }

    
       
    }


}
