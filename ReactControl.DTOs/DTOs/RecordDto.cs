namespace ReactControl.DTOs.DTOs;

public class RecordDto
{
    public FermenterDto? FermenterDto { get; set; }
    public IEnumerable<IndicatorDto>? IndicatorsDtos { get; set; }
}