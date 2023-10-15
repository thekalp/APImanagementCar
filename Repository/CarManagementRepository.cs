using Context.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.BaseClass;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarManagementRepository: BaseContext, ICarManagementRepository 
    {
        public CarManagementRepository(TestContext context) : base(context)
        {

        }   
        public async Task<List<TblCarManagement>> GetDataForCarmanagement(int id)
        {
            if(id > 0)
            {
                return await _context.TblCarManagements.Where(x => x.Id == id).ToListAsync();
            }
            else
            {
                return await _context.TblCarManagements.Where(x => x.Id > 0).ToListAsync();
            }
            
        }
        public async Task<int> CreateSqlStoredProcedure(string mode, TblCarManagement model)
        {

            try
            {
                string sql = "EXEC [sp_CarManagement] @Mode,@ID,@Brand,@ModelName,@Description,@Feacture,@Price,@DOM,@Image";
                List<SqlParameter> parameter = new List<SqlParameter>
            {
                new SqlParameter("@Mode", mode),    
                new SqlParameter("@ID",DBNull.Value),
                new SqlParameter("@Brand", model.Brand),
                new SqlParameter("@ModelName", model.ModelName),
                new SqlParameter("@Description", model.Description),
                new SqlParameter("@Feacture", model.Feacture),
                new SqlParameter("@Price", model.Price),
                new SqlParameter("@DOM",model.Dom),
                new SqlParameter("@Image", model.Image),
            };
                _context.Database.SetCommandTimeout(120);
                return await _context.Database.ExecuteSqlRawAsync(sql, parameter.ToArray());

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<int> UpdateSqlStoredProcedure(string mode, TblCarManagement model)
        {

            try
            {
                string sql = "EXEC [sp_CarManagement] @Mode,@ID,@Brand,@ModelName,@Description,@Feacture,@Price,@DOM,@Image";
                List<SqlParameter> parameter = new List<SqlParameter>
            {
                new SqlParameter("@Mode", mode),
                new SqlParameter("@ID",model.Id),
                new SqlParameter("@Brand", model.Brand),
                new SqlParameter("@ModelName", model.ModelName),
                new SqlParameter("@Description", model.Description),
                new SqlParameter("@Feacture", model.Feacture),
                new SqlParameter("@Price", model.Price),
                new SqlParameter("@DOM",model.Dom),
                new SqlParameter("@Image", model.Image),
            };
                _context.Database.SetCommandTimeout(120);
                return await _context.Database.ExecuteSqlRawAsync(sql, parameter.ToArray());

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<int> DeleteSqlStoredProcedure(string mode, int ID)
        {

            try
            {
                string sql = "EXEC [sp_CarManagement] @Mode,@ID";
                List<SqlParameter> parameter = new List<SqlParameter>
            {
                new SqlParameter("@Mode", mode),
                new SqlParameter("@ID",ID)
               
            };
                _context.Database.SetCommandTimeout(120);
                return await _context.Database.ExecuteSqlRawAsync(sql, parameter.ToArray());

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
