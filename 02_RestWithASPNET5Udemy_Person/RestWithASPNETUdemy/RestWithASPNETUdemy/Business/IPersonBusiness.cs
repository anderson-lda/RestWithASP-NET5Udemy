using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();
        void Delete(long id);
        PersonVO Disable(long id);
        PersonVO Update(PersonVO person);
        PagedSearchVO<PersonVO> FindWithPagedSearch(string name,
            string sortDirection, int pageSize, int page);
    }
}
