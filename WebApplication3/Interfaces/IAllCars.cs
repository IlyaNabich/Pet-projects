using WebApplication3.Models;
namespace WebApplication3.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar (int carId);
    }
}
