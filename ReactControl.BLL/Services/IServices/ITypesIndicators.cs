using ReactControl.DTOs.DTOs;

namespace ReactControl.BLL.Services.IServices;

public interface ITypesIndicators
{
    Task<IEnumerable<TypeIndicator>> GetAllAsync();
    Task<TypeIndicator> GetAsync(int id);
    Task AddAsync(TypeIndicator typeIndicator);
    Task UpdateAsync(TypeIndicator typeIndicator);
    Task RemoveAsync(int id);
}