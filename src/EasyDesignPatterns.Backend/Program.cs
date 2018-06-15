using System;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy;

namespace EasyDesignPatterns.Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategyPresentational = new GamePresentational();

            strategyPresentational.Play();
            Console.ReadKey();
        }
    }
}
