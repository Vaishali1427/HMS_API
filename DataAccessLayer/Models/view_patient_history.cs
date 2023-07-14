using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class view_patient_history
    {
        [Required(ErrorMessage = "This field is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid integer value!")]
        public int Patient_Id { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50, ErrorMessage = "Max 50 characters!")]
        public string? firstname { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        public string? lastname { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30)]
        public string? Phy_Id { get; set; }

    }
}
