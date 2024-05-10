using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EF
{
	public class EfGuideDal : GenericReposity<Guide>, IGuideDal
	{
	}
}
