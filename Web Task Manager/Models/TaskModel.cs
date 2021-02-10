using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Task_Manager.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskID { get; set; }
        [DisplayName("Task Name")]
        [Required(ErrorMessage = "Field name is requied.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Task Description")]
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
