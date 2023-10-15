using Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICarManagement
    {
        Task<List<TblCarManagement>> GetDataForCarmanagement(int id);

        Task<int>  CreateSqlStoredProcedure(string mode, TblCarManagement model);

        Task<int> UpdateSqlStoredProcedure(string mode, TblCarManagement model);

        Task<int> DeleteSqlStoredProcedure(string mode,int ID);

    }
}
