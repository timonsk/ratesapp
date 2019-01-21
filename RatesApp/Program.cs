using System;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using RatesApp.Clients;
using RatesApp.Dto;
using RatesApp.Mappings;
using RatesApp.Models;

namespace RatesApp
{
    class Program
    {
        private static VatHttpClient _client;
        private const int RateCount = 3;
        private const int MaxLineLngth = 100;
        private static readonly DateTime EffectiveDateFrom = DateTime.Today;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Rate calculation program");

            Initialize();
            var dtoRate =  await _client.GetVatRates();
            VatRate rate = Mapper.Map<VatRateDto, VatRate>(dtoRate);

            Console.WriteLine($"Getting {RateCount} lowest vat rates:\n");
            PrintAsJson(rate.GetLowest(EffectiveDateFrom, RateCount));

            Console.WriteLine(new string('-', MaxLineLngth));

            Console.WriteLine($"Getting {RateCount} highest vat rates:\n");
            PrintAsJson(rate.GetHighest(EffectiveDateFrom, RateCount));

            Console.WriteLine("Please press any key to exit the program...");
            Console.ReadKey();
        }

        private static void Initialize()
        {
            Console.WriteLine("Start initializing mapping profile");
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<VatRateMappingProfile>();
            });

            Console.WriteLine("Mapping profile initialization finished");

            Console.WriteLine("Start initializing Http Client");
            _client = new VatHttpClient();
            _client.Initialize();

            Console.WriteLine("Http Client initialization finished");
        }

        private static void PrintAsJson(object obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
        }
    }
}
