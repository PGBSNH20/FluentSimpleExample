using System;
using System.Collections.Generic;

namespace FluentSimpleExample
{
    public class CarApi : ICarApi
    {
        private List<string> passengers = new List<string>();



        public ICarApi AddPassanger(string name)
        {
            passengers.Add(name);
            return this;
        }

        public void DoSomething(){
            Console.WriteLine("Something");
        }

        public void DoSomethingOther()
        {
            Console.WriteLine("Something other");
        }

        public void ListAllPassangers()
        {
            foreach(var p in passengers){
                Console.WriteLine(p);
            }
        }
    }
}