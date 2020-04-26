using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVCCrud.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Priority { get; set; }
    }
}
