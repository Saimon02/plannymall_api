using System.ComponentModel.DataAnnotations.Schema;

namespace plannymall_api.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public byte[] Password_Hash { get; set; }

        public byte[] Password_Salt { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
