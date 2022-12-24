using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class EntradasData : IEntradasData
    {
        private readonly ISqlDataAccess _db;

        public EntradasData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<EntradasModel>> GetEntradas()
        {
            string sql = "select * from Entradas";

            return _db.LoadData<EntradasModel, dynamic>(sql, new { });
        }
    }
}
