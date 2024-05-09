namespace ReactControl.DTOs.DTOs;

public class IndicatorDto
{
    public int Id { get; set; }
    public TypeIndicator? Type { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
}