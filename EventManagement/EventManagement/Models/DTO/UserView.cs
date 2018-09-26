using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models.DTO
{
    public class UserView
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

    }
}