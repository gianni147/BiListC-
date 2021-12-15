using System.Collections.Generic;
using System.Linq;
using ASPNET.Models;

namespace ASPNET.Repositories
{
    public class MockRepo : IRepo
    {
        List<BiList> bilist = new List<BiList>();

        public MockRepo()
        {
            bilist.Add(new BiList() { Id = 1, Name = "Gianni van schoor", Date = "27/12/2001", Idea = "Nintendo switch", Image = "ola" });
            bilist.Add(new BiList() { Id = 2, Name = "Tarik Amrani", Date = "22/10/1968", Idea = "Nintendo switch", Image = "alo" });
            bilist.Add(new BiList() { Id = 3, Name = "Allison VDB", Date = "22/10/1714", Idea = "Niks", Image = "alo" });

        }

        public IEnumerable<BiList> GetAllBiLists()
        {
            return bilist;
        }

        public BiList GetBiListById(int id)
        {
            BiList _bilist = bilist.FirstOrDefault<BiList>(t => t.Id == id);
            return _bilist;

        }

    }
}