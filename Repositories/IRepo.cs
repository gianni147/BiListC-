using ASPNET.Models;

namespace ASPNET.Repositories
{
    public interface IRepo
    {
        IEnumerable<BiList> GetAllBiLists();

        BiList GetBiListById(int id);
    }
}