using System.Threading.Tasks;
using RolePlayingGame.Dtos.Fight;
using RolePlayingGame.Models;

namespace RolePlayingGame.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
    }
}