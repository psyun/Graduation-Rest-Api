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
    public class HairDressLibraryService : IHairDressLibraryService
    {
        private IUnitOfWork _unitOfWork;
        private IHairDressLibraryRepository _repoHairDressLibrary;
        public HairDressLibraryService(IUnitOfWork unitOfWork, IHairDressLibraryRepository repoHairDressLibrary) 
        {
            this._unitOfWork = unitOfWork;
            this._repoHairDressLibrary = repoHairDressLibrary;
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

        public ResponseResult Add(DTO.HairDressLibraryDTO dto)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Update(DTO.HairDressLibraryDTO dto)
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
