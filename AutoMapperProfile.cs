using System.Linq;
using AutoMapper;
using RolePlayingGame.Dtos.Character;
using RolePlayingGame.Dtos.Skill;
using RolePlayingGame.Dtos.Weapon;
using RolePlayingGame.Models;

namespace RolePlayingGame
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}