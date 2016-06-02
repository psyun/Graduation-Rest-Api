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
    public class MembershipCardService : IMembershipCardService
    {
        private IUnitOfWork _unitOfWork;
        private IMembershipCardRespository _membershipCard;
        public MembershipCardService(IUnitOfWork unitOfWork,
            IMembershipCardRespository membershipCard)
        {
            this._unitOfWork = unitOfWork;
            this._membershipCard = membershipCard;

        }
        public Infranstructure.ResponseResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult GetAll()
        {
            var result = new ResponseResult();
            try
            {
                result.data = _membershipCard.GetAll()
                    .Select(entity => new MembershipCardDTO(entity));

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

        public Infranstructure.ResponseResult Add(DTO.MembershipCardDTO dto)
        {
            var result = new ResponseResult();
            try
            {
                var entity = dto.ToEntity();
                var addedEntity = _membershipCard.Add(entity);
                if (this.Commit() >= 0)
                {
                    result.description = "增加会员名成功!";
                }
            }
            catch (RepoException ex) { }

            return result;
        }

        public Infranstructure.ResponseResult Update(DTO.MembershipCardDTO dto)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Infranstructure.ResponseResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
        }



        public ResponseResult GetMany(int barbershopId)
        {
            var result = new ResponseResult();
            try
            {
                result.data = _membershipCard.GetMany(o => o.BarbershopId == barbershopId)
                    .ToList()
                    .Select(entity => new MembershipCardDTO(entity));

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
    }
}
