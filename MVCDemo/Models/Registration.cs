using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Registration
    {
        [DisplayName("Jusu Vardas")]
        [Required (ErrorMessage ="Varda ivesti privaloma")]
        [MinLength(2, ErrorMessage = "Iveskite ne maziau 3 simboliu")]
        public string Name { get; set; }

        [DisplayName("Jusu Pavarde")]
        [Required(ErrorMessage = "Pavarde ivesti privaloma")]
        [MinLength(3, ErrorMessage ="Iveskite ne maziau 3 simboliu")]
        public string Surname { get; set; }

        [DisplayName("Jusu Amžsius")]
        [Range(0, 100, ErrorMessage = "Iveskite sveika skaiciu tarp 0 ir 100")]
        [Required(ErrorMessage = "Amziu ivesti privaloma")]
        public int? Age { get; set; }

        [DisplayName("Jusu Adresas")]
        [Required(ErrorMessage = "Adresa ivesti privaloma")]
        public  string Address { get; set; }



    }
}
