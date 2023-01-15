using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigo);
        Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj);
    }
}
