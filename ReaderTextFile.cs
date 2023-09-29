using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class ReaderTextFile : IReader
    {
        private string path;
        private string text;
        public string Text { get 
            {
                return text;
            }
        }
        public string Path { get 
            {
                return path;
            }
        }

        public ReaderTextFile(string path) 
        {
            this.path = path;
            text = "";
        }
        public string Read() 
        {
            text = File.ReadAllText(path);
            return text;
        }
    }
}
