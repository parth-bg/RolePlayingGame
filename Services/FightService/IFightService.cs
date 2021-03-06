using System.Collections.Generic;
using System.Threading.Tasks;
using RolePlayingGame.Dtos.Fight;
using RolePlayingGame.Models;

namespace RolePlayingGame.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto requestDto);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}