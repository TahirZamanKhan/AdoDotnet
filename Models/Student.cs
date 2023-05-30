using System.ComponentModel.DataAnnotations;

namespace AdoDotnet.Models
{
    public class Student
    {
        public int StudentId { get; set; }


        [Display(Name ="Full Name:")]
        [Required]
        public string FullName { get; set; }

        [Display(Name = "Email:")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Mobile No.:")]
        [Required]
        public string Mobile { get; set; }

        [Display(Name = "Date of Birth:")]
        [Required]
        public DateTime DOB { get; set; }

        [Display(Name = "Notes")]
        [Required]
        public string Notes { get; set; }




    }
}
