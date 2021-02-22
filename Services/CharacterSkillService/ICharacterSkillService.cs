using System.Threading.Tasks;
using RolePlayingGame.Dtos.Character;
using RolePlayingGame.Dtos.CharacterSkill;
using RolePlayingGame.Models;

namespace RolePlayingGame.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}