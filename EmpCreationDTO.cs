using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Validations;

namespace WebApplication1.DTOs
{
    public class EmpCreationDTO
    {
        [MaxLength(50)]
        [FirstLetterUpperCase]

        public string name { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
    }
}
