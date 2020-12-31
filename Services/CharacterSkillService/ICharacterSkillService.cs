using System.Threading.Tasks;
using Blog.Dtos.Character;
using Blog.Dtos.CharacterSkill;
using Blog.Models;

namespace Blog.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}