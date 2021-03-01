using System;

namespace FluentSimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarApi carApiTest = new CarApi();
            ICarApi carApi = new CarApi();
            //carApiTest.DoSomething();
            Console.WriteLine("Tom lista");
            carApi.ListAllPassangers();
            Console.WriteLine("Två passangrs");
            carApi.AddPassanger("stephan").AddPassanger("tom").ListAllPassangers();
        }
    }
}
