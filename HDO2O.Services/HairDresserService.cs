using HDO2O.DTO;
using HDO2O.Infranstructure;
using HDO2O.IRepository;
using HDO2O.IServices;
using HDO2O.Models;
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
        private IBarbershopRepository _repoBarbershop;
        private IBarbershopHairDresserRespository _repoBarbershopHairDresser;

        public HairDresserService(IUnitOfWork unitOfWork,
            IHairDresserRepository repoHairDresser,
            IBarbershopRepository repoBarbershop,
            IBarbershopHairDresserRespository repoBarbershopHairDresser)
        {
            this._unitOfWork = unitOfWork;
            this._repoHairDresser = repoHairDresser;
            this._repoBarbershop = repoBarbershop;
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
            var result = new ResponseResult();
            try
            {
                result.data = new HairDresserDTO(_repoHairDresser.GetById(id));
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
        public ResponseResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }


        public ResponseResult GetById(int id)
        {
            var result = new ResponseResult();
            try
            {
                result.data = new HairDresserDTO(_repoHairDresser.GetById(id));
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

        public ResponseResult Delete(int id)
        {
            var result = new ResponseResult();
            try
            {
                var entity = _repoBarbershopHairDresser.GetById(id);
                if (entity == null)
                { throw new RepoException(ResponseCodeEnum.INVALID_MODELSTATE, "入驻信息错误"); }
                _repoBarbershopHairDresser.Delete(entity);
                if (this.Commit() >= 0)
                {
                    result.code = ResponseCodeEnum.SUCCESS;
                    result.description = "删除成功";
                }
                return result;
            }
            catch (RepoException ex)
            {
                return ex.ResponseResult;

            }
        }

        public ResponseResult Delete(string id)
        {
            throw new NotImplementedException();
        }




        public ResponseResult ApplyToJoin(int barbershopId, string userId)
        {
            var result = new ResponseResult();
            try
            {
                if (_repoBarbershop.GetById(barbershopId) == null)
                {
                    throw new RepoException(ResponseCodeEnum.INVALID_MODELSTATE, "店铺的id不能为空");
                }
                _repoBarbershopHairDresser.Add(new BarbershopHairDresser
                {
                    BarbershopId = barbershopId,
                    HairDresserId = userId,
                    VerifyState = BarbershopHairDresserVerifyState.UnVerify,
                    Type = BarbershopHairDresserType.General
                });
                if (this.Commit() >= 0)
                {
                    result.code = ResponseCodeEnum.SUCCESS;
                    result.description = "提交成功，等待管理员审核";
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


        public ResponseResult UpdateHairDressState(int settledId, BarbershopHairDresserVerifyState status)
        {
            var result = new ResponseResult();
            try
            {
                var entity = _repoBarbershopHairDresser.GetById(settledId);
                if (entity == null)
                { throw new RepoException(ResponseCodeEnum.INVALID_MODELSTATE, "入驻信息错误"); }
                entity.VerifyState = status;
                _repoBarbershopHairDresser.Update(entity);
                if (this.Commit() >= 0)
                {
                    result.code = ResponseCodeEnum.SUCCESS;
                    if (status == BarbershopHairDresserVerifyState.Pass)
                    {
                        result.description = "审核成功";
                    }
                    else
                    {
                        result.description = "已拒绝该申请";
                    }
                }
                return result;
            }
            catch (RepoException ex) { return ex.ResponseResult; }
        }
    }
}
