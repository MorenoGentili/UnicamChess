using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using Chess.Model;
using Chess.Model.Pieces;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            SimpleXUnitRunner.SimpleXUnit.RunTests();
            Console.ReadKey();
        }
    }
}
