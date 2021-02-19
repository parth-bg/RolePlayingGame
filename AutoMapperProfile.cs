using AutoMapper;
using RolePlayingGame.Dtos.Character;
using RolePlayingGame.Dtos.Weapon;
using RolePlayingGame.Models;

namespace RolePlayingGame
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}