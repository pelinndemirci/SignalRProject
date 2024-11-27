using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TDeletee(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
