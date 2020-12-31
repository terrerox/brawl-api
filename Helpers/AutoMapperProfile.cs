using System.Linq;
using AutoMapper;
using Blog.Dtos.Character;
using Blog.Dtos.CharacterSkill;
using Blog.Dtos.Fight;
using Blog.Dtos.Weapon;
using Blog.Models;

namespace Blog.Helpers
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
            CreateMap<Character, HighscoreDTO>();
        }        
    }
}