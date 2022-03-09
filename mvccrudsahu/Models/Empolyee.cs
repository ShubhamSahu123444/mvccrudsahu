using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvccrudsahu.Models
{
    public class Empolyee
    {
        public int Id { get; set; }
        [Display(Name="Empolyee name")]
        [Required(ErrorMessage ="Employee name can't Empty !")]
        [MinLength(3,ErrorMessage ="name must be min 3 char !")]
        public string Name { get; set; }
        [Display(Name = "Empolyee Place")]
        [Required(ErrorMessage ="Please enter your place!")]
        [MaxLength(30,ErrorMessage ="Please Place max 30 char !")]
        public string Place { get; set; }
        [Display(Name = "Empolyee Age")]
        [Required(ErrorMessage ="Please Enter Your Age")]
        
        public string Age { get; set; }
    }
}
