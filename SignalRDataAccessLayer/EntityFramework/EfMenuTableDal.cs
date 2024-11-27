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
	public class EfMenuTableDal :GenericRepository<MenuTable>, IMenuTableDal
	{
		public EfMenuTableDal(SignalRContext context) : base(context) { }

        public void ChangeMenuTablesStatusToFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.MenuTables.Where(x=>x.MenuTableId == id).FirstOrDefault();
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeMenuTablesStatusToTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.MenuTables.Where(x => x.MenuTableId == id).FirstOrDefault();
            value.Status = true;
            context.SaveChanges();
        }

        public int MenuTableCount()
		{
			using var context = new SignalRContext();
			return context.MenuTables.Count();
		}
	}
}
