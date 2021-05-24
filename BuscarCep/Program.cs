using CatalogoMVC.Interface;
using CatalogoMVC.Models;
using System;
using System.Threading.Tasks;

namespace BuscarCep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Fornecedor f = new Fornecedor();
            try
            {
                
                var cepCliente = RestService.For<IcepApiGet>("http://viacep.com.br/");

                Console.WriteLine("Digite o cep...");

                f.cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando o Cep...{0}", f.cepInformado);
                var endereco = await cepCliente.GetEndereco(f.cepInformado);

                Console.WriteLine("Rua...{0}", endereco.Logradouro);
                Console.WriteLine("Bairro...{0}", endereco.Bairro);
                Console.WriteLine("Cidade...{0}", endereco.Localidade);                
                Console.WriteLine("Estado...{0}", endereco.Uf);

            }
            catch (Exception e)
            {
                Console.WriteLine(" Erro ao consultar o Cep...{0}, {1}", f.cepInformado, e.Message);
            }
        }
    }
}
