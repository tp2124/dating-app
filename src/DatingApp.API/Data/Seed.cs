using System.Collections.Generic;
using System.Linq;
using DatingApp.API.Models;
using Newtonsoft.Json;

namespace DatingApp.API.Data
{
    public class Seed
    {
        // No bother to make this Async as this is only called on start up for seeding.
        public static void SeedUsers(DataContext context) {
            if (context.Users.Any()) {
                return;
            }
            var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);
            foreach (var user in users) {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Username = user.Username.ToLower();
                context.Users.Add(user);
            }
            context.SaveChanges();
        }

        // Copying this from AuthRepository here instead of opening up AuthRepository for this function being 
        // miss used with poor protection.
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            // Using IDispose on sha512 to ensure that this generated hash is not left in memory for any security concerns.
            // This will be utilized in the byte[] variables, but it will be cleaned up in memory.
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}