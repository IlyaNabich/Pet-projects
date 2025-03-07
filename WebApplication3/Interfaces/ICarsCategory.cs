using WebApplication3.Models;
namespace WebApplication3.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
