using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DraftManager : IDraftService
    {
        IDraftDal _draftDal;

        public DraftManager(IDraftDal draftDal)
        {
            _draftDal = draftDal;
        }

        public void DraftDelete(Draft draft)
        {
            throw new NotImplementedException();
        }

        public void DraftUpdate(Draft draft)
        {
            throw new NotImplementedException();
        }

        public Draft GetByID(int id)
        {
            return _draftDal.Get(x => x.DraftID == id);
        }

        public List<Draft> GetDraft(string p)
        {
            return _draftDal.List(x => x.SenderMail == p);
        }

        public void DraftAdd(Draft draft)
        {
            _draftDal.Insert(draft);
        }
    }
}
