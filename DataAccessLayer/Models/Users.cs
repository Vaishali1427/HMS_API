using System.ComponentModel.DataAnnotations;


namespace Data_Access_Layer.Models
{
    public class Users
    {

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = "Max 20 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, ErrorMessage = " Password should be of string type and max 20 characters!")]
        public string Password { get; set; }

    }
}
