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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _soicalMediaDal;

        public SocialMediaManager(ISocialMediaDal soicalMediaDal)
        {
            _soicalMediaDal = soicalMediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
            _soicalMediaDal.Add(entity);
        }

        public void TDeletee(SocialMedia entity)
        {
            _soicalMediaDal.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
            return _soicalMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _soicalMediaDal.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _soicalMediaDal.Update(entity);
        }
    }
}
