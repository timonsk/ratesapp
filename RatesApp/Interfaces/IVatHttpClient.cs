using System.Threading.Tasks;
using RatesApp.Dto;

namespace RatesApp.Interfaces
{
    public interface IVatHttpClient
    {
        Task<VatRateDto> GetVatRates(); 
    }
}