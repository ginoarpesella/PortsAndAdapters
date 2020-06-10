using System;
using TestConsoleApplication.Controllers.Translate;
using TranslatorApplication.Commands.Translate;
using TranslatorApplication.Repositories;
using TranslatorInfrastructure.ApiDataSourceAdapter;
using TranslatorInfrastructure.FileDataSourceAdapter;
using TranslatorInfrastructure.SQLDataSourceAdapter;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // this will be injectected using auto.fac
            ITranslateDataSource dataSource = new ApiDataSource();
            ITranslateLogic logic = new TranslateLogic(dataSource);
            TranslateController controller = new TranslateController(logic);

            // creat httpClient to our controller for example

            TranslateRequest translateRequest = new TranslateRequest
            {
                MessageToTranslate = "I hope this works",
                SomeMetaData = "Auth Key: M$#F#*NJLS)S"
            };

            // invoke the httpClient example /api/v1/translate/translatemymessage - with the body
            TranslateResponse response = controller.TranslateMyMessage(translateRequest);
            
            Console.WriteLine("Starting process...");
            Console.WriteLine(response.TranslatedMessage);
            Console.WriteLine($"UserStats: {response.UserStats}");
            Console.ReadLine();
        }
    }
}
