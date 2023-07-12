using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class Department
    {
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string? Dept_Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string? Dept_Name { get; set; }
    }
}
