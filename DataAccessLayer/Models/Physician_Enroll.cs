using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class Physician_Enroll
    {

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? Phy_Id { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? Phy_Fname { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? Phy_Lname { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? Dept_Id { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [Range(0,float.MaxValue, ErrorMessage = "Please enter a valid float number!")]
        public float Phy_Exp { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? Phy_State { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? InsurancePlan { get; set; }

    }
}
