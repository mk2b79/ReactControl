using ReactControl.DTOs.DTOs;

namespace ReactControl.BLL.Services.IServices;

public interface IIndicatorServices
{
    Task<IEnumerable<IndicatorDto>> GetAllAsync(FermenterDto fermenterDto, DateTime date);
    Task<IndicatorDto> GetByIdAsync(int id);
    Task AddAsync(IndicatorDto indicatorDto);
    Task UpdateAsync(IndicatorDto indicatorDto);
    Task RemoveAsync(int id);
}