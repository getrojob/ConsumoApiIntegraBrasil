using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Mappings
{
    public class CnpjMapping : Profile
    {
        public CnpjMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CnpjResponse, CnpjModel>().ReverseMap();
            CreateMap<CnaesSecundarioResponse, CnaesSecundarioModel>().ReverseMap();
            CreateMap<QsaResponse, QsaModel>().ReverseMap();
        }
    }
}