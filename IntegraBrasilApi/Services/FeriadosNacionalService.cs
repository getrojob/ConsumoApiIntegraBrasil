using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class FeriadosNacionalService : IFeriadosNacionalService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public FeriadosNacionalService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<FeriadosNacionalResponse>>> BuscarFeriado(string ano)
        {
            var feriado = await _brasilApi.BuscarFeriado(ano);
            return _mapper.Map<ResponseGenerico<List<FeriadosNacionalResponse>>>(feriado);
        }
    }
}