using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Print(string _text)
        {
            Console.WriteLine(_text);
        }
        static void Print(int _text)
        {
            Console.WriteLine(_text);
        }
        static void Print(bool _text)
        {
            Console.WriteLine(_text);
        }

        static void PrintByOrderLine(string _text, string _order)
        {

            if (_order == "-")
            {
                for (int i = _text.Length - 1; i >= 0; i--)
                {
                    Console.Write(_text[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < _text.Length; i++)
                {
                    Console.Write(_text[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintByOrderColumn(string _text, string _order)
        {
            if (_order == "-")
            {
                for (int i = _text.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(_text[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < _text.Length; i++)
                {
                    Console.WriteLine(_text[i] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string Name, Order;

            
            try
            {
                Name = args[0];
                Order = args[1];
                
                    try
                    {
                        Name = args[0];
                        Print("Введите порядок вывода");
                        Order = Console.ReadLine();
                        
                    }
                    catch
                    {
                        Print("Введите имя: ");
                        Name = Console.ReadLine();
                        Order = args[1];

                    }
                               
            }
           catch
            {
                Print("Введите имя: ");
                Name = Console.ReadLine();
                Print("Введите порядок вывода: ");
                Order = Console.ReadLine();
            }
            Print("В линию: ");
            PrintByOrderLine(Name, Order);
            Print("В столбец: ");
            PrintByOrderColumn(Name, Order);

        }
                    
    }
}
