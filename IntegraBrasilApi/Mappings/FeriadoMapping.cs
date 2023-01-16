using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Mappings
{
    public class FeriadoMapping : Profile
    {
        public FeriadoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<FeriadosNacionalResponse, FeriadosNacionalModel>().ReverseMap();
        }
    }
}