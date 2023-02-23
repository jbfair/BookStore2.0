using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2_Group4.Models
{
    public class TaskModel
    {
        [Key]
        [Required]
        public int TaskID{ get; set; }

        [Required]
        public string Task { get; set; }

        public string Deadline { get; set; }
        [Required]
        public int Quadrant { get; set; }

        public bool Completed { get; set; }


        
        [Required]
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
