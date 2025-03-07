using WebApplication3.Interfaces;
using WebApplication3.Models;
namespace WebApplication3.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category> {
                    new Category { CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                    new Category { CategoryName = "Классические автомобили", Desc = "Машины с ДВС" }
                };
            }
        }
    }
}

