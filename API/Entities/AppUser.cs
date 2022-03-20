namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public AppUser(string UserName, byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.UserName = UserName;
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }

    }
}