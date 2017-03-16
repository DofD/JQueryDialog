using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Your Contact No")]
        public string ContactNo { get; set; }
    }
}