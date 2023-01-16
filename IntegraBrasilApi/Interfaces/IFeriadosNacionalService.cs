using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IFeriadosNacionalService
    {
        Task<ResponseGenerico<List<FeriadosNacionalResponse>>> BuscarFeriado(string ano);
    }
}