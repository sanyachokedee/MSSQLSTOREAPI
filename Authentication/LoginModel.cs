// มีแค่รับ Parameter 2 ตัว คือ Username , Password

using System.ComponentModel.DataAnnotations;

namespace MSSQLStoreAPI.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}