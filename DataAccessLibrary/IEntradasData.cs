using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IEntradasData
    {
        Task<List<EntradasModel>> GetEntradas();
    }
}