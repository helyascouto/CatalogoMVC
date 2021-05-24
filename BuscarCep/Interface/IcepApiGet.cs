using CatalogoMVC.Models;
using System.Threading.Tasks;

namespace CatalogoMVC.Interface
{
    public interface IcepApiGet
    {
        [Get("/ws/{cep}/json/") ]
        Task<Fornecedor> GetEndereco(string cep);   
    }
}
