using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EF
{
	public class EfNewsLetterDal : GenericReposity<NewsLetter>, INewsLetterDal
	{
	}
}
