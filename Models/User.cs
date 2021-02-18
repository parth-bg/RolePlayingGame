using System.Collections.Generic;

namespace RolePlayingGame.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // user gets the list of rpg-characters
        public List<Character> Characters { get; set; }
        
    }
}