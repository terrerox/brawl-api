using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Dtos.Fight;
using Blog.Models;

namespace Blog.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDTO>>> GetHighscore();
    }
}