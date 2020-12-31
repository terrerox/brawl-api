using System.Threading.Tasks;
using Blog.Dtos.Character;
using Blog.Dtos.Weapon;
using Blog.Models;

namespace Blog.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}