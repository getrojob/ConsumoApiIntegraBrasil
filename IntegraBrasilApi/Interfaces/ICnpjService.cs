using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface ICnpjService
    {
        Task<ResponseGenerico<CnpjResponse>> BuscaCnpj(string cnpj);
    }
}