using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

		public int ActiviteCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x=> x.Status == true).Count();
		}

		public int CategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x => x.Status == false).Count();
		}
	}
}
