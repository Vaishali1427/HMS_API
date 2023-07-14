using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer.Models
{
    public class PhysicianSearchArguments
    {
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string? State { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string? Dept_Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string? InsurancePlan { get; set; }
    }
}
