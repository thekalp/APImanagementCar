using Context.Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarmanagmentService:ICarManagement
    {
        private readonly ICarManagementRepository _ICarManagementRepository;

        public CarmanagmentService(ICarManagementRepository ICarManagementRepository)
        {
            _ICarManagementRepository = ICarManagementRepository;
        }
        public async Task<List<TblCarManagement>> GetDataForCarmanagement(int id)
        {
            return await _ICarManagementRepository.GetDataForCarmanagement(id);
        }
        public async Task<int> CreateSqlStoredProcedure(string mode, TblCarManagement model)
        {
            return await _ICarManagementRepository.CreateSqlStoredProcedure(mode, model);
        }
        public async Task<int> UpdateSqlStoredProcedure(string mode, TblCarManagement model)
        {
            return await _ICarManagementRepository.UpdateSqlStoredProcedure(mode, model);
        }
        public async Task<int> DeleteSqlStoredProcedure(string mode,int ID)
        {
            return await _ICarManagementRepository.DeleteSqlStoredProcedure(mode,ID);
        }
    }
}
