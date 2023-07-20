using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class Patient_Enroll
    {
        [Required]
        [StringLength(20)]
        public string? Insurance { get; set; }

    }
}
