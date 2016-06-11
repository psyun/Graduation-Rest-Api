using HDO2O.Infranstructure;
using HDO2O.IRepository;
using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Services
{
    public class FollowerService : IFollowerService
    {
        private IUnitOfWork _unitOfWork;
        private IFollowerRepository _repoFollower;
        public FollowerService(IUnitOfWork unitOfWork, IFollowerRepository repoFollower) 
        {
            this._unitOfWork = unitOfWork;
            this._repoFollower = repoFollower;
        }

        public ResponseResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult GetById(string id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseResult Add(DTO.FollowerDTO dto)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Update(DTO.FollowerDTO dto)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
        }
    }
}
