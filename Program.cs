using System;

namespace Converter
{
    class Converter
        {
            public double usd=0.098;
            public double eur=0.091;
            public double rub=7.33;
            public string val, value;
            public double n;
            public Converter(){}
            public Converter(double usd, double eur, double rub)
            {

                usd=this.usd;
                eur=this.eur;
                rub=this.rub;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
