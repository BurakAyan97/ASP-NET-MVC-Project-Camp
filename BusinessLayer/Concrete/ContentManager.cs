using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        EfContentDal _contentDal;

        public ContentManager(EfContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content category)
        {

        }

        public void ContentDelete(Content category)
        {

        }

        public void ContentUpdate(Content category)
        {

        }

        public Content GetByID(int id)
        {
            return _contentDal.Get(x => x.ContentID == id);
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}
