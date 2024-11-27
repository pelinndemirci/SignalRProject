﻿using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
         int CategoryCount();
         int ActiviteCategoryCount();
         int PassiveCategoryCount();
    }
}
