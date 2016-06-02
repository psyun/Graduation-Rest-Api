using HDO2O.DTO;
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
    public class HairDresserService : IHairDresserService
    {

        private IUnitOfWork _unitOfWork;
        private IHairDresserRepository _repoHairDresser;
        private IBarbershopHairDresserRespository _repoBarbershopHairDresser;

        public HairDresserService(IUnitOfWork unitOfWork,
            IHairDresserRepository repoHairDresser,
            IBarbershopHairDresserRespository repoBarbershopHairDresser)
        {
            this._unitOfWork = unitOfWork;
            this._repoHairDresser = repoHairDresser;
            this._repoBarbershopHairDresser = repoBarbershopHairDresser;
        }

        public Infranstructure.ResponseResult GetAll()
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult Add(DTO.HairDresserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult Update(DTO.HairDresserDTO dto)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
        }

        public ResponseResult GetHairDresserByBarbershopId(int barbershopId)
        {
            var result = new ResponseResult();
            try
            {
                result.data = _repoBarbershopHairDresser
                    .GetMany(item => item.BarbershopId == barbershopId)
                    .ToList()
                    .Select(item => item.HairDresser)
                    .Select(item => new HairDresserDTO(item));

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
        }


        public ResponseResult GetById(string id)
        {
            throw new NotImplementedException();
        }
        public ResponseResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }


        public ResponseResult GetById(int id)
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

       
    }
}
