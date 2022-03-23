using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime BirtDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LasActivte { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public string KnownAs { get; set; }

        public AppUser(string UserName, byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.UserName = UserName;
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }


        // public int GetAge()
        // {
        //     return this.BirtDate.CalculateAge();
        // }

    }
}