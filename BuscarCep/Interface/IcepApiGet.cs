using CatalogoMVC.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoMVC.Interface
{
    public interface IcepApiGet
    {
        [Get("/ws/{cep}/json/") ]
        Task<Fornecedor> GetEndereco(string cep);   
    }
}
