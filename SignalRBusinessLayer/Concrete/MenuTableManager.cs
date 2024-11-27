using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
	public class MenuTableManager : IMenuTableService
	{
		private readonly IMenuTableDal _menuTableDal;

		public MenuTableManager(IMenuTableDal menuTableDal)
		{
			_menuTableDal = menuTableDal;
		}

		public void TAdd(MenuTable entity)
		{
			_menuTableDal.Add(entity);
		}

        public void TChangeMenuTablesStatusToFalse(int id)
        {
			_menuTableDal.ChangeMenuTablesStatusToFalse(id);
        }

        public void TChangeMenuTablesStatusToTrue(int id)
        {
			_menuTableDal.ChangeMenuTablesStatusToTrue(id);
        }

        public void TDeletee(MenuTable entity)
		{
			_menuTableDal.Delete(entity);
		}

		public MenuTable TGetById(int id)
		{
			return _menuTableDal.GetByID(id);
		}

		public List<MenuTable> TGetListAll()
		{
			return _menuTableDal.GetListAll();
		}

		public int TMenuTableCount()
		{
			return _menuTableDal.MenuTableCount();
		}

		public void TUpdate(MenuTable entity)
		{
			_menuTableDal.Update(entity);
		}
	}
}
