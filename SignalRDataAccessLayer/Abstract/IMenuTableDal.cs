﻿using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
	public interface IMenuTableDal :IGenericDal<MenuTable>
	{
		int MenuTableCount();
		void ChangeMenuTablesStatusToTrue(int id);
		void ChangeMenuTablesStatusToFalse(int id);
	}
}
