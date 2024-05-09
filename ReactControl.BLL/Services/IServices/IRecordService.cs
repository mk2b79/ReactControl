using ReactControl.DTOs.DTOs;

namespace ReactControl.BLL.Services.IServices;

public interface IRecordService
{
    Task<IEnumerable<RecordDto>> GetAllAsync(FermenterDto fermenterDto, DateTime date);
    Task AddAsync(RecordDto recordDto);
    Task UpdateAsync(RecordDto recordDto);
    Task RemoveAsync(RecordDto recordDto);
}