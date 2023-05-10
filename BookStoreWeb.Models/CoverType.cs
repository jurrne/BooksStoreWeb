using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStoreWeb.Models
{
    public class CoverType
    {
    
        public string? Name { get; set; }
        [Display(Name = "Soort kaft")]
        [Range(minimum: 1, maximum: 50, ErrorMessage = "{0} moet tussen {1} en {2} liggen")]

        [Key]
        public int Id { get; set; }

    }
}
