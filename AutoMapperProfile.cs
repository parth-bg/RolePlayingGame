using AutoMapper;
using RolePlayingGame.Dtos.Character;
using RolePlayingGame.Models;

namespace RolePlayingGame
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}