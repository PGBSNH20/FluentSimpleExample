using System;

namespace FluentSimpleExample
{
    public interface ICarApi
    {
        ICarApi AddPassanger(string name);

        void ListAllPassangers();
    }
}