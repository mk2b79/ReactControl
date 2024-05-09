using ReactControl.DTOs.DTOs;

namespace ReactControl.BLL.Services.IServices;

public interface IFermenterServices
{
    Task<IEnumerable<FermenterDto>> GetAllAsync();
    Task<FermenterDto> GetAsync(int id);
    Task AddAsync(FermenterDto fermenterDto);
    Task UpdateAsync(FermenterDto fermenterDto);
    Task RemoveAsync(int id);
}