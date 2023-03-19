using CreditSuisse.Application.Automapper;
using CreditSuisse.Application.DTOs;
using CreditSuisse.Application.Interfaces;
using CreditSuisse.Framework.Enum;
using CreditSuisse.IOC.CrussCutting;
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

            var tradeAppService = serviceProvider.GetService<ITradeAppService>();

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

                Console.WriteLine("Ok, now lets insert a trade at time, please, follow this pattern: 'value sector paymentDate',  lets go.");

                for (int i = 0; i < model.TradeQuantity; i++)
                {
                    Console.WriteLine("Insert Trade: ");

                    string tradeInput = Console.ReadLine();

                    TradeDTO operacao = tradeAppService.CreateTradeFromStringValue(tradeInput);

                    model.TradeList.Add(operacao);
                }

                var listCategories = tradeAppService.GetCategoryForEachTradeInPortfolio(model.TradeList, model.ReferenceDate);

                DisplayStringValueCategoriesFromPortfolio(listCategories);
                
            }

        }

        public static void DisplayStringValueCategoriesFromPortfolio(List<CategoriesEnum> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category.ToString());
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {            
            SuisseBootstraper.RegisterServices(services);

            services.AddAutoMapper(typeof(BootstraperAutomapper).Assembly);            
        }

    }
}