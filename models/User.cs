using System.ComponentModel.DataAnnotations;

namespace odysseasAPI.models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }

        public int? Age { get; set; }
    }
}
