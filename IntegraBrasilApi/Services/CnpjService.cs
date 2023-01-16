using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class CnpjService : ICnpjService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CnpjService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CnpjResponse>> BuscaCnpj(string cnpj)
        {
            var buscarCnpj = await _brasilApi.BuscarCnpj(cnpj);
            return _mapper.Map<ResponseGenerico<CnpjResponse>>(buscarCnpj);
        }
    }
}