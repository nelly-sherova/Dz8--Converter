using System;

namespace Converter
{
    class Converter
        {
            public double usd;
            public double eur;
            public double rub;
            public string val, value;
            public double n;
            public Converter(){}
            public Converter(double usd, double eur, double rub)
            {

                this.usd=usd;
                this.eur=eur;
                this.rub=rub;
            }
             public double SomUsd()
            {
                return n*usd;
            }
            public double SomEur()
            {
                return n*eur;
            }
            public double SomRub()
            {
                return n*rub;
            }
            public double UsdSom()
            {
                return n/usd;
            }
            public double EurSom()
            {
                return n/eur;
            }
            public double RubSom()
            {
                return n/rub;
            }
            public void ExchangeRate()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Курс валют: \nДоллар: {usd} \nЕвро: {eur} \nРубль: {rub}");
            }
            public void GetInfo()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (value == "usd")
                {
                    Console.WriteLine($"Ваша сумма($): {n}");
                    Console.WriteLine($"Ваша сумма в сомони: {UsdSom()}");
                }
                if (value == "eur")
                {
                    Console.WriteLine($"Ваша сумма(Евро): {n}");
                    Console.WriteLine($"Ваша сумма в сомони: {EurSom()}");
                }
                if (value == "rub")
                {
                    Console.WriteLine($"Ваша сумма(рубль): {n}");
                    Console.WriteLine($"Ваша сумма в сомони: {RubSom()}");
                }
                if (value == "som")
                {
                    Console.WriteLine($"Ваша сумма: {n}");
                    
                    switch (val)
                    {
                        case "usd": Console.WriteLine($"Ваша сумма в долларах: {SomUsd()}");
                        break;
                        case "eur": Console.WriteLine($"Ваша сумма в еврах: {SomEur()}");
                        break;
                        case "rub": Console.WriteLine($"Ваша сумма в рублях: {SomRub()}");
                        break;
                        default: Console.WriteLine("Вы ввели некорректный текст для обозначения валюты!!!");
                        break;
                    }
                }
                if(value!="som" && value!="rub" && value!="usd" && value!="eur") Console.WriteLine("Вы ввели некорректный текст для обозначения вашей валюты!!!");
                  
            }

        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу сумму: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Converter money = new Converter(0.098,0.091,7.33);
            Console.Write("Укажите наименование вашей купюры\n(доллар usd, евро eur, рубль rub, сомони som): ");
            string value = Console.ReadLine();
            money.ExchangeRate();
            if (value == "som")
            {
                Console.Write("Выберете в какую валюту хотите конвертировать свой сомони:\n(для доллара usd, для евро eur, для рубля rub): ");
                string val = Console.ReadLine();
                money.val = val;
            }
            money.value = value;
            money.n = n;
            
            money.GetInfo();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
