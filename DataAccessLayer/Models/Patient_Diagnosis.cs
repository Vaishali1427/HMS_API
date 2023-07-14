using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class Patient_Diagnosis
    {

        [Required(ErrorMessage = "This field is required.")]
        public int Patient_Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Diagnosis_Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? Symptoms { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(500, ErrorMessage = "Max 500 characters!")]
        public string? Diagnosis_Provided { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? Physician_Visited { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        public DateTime Date_of_diag { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10, ErrorMessage = "Max 10 characters!")]
        public string? Followup_Req { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        public DateTime Follow_Date { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public float Bill_Amt { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? Card_No { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10, ErrorMessage = "Max 10 characters!")]
        public string? Mode_of_Pay { get; set; }

    }
}
