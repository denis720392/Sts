using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class Management
    {
        public void ReadText(IReader reader)
        {
            Console.WriteLine(reader.ReadAllText());
        }
    }
}
