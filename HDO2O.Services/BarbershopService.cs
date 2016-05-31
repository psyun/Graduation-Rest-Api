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
        public BarbershopService(IUnitOfWork unitOfWork, IBarbershopRepository repoBarbershop)
        {
            this._unitOfWork = unitOfWork;
            this._repoBarbershop = repoBarbershop;
        }

        public BarbershopDTO GetById(Guid id)
        {
            var barbershopDto = new BarbershopDTO(_repoBarbershop.GetById(id));

            return barbershopDto;
        }

        public IEnumerable<BarbershopDTO> GetAll()
        {
            var barbershops = _repoBarbershop.GetAll().Select(entity => new BarbershopDTO(entity));

            return barbershops;
        }

        public BarbershopDTO Add(BarbershopDTO dto)
        {
            var newBarbershopDto = new BarbershopDTO(_repoBarbershop.Add(dto.ToEntity()));
            this.Commit();

            return newBarbershopDto;
        }

        public BarbershopDTO Update(BarbershopDTO dto)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
        }
    }
}
