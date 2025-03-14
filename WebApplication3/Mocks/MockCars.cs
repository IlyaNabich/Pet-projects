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
                        ShortDesc = "Удобная и технологичная",
                        LongDesc = "Отличный автомобиль для городской жизни",
                        Img = "",
                        Price = 45000,
                        IsFavourite = true, 
                        Avaliable = true, 
                        Category = _CategoryCars.AllCategories.First() 
                    },
                    new Car {
                        Name = "BMW",
                        ShortDesc = "Элегантный и мощный",
                        LongDesc = "Идеален для дальних поездок и городских улиц",
                        Img = "",
                        Price = 50000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Audi",
                        ShortDesc = "Современный и динамичный",
                        LongDesc = "Легкость в управлении и стильный внешний вид",
                        Img = "",
                        Price = 46000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Mercedes",
                        ShortDesc = "Комфорт и роскошь",
                        LongDesc = "Эталон высокого качества и элегантности",
                        Img = "",
                        Price = 55000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Ford",
                        ShortDesc = "Надежность и доступность",
                        LongDesc = "Автомобиль для всей семьи с низкими расходами на обслуживание",
                        Img = "",
                        Price = 30000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Honda",
                        ShortDesc = "Устойчивость и экономия",
                        LongDesc = "Подходит для ежедневных поездок и экономичен в обслуживании",
                        Img = "",
                        Price = 28000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Porsche",
                        ShortDesc = "Экстремальный стиль и мощность",
                        LongDesc = "Спортивный автомобиль с непередаваемым драйвом",
                        Img = "",
                        Price = 57000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Chevrolet",
                        ShortDesc = "Доступность и универсальность",
                        LongDesc = "Отличный вариант для работы и отдыха",
                        Img = "",
                        Price = 32000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Nissan",
                        ShortDesc = "Технологии и безопасность",
                        LongDesc = "Современные системы безопасности и комфорта",
                        Img = "",
                        Price = 35000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Toyota",
                        ShortDesc = "Качество и долговечность",
                        LongDesc = "Автомобиль, который служит долго и не требует частых ремонтов",
                        Img = "",
                        Price = 40000,
                        IsFavourite = true,
                        Avaliable = true,
                        Category = _CategoryCars.AllCategories.First()
                    }, 
                    new Car {
                        Name = "ЖИГУЛИ",
                        ShortDesc = "Качество и долговечность",
                        LongDesc = "Автомобиль, который служит долго и не требует частых ремонтов",
                        Img = "",
                        Price = 40000,
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