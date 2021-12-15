using ASPNET.Contexts;
using ASPNET.Models;
using ASPNET.Repositories;

namespace ASPNET
{
    public class MysqlRepo : IRepo
    {
        private readonly BiListContext _context;


        public MysqlRepo(BiListContext context)
        {
            _context = context;

        }
        public IEnumerable<BiList> GetAllBiLists()
        {
            return _context.BiLists;
        }

        public BiList GetBiListById(int id)
        {
            return _context.BiLists.FirstOrDefault<BiList>(t => t.Id == id);
        }
    }
}