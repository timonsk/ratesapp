using AutoMapper;
using RatesApp.Dto;
using RatesApp.Extensions;
using RatesApp.Models;

namespace RatesApp.Mappings
{
    public class VatRateMappingProfile : Profile
    {
        private const string  DateFormt = "yyyy-dd-MM";

        public VatRateMappingProfile()
        {
            CreateMap<RateDto, Rate>()
                .ForMember(d=> d.Standard, opt => opt.MapFrom(src => src.Standard));            

            CreateMap<PeriodDto, Period>()
                .ForMember(d=> d.Rates, opt => opt.MapFrom(src => src.Rates))
                .ForMember(d=> d.EffectiveFrom, opt => opt.MapFrom(src => src.EffectiveFrom.TryParseDateOrDefault(DateFormt)));

            CreateMap<CountryDto, Country>()
                .ForMember(d=> d.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(d=> d.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
                .ForMember(d=> d.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(d=> d.Periods, opt => opt.MapFrom(src => src.Periods));  
            
            CreateMap<VatRateDto, VatRate>()
                .ForMember(d=> d.Countries, opt => opt.MapFrom(src => src.Rates)); 
        }
    }
}