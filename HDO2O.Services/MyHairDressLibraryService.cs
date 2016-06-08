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
    public class MyHairDressLibraryService : IMyHairDressLibraryService
    {
        private IUnitOfWork _unitOfWork;
        private IMyHairDressLibraryRepository _repoMyHairDressLibrary;
        public MyHairDressLibraryService(IUnitOfWork unitOfWork, 
            IMyHairDressLibraryRepository repoMyHairDressLibrary) 
        {
            this._unitOfWork = unitOfWork;
            this._repoMyHairDressLibrary = repoMyHairDressLibrary;
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

        public ResponseResult Add(DTO.MyHairDressLibraryDTO dto)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Update(DTO.MyHairDressLibraryDTO dto)
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
