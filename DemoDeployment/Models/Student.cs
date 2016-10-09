using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoDeployment.Models
{
    public class Student
    {
       
        public int StudentID { get; set; }

        [Required]
        public string Name { get; set; }

        
        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public string Phone { get; set; }

        [RegularExpression("^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$")]
        public string CNIC { get; set; }
        public string Address { get; set; }
    }
}