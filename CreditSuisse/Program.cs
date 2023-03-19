using CreditSuisse.Application.Automapper;
using CreditSuisse.Application.DTOs;
using CreditSuisse.Domain.Entities;
using CreditSuisse.Domain.Services;
using CreditSuisse.Domain.Services.Interfaces;
using CreditSuisse.Framework.Enum;
using CreditSuisse.Infra.DAL;
using CreditSuisse.Infra.Repositories;
using CreditSuisse.Infra.Repositories.Interfaces;
using CreditSuisse.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CreditSuisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var tradeService = serviceProvider.GetService<ITradeService>();

            var model = new TradePortfolioModel();

            Console.WriteLine("Hello, lets start!");
            Console.WriteLine("Please insert the referance date in the format mm/dd/yyyy.");

            string referanceDate = Console.ReadLine();

            model.ReferenceDate = DateTime.Parse(referanceDate);

            Console.WriteLine("Nice! Now please how many trades this Portfolio has ?");

            string tradeAmountString = Console.ReadLine();
            int.TryParse(tradeAmountString, out var tradeAmountInt);

            if (tradeAmountInt == 0)
            {
                Console.WriteLine("Oops! Something went wrong! Please Restart the console!");
            }
            else
            {
                model.TradeQuantity = tradeAmountInt;
                var listCategories = new List<string>();

                Console.WriteLine("Ok, now lets insert a trade at time, please, follow this pattern: 'value sector paymentDate',  lets go.");

                for (int i = 0; i < model.TradeQuantity; i++)
                {
                    Console.WriteLine("Insert Trade: ");

                    string firstTrade = Console.ReadLine();

                    TradeDTO operacao = CreateTradeFromStringValue(firstTrade);

                    model.TradeList.Add(operacao);
                }

                // This could be in a Application Layer

                foreach (var operacao in model.TradeList)
                {
                    var category = tradeService.GetCategoryForTrade(operacao, model.ReferenceDate);
                    listCategories.Add(category.ToString().ToUpper());
                }

                foreach(var category in listCategories)
                {
                    Console.WriteLine(category);
                }
                
            }

        }

        public static TradeDTO CreateTradeFromStringValue(string tradeBody)
        {
            var values = tradeBody.Split().ToList();

            double tradeValue = Convert.ToDouble(values.First());

            values.RemoveAt(0);

            ClientSectorEnum clientSector = (ClientSectorEnum)Enum.Parse(typeof(ClientSectorEnum), values.First().ToLower(), true);

            values.RemoveAt(0);

            DateTime tradePendingPayment = DateTime.Parse(values.First());

            var trade = new TradeDTO();
            trade.Value = tradeValue;
            trade.ClientSector= clientSector;
            trade.NextPaymentDate = tradePendingPayment;

            return trade;

        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITradeRepository, TradeRepository>()
                .AddScoped<ITradeService, TradeService>()
                .AddScoped<DbContextMock>();

            services.AddAutoMapper(typeof(BootstraperAutomapper).Assembly);            
        }

    }
}