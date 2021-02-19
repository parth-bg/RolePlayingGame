using System.Threading.Tasks;
using RolePlayingGame.Dtos.Character;
using RolePlayingGame.Dtos.Weapon;
using RolePlayingGame.Models;

namespace RolePlayingGame.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}