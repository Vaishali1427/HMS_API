using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models

{
    public class Patient
    {
        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(@"^[1-9]$", ErrorMessage = "Please enter valid integer number!")]
        public int Patient_Id { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, ErrorMessage = "Max 30 characters!")]
        public string? LastName { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }


        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        [MaxLength(50)]
        public string? Email { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(@"^\+\d{1,3}-\d{3}\d{3}\d{4}$", ErrorMessage = " Invalid Phone Number")]

        public string? PhoneNo { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? State { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string? Insurance { get; set; }
        
    }
}
