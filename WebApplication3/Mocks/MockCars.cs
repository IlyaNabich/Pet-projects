using WebApplication3.Interfaces;
using WebApplication3.Models;
namespace WebApplication3.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _CategoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        Name = "Tesla", 
                        ShortDesc = "", 
                        LongDesc = "", 
                        Img = "", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Avaliable = true, 
                        Category = _CategoryCars.AllCategories.First() 
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "",
                        Price = 60000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                };
            }
        }
        
        public IEnumerable<Car> GetFavCars {  get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
