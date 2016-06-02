using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDO2O.DTO;
using HDO2O.Models;
using HDO2O.Infranstructure;
using HDO2O.IRepository;

namespace HDO2O.Services
{
    public class BarbershopService : IBarbershopService
    {
        private IUnitOfWork _unitOfWork;
        private IBarbershopRepository _repoBarbershop;
        private IHairDresserRepository _repoHairDresser;
        private IBarbershopHairDresserRespository _repoBarbershopHairDresser;

        public BarbershopService(IUnitOfWork unitOfWork,
            IBarbershopRepository repoBarbershop,
            IHairDresserRepository repoHairDresser,
           IBarbershopHairDresserRespository repoBarbershopHairDresser)
        {
            this._unitOfWork = unitOfWork;
            this._repoBarbershop = repoBarbershop;
            this._repoHairDresser = repoHairDresser;
            this._repoBarbershopHairDresser = repoBarbershopHairDresser;
        }

        public ResponseResult GetById(Guid id)
        {
            var result = new ResponseResult();
            try
            {
                result.data = new BarbershopDTO(_repoBarbershop.GetById(id));

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
            catch (Exception ex)
            {
                result.SetServerError(ex.Message);
                return result;
            }
        }

        public ResponseResult GetById(int id)
        {
            var result = new ResponseResult();
            try
            {
                result.data = new BarbershopDTO(_repoBarbershop.GetById(id));

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
            catch (Exception ex)
            {
                result.SetServerError(ex.Message);
                return result;
            }
        }

        public ResponseResult GetById(string id)
        {
            var result = new ResponseResult();
            try
            {
                result.data = new BarbershopDTO(_repoBarbershop.GetById(id));

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
            catch (Exception ex)
            {
                result.SetServerError(ex.Message);
                return result;
            }
        }
        public ResponseResult GetAll()
        {
            var result = new ResponseResult();
            try
            {
                result.data = _repoBarbershop.GetAll()
                    .Select(entity => new BarbershopDTO(entity));

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
            catch (Exception ex)
            {
                result.SetServerError(ex.Message);

                return result;
            }
        }

        public ResponseResult Add(BarbershopDTO dto)
        {
            var result = new ResponseResult();
            try
            {
                var ownerHairDresser = _repoHairDresser.GetById(dto.OwnerHairDresserId);
                if (ownerHairDresser != null)
                {
                    var entity = dto.ToEntity();
                    var addedEntity = _repoBarbershop.Add(entity);
                    _repoBarbershopHairDresser.Add(new BarbershopHairDresser
                    {
                        BarbershopId = addedEntity.Id,
                        HairDresserId = ownerHairDresser.Id
                    });

                    if (this.Commit() >= 0)
                    {
                        result.description = "增加理发店成功!";
                    }
                }
                else
                {
                    result.description = "请检查店主的信息是否正确!";
                    result.code = ResponseCodeEnum.INVALID_MODELSTATE;
                }

                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;
            }
            catch (Exception ex)
            {
                result.SetServerError(ex.Message);
                return result;
            }
        }

        public ResponseResult Update(BarbershopDTO dto)
        {
            throw new NotImplementedException();
        }

        public ResponseResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
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
