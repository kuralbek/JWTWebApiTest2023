using Microsoft.AspNetCore.Identity;

namespace AuthTestCore.ModelEntity
{
    public class User
    {
        
        public int Id { get; set; }
        public string user_Name { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        //public List<Role> roles { get; set; }
        
    }
}
