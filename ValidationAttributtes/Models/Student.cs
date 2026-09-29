using System.ComponentModel.DataAnnotations;

namespace ValidationAttributtes.Models
{
    public class Student
    {
        //[Required]
        [Required(ErrorMessage ="Name id Must")]//Custom error Message
        [StringLength(15, MinimumLength =3, ErrorMessage ="Name must be within 3 to 15 characters.")]
        public string  Name { get; set; }
    }
}
