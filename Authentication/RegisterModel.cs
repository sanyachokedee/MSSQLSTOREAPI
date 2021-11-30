using System.ComponentModel.DataAnnotations;

namespace MSSQLStoreAPI.Authentication
{
    public class RegisterModel
    {
        // ต้องการ ถ้าไม่มีให้ Error ข้อความ
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        // [MinLength(8)]
        public string Password { get; set; }
    }
}