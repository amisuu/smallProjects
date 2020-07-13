using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace Pagination
{
    public class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            table.CreateList();
            table.Pagination();
        }
    }   
}