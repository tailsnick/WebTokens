using System.ComponentModel.DataAnnotations;

namespace WebTokens.Model
{
    public class User
    {
        [Key]
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
