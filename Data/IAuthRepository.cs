using System.Threading.Tasks;
using RolePlayingGame.Models;

namespace RolePlayingGame.Data
{
    public interface IAuthRepository
    {
        //return the int ID of the user
         Task<ServiceResponse<int>> Register(User user, string password);

         // login and returns token as string
         Task<ServiceResponse<string>> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}