using Core.Entities;

namespace Entities.DTOs;

public class CarDetailDto:IDto
{
    public string Name { get; set; }
    public string BrandName { get; set; }
    public string ColorName { get; set; }
    public double DailyPrice { get; set; }
}